﻿using Rubberduck.VBEditor;
using Rubberduck.VBEditor.SafeComWrappers.Abstract;
using System.Collections.Generic;

namespace Rubberduck.Parsing.VBA
{
    public interface IProjectManager
    {
        IReadOnlyCollection<(string ProjectId, IVBProject Project)> Projects { get; }

        void RefreshProjects();
        IReadOnlyCollection<QualifiedModuleName> AllModules();
    }
}
