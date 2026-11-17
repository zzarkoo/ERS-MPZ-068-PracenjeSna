using Presentation.Composition;
using Presentation.Console;

string rezim = args.Length > 0 ? args[0] : "in-memory";
AppContainer container = AppContainer.Create(rezim);
new ConsoleMenu(container.Io, container).Run();
