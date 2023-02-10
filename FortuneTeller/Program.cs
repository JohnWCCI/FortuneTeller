using FortuneTeller;

ConsoleDisplay display = new ConsoleDisplay("Welcome to the Fortune Teller");

ProcessUsers process = new ProcessUsers(display);
process.StartProcess();
