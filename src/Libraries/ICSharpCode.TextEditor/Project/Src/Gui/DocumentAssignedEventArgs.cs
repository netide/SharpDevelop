using System;
using System.Collections.Generic;
using System.Text;
using ICSharpCode.TextEditor.Document;

namespace ICSharpCode.TextEditor
{
    public delegate void DocumentAssignedEventHandler(object sender, DocumentAssignedEventArgs e);

    public class DocumentAssignedEventArgs
    {
        public IDocument OldDocument { get; private set; }
        public IDocument NewDocument { get; private set; }

        public DocumentAssignedEventArgs(IDocument oldDocument, IDocument newDocument)
        {
            OldDocument = oldDocument;
            NewDocument = newDocument;
        }
    }
}
