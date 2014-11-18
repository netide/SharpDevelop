// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Mike Krüger" email="mike@icsharpcode.net"/>
//     <version>$Revision$</version>
// </file>

using System;

namespace ICSharpCode.TextEditor.Actions 
{
	public class Cut : AbstractEditAction
	{
		public override bool Execute(TextArea textArea)
		{
			if (textArea.Document.ReadOnly) {
				return false;
			}
			textArea.ClipboardHandler.Cut(null, null);
            return true;
		}
	}
	
	public class Copy : AbstractEditAction
	{
		public override bool Execute(TextArea textArea)
		{
			textArea.AutoClearSelection = false;
			textArea.ClipboardHandler.Copy(null, null);
            return true;
		}
	}

	public class Paste : AbstractEditAction
	{
		public override bool Execute(TextArea textArea)
		{
			if (textArea.Document.ReadOnly) {
				return false;
			}
			textArea.ClipboardHandler.Paste(null, null);
            return true;
		}
	}
}
