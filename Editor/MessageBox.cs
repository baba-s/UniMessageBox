using UniMessageBox.Internal;

namespace UniMessageBox
{
	public static class MessageBox
	{
		public static DialogResult Show( string text )
		{
			return Show( text, string.Empty );
		}

		public static DialogResult Show( string text, string caption )
		{
			return Show( text, caption, MessageBoxButtons.OK );
		}

		public static DialogResult Show
		(
			string            text,
			string            caption,
			MessageBoxButtons buttons
		)
		{
			return Show( text, caption, buttons, MessageBoxIcon.None );
		}

		public static DialogResult Show
		(
			string            text,
			string            caption,
			MessageBoxButtons buttons,
			MessageBoxIcon    icon
		)
		{
#if UNITY_EDITOR_WIN

			var result = System.Windows.Forms.MessageBox.Show
			(
				text: text,
				caption: caption,
				buttons: buttons.ToMessageBoxButtons(),
				icon: icon.ToMessageBoxIcon()
			);
			return result.ToDialogResult();
#else
			switch ( buttons )
			{
				case MessageBoxButtons.OK:
				{
					var isOk = UnityEditor.EditorUtility.DisplayDialog
					(
						title: caption,
						message: text,
						ok: "OK"
					);
					return isOk ? DialogResult.OK : DialogResult.None;
				}
				case MessageBoxButtons.OKCancel:
				{
					var isOk = UnityEditor.EditorUtility.DisplayDialog
					(
						title: caption,
						message: text,
						ok: "OK",
						cancel: "キャンセル"
					);
					return isOk ? DialogResult.OK : DialogResult.Cancel;
				}
				case MessageBoxButtons.AbortRetryIgnore:
				{
					var index = UnityEditor.EditorUtility.DisplayDialogComplex
					(
						title: caption,
						message: text,
						ok: "中止",
						cancel: "無視",
						alt: "再試行"
					);
					return
						index == 0 ? DialogResult.Abort :
						index == 1 ? DialogResult.Ignore :
						             DialogResult.Retry;
				}
				case MessageBoxButtons.YesNoCancel:
				{
					var index = UnityEditor.EditorUtility.DisplayDialogComplex
					(
						title: caption,
						message: text,
						ok: "はい",
						cancel: "キャンセル",
						alt: "いいえ"
					);
					return
						index == 0 ? DialogResult.Yes :
						index == 1 ? DialogResult.Cancel :
						             DialogResult.No;
				}
				case MessageBoxButtons.YesNo:
				{
					var isOk = UnityEditor.EditorUtility.DisplayDialog
					(
						title: caption,
						message: text,
						ok: "はい",
						cancel: "いいえ"
					);
					return isOk ? DialogResult.Yes : DialogResult.No;
				}
				case MessageBoxButtons.RetryCancel:
				{
					var isOk = UnityEditor.EditorUtility.DisplayDialog
					(
						title: caption,
						message: text,
						ok: "再試行",
						cancel: "キャンセル"
					);
					return isOk ? DialogResult.Retry : DialogResult.Cancel;
				}
				default: throw new System.ArgumentOutOfRangeException( nameof( buttons ), buttons, null );
			}
#endif
		}
	}
}