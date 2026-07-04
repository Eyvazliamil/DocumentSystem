using DocumentSystem;

string[] keywrods = { "Basic", "Pro", "Expert", "Exit"};
string[] documentMethod = { "Open Document", "Edit Document", "Save Document" }; 

#region ShowMenu
static short ShowMenu(string[] items, string header = "")
{
    short selected = 0;
    while (true)
    {
        Console.Clear();
        if (header != "") Console.WriteLine(header);

        for (short i = 0; i < items.Length; i++)
        {
            if (i == selected)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"  >> {items[i]} <<");
                Console.ResetColor();
            }
            else
                Console.WriteLine($"    {items[i]}");
        }

        ConsoleKeyInfo key = Console.ReadKey(true);

        if (key.Key == ConsoleKey.UpArrow && selected > 0) selected--;
        if (key.Key == ConsoleKey.DownArrow && selected < items.Length - 1) selected++;
        if (key.Key == ConsoleKey.Enter) return selected;
        if (key.Key == ConsoleKey.Escape) return -1;
    }
}
#endregion 
bool isT = true;
while (isT)
{
    short keyInd = ShowMenu(keywrods, "========= DOCUMENT SECTON =========");
    switch (keyInd)
    {
        case 0:
            {
                DocumentProgram docProgram = new DocumentProgram();
                short keyDoc = ShowMenu(documentMethod, "========= BASIC DOCUMENT METHODS =========");
                switch (keyDoc)
                {
                    case 0: docProgram.OpenDocument(); break;
                    case 1: docProgram.EditDocument(); break;
                    case 2: docProgram.SaveDocument(); break;
                }
                Console.ReadKey();
                break;
            }
        case 1:
            {
                DocumentProgram docProgram = new ProDocumentProgram();
                short keyDoc = ShowMenu(documentMethod, "========= PRO DOCUMENT METHODS =========");
                switch (keyDoc)
                {
                    case 0:
                        {
                            if (docProgram is ProDocumentProgram pro)
                                pro.OpenDocument();
                            break;
                        }
                    case 1: docProgram.EditDocument(); break;
                    case 2: docProgram.SaveDocument(); break;
                }
                Console.ReadKey();
                break;
            }
        case 2:
            {
                DocumentProgram docProgram = new ExpertDocument();
                short keyDoc = ShowMenu(documentMethod, "========= EXPERT METHODS =========");
                switch (keyDoc)
                {
                    case 0: docProgram.OpenDocument(); break;
                    case 1:
                        {
                            if (docProgram is ExpertDocument expert)
                                expert.EditDocument();
                            break;
                        }
                    case 2: docProgram.SaveDocument(); break;
                }
                Console.ReadKey();
                break;
            }
        case 3: isT = false; break;
    }
}
