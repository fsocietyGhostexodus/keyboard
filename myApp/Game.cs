using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace KeyboardMenuDemo
{
    class Game{
        public void Start(){
            
           Title = "Paint Drying - THe Game!";
           RunMainMenu();
        }

        private void RunMainMenu(){
            string prompt = @"


        ███████╗███████╗ ██████╗  ██████╗██╗███████╗████████╗██╗   ██╗
        ██╔════╝██╔════╝██╔═══██╗██╔════╝██║██╔════╝╚══██╔══╝╚██╗ ██╔╝
        █████╗  ███████╗██║   ██║██║     ██║█████╗     ██║    ╚████╔╝ 
        ██╔══╝  ╚════██║██║   ██║██║     ██║██╔══╝     ██║     ╚██╔╝  
        ██║     ███████║╚██████╔╝╚██████╗██║███████╗   ██║      ██║   
        ╚═╝     ╚══════╝ ╚═════╝  ╚═════╝╚═╝╚══════╝   ╚═╝      ╚═╝   
                                                              


    Welcome to the Paint Drying Simulator. What would you like to do?
    (Use the arrow keys to cycle through option and press enter to select an option.)";
            string[] options = { "Play", "About", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int SelectedIndex = mainMenu.Run();


            WriteLine("Press any key to exit...");
            ReadKey(true);
        }

    }
    
}