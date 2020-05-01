using System;

namespace UniMessageBox.Internal
{
	internal static class MessageBoxIconExt
	{
		public static System.Windows.Forms.MessageBoxIcon ToMessageBoxIcon( this MessageBoxIcon self )
		{
			switch ( self )
			{
				case MessageBoxIcon.None:        return System.Windows.Forms.MessageBoxIcon.None;
				case MessageBoxIcon.Hand:        return System.Windows.Forms.MessageBoxIcon.Hand;
				case MessageBoxIcon.Question:    return System.Windows.Forms.MessageBoxIcon.Question;
				case MessageBoxIcon.Exclamation: return System.Windows.Forms.MessageBoxIcon.Exclamation;
				case MessageBoxIcon.Asterisk:    return System.Windows.Forms.MessageBoxIcon.Asterisk;
				default:                         throw new ArgumentOutOfRangeException( nameof( self ), self, null );
			}
		}
	}
}