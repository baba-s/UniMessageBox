using System;

namespace UniMessageBox.Internal
{
	internal static class MessageBoxButtonsExt
	{
		public static System.Windows.Forms.MessageBoxButtons ToMessageBoxButtons( this MessageBoxButtons self )
		{
			switch ( self )
			{
				case MessageBoxButtons.OK:               return System.Windows.Forms.MessageBoxButtons.OK;
				case MessageBoxButtons.OKCancel:         return System.Windows.Forms.MessageBoxButtons.OKCancel;
				case MessageBoxButtons.AbortRetryIgnore: return System.Windows.Forms.MessageBoxButtons.AbortRetryIgnore;
				case MessageBoxButtons.YesNoCancel:      return System.Windows.Forms.MessageBoxButtons.YesNoCancel;
				case MessageBoxButtons.YesNo:            return System.Windows.Forms.MessageBoxButtons.YesNo;
				case MessageBoxButtons.RetryCancel:      return System.Windows.Forms.MessageBoxButtons.RetryCancel;
				default:                                 throw new ArgumentOutOfRangeException( nameof( self ), self, null );
			}
		}
	}
}