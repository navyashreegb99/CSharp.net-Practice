using System;

namespace ATM.ConsoleApplication
{
    static class Entry 
    {
        static void Main()
        {
            var app = new AtmApp();
            app.Initialization();
            app.Execute();
        }    
    }

}