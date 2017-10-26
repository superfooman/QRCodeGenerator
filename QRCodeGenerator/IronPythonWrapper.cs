using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace QRCodeGenerator
{
    internal class IronPythonWrapper
    {
        internal ScriptEngine Engine { get; set; }
        internal ScriptSource Source { get; set; }
        internal CompiledCode CompliedSource { get; set; }
        internal ScriptScope Scope { get; set; }

        internal IronPythonWrapper(string pythonFilePath)
        {
            Engine = Python.CreateEngine();
            Source = Engine.CreateScriptSourceFromFile(pythonFilePath);
            CompliedSource = Source.Compile();
            Scope = Engine.CreateScope();
            LoadDefaultIronPythonLibs();
            CompliedSource.Execute(Scope);
        } 

        private void LoadDefaultIronPythonLibs()
        {
            string[] libs = new[] {
                "C:\\Program Files (x86)\\IronPython 2.7\\Lib",
                "C:\\Program Files (x86)\\IronPython 2.7\\DLLs",
                "C:\\Program Files (x86)\\IronPython 2.7",
                "C:\\Program Files (x86)\\IronPython 2.7\\lib\\site-packages"
            };

            if (Engine != null)
                Engine.SetSearchPaths(libs);
        }
    }
}
