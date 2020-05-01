using System;

namespace UniMessageBox.Internal
{
	internal static class DialogResultExt
	{
		public static DialogResult ToDialogResult( this System.Windows.Forms.DialogResult self )
		{
			switch ( self )
			{
				case System.Windows.Forms.DialogResult.None:   return DialogResult.None;
				case System.Windows.Forms.DialogResult.OK:     return DialogResult.OK;
				case System.Windows.Forms.DialogResult.Cancel: return DialogResult.Cancel;
				case System.Windows.Forms.DialogResult.Abort:  return DialogResult.Abort;
				case System.Windows.Forms.DialogResult.Retry:  return DialogResult.Retry;
				case System.Windows.Forms.DialogResult.Ignore: return DialogResult.Ignore;
				case System.Windows.Forms.DialogResult.Yes:    return DialogResult.Yes;
				case System.Windows.Forms.DialogResult.No:     return DialogResult.No;
				default:                                       throw new ArgumentOutOfRangeException( nameof( self ), self, null );
			}
		}
	}
}