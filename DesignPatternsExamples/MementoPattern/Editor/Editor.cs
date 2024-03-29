﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern.Editor
{
    // Originator
    public class Editor
    {
        public string Content { get; set; }

        public EditorState CreateState()
        {
            return new EditorState(Content);
        }

        public void Restore(EditorState state)
        {
            Content = state.Content;
        }
    }
}
