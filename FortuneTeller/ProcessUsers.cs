namespace FortuneTeller
{
    /// <summary>
    /// This class will process the input 
    /// </summary>
    public class ProcessUsers
    {
        private readonly IConsoleDisplay display;

        /// <summary>
        ///  Consturctor for Process User 
        /// </summary>
        /// <param name="display">Display object</param>
        public ProcessUsers(IConsoleDisplay display)
        {
            this.display = display;
        }


        /// <summary>
        /// Start the Process until exiting
        /// </summary>
        public void StartProcess()
        {
            // Here in loop forever
            while (true)
            {
                int controlDisplay = 0;
                User user = new User();
                while (true)
                {
                    try
                    {
                        switch (controlDisplay)
                        {
                            case 0:
                                display.ClearScreen("Type Exit to quit");
                                break;
                            case 1:
                                user.FirstName = display.PromptInput("First Name:");
                                break;
                            case 2:
                                user.LastName = display.PromptInput("Last Name:");
                                break;
                            case 3:
                                user.Age = int.Parse(display.PromptInput("Age:", true));
                                break;
                            case 4:
                                user.BirthMonth = int.Parse(display.PromptInput("Birth Month:", true));
                                break;
                            case 5:
                                user.Siblings = int.Parse(display.PromptInput("How many Siblings:"));
                                break;
                            case 6:
                                display.WriteLine(GetColorString());
                                user.FavoriteColor = ParseEnum(display.PromptInput("Favorite Color:"));
                                break;
                        }
                        controlDisplay++;
                        if (controlDisplay > 6)
                        {
                            break;
                        }
                    }
                    catch (ValidateException ve)
                    {
                        display.WriteLine();
                        display.WriteLine(ve.Message);
                        display.WriteLine();
                    }
                    catch (Exception ex)
                    {
                        display.WriteLine();
                        display.WriteLine(ex.Message);
                        display.WriteLine();
                    }
                }

                display.ClearScreen();
                display.WriteLine(user.ToString());
                display.ReadLine();
            }
        }

        private string GetColorString()
        {
            string retValue = "Colors:\n";
            for (int x = 0; x < (int)RoygbivEnum.Max; x++)
            {
                retValue += $"{(RoygbivEnum)x}\n";
            }
            retValue += "\n";
            return retValue;
        }
        private RoygbivEnum ParseEnum(string value)
        {
            try
            {
                return (RoygbivEnum)Enum.Parse(typeof(RoygbivEnum), value, true);
            }
            catch
            {
                throw new ValidateException("Color not found");
            }
        }

    }
}
