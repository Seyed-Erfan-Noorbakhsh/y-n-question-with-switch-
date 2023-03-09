////////..........Seyed Erfan Noorbakhsh............////////////
/////////////..........Seyed Erfan Noorbakhsh............//////////////

Console.WriteLine("Hi, Do you want to answer some questions? (y/n): ");
string input1;


LockYNquestion();



do
{
    switch (input1)
    {
        case "y":
        case "Y":
            Console.WriteLine("You said yes . let's continue ");
            break;
        case "n":
        case "N":
            Console.WriteLine("You said No ... Goodbye and thanks for using this program (: ");
            return;
        default:
            break;
    }
    break;
} while (input1 != "n" && input1 != "N");


    //////Nokte : mishod az method LockYNquestion baaz ham baraye switch haye zir estefade kard , vali tarjih dadam age User charactere eshtebah vaared kard 
    /// beram va soal baadi ro azash beporsam . baraye hamin faghat 1 baar az method LockYNquestion estefade shod ////////


    Console.WriteLine("Are you boy?: enter after (y/n) ");
string input2 = Convert.ToString(Console.ReadLine());
switch (input2)
{
    case "y":
    case "Y":
        Console.WriteLine("SO, you are boy");
        break;
    case "n":
    case "N":
        Console.WriteLine("So, you aren't boy");
        break;
    default:
        Console.WriteLine("You entered a wrong character and i will ask next question ");
        Console.Beep();
        break;
}
Console.WriteLine("Do you have friends ? enter after (y/n) ");
string input3 = Convert.ToString(Console.ReadLine());
switch (input3)
{
    case "y":
    case "Y":
        Console.WriteLine("i'm happy for that you have friends...");
        break;
    case "n":
    case "N":
        Console.WriteLine("you should find some friends. it will help you");
        break;
    default:
        Console.WriteLine("You entered a wrong character and i will ask next question ");
        Console.Beep();
        break;
}
Console.WriteLine("Do you have a partner? enter after (y/n) ");
string input4 = Convert.ToString(Console.ReadLine());
switch (input4)
{
    case "y":
    case "Y":
        Console.WriteLine("Cool (:");
        break;
    case "n":
    case "N":
        Console.WriteLine("You don't have to explain the reason of that to me... let's go to next question");
        break;
    default:
        Console.WriteLine("You entered a wrong character and i will ask next question ");
        Console.Beep();
        break;
}
Console.WriteLine("Is your height over than 180cm ? enter after (y/n) ");
string input5 = Convert.ToString(Console.ReadLine());
switch (input5)
{
    case "y":
    case "Y":
        Console.WriteLine("You are tall my friend . you should know your stuff");
        break;
    case "n":
    case "N":
        Console.WriteLine("hmmm... OK");
        break;
    default:
        Console.WriteLine("You entered a wrong character and i will ask next question ");
        Console.Beep();
        break;
}
Console.WriteLine("Do you enjoy your life ? enter after (y/n) ");
string input6 = Convert.ToString(Console.ReadLine());
switch (input6)
{
    case "y":
    case "Y":
        Console.WriteLine("Very good .");
        break;
    case "n":
    case "N":
        Console.WriteLine("I know you dude... but you should enjoy it much more");
        break;
    default:
        Console.WriteLine("You entered a wrong character and i will ask next question ");
        Console.Beep();
        break;
}
Console.WriteLine("Are your eyes black ? enter after (y/n) ");
string input7 = Convert.ToString(Console.ReadLine());
switch (input7)
{
    case "y":
    case "Y":
        Console.WriteLine("Me too (:  i realy like black eyes .");
        break;
    case "n":
    case "N":
        Console.WriteLine("All colors are beautiful ");
        break;
    default:
        Console.WriteLine("You entered a wrong character and i will ask next question ");
        Console.Beep();
        break;
}
Console.WriteLine("Are you higher than 18 years old ? enter after (y/n) ");
string input8 = Convert.ToString(Console.ReadLine());
switch (input8)
{
    case "y":
    case "Y":
        Console.WriteLine("Cool you can do your ideas by yourself .");
        break;
    case "n":
    case "N":
        Console.WriteLine("No problem . you can also use this programm untill the last question . ");
        break;
    default:
        Console.WriteLine("You entered a wrong character and i will ask next question ");
        Console.Beep();
        break;
}


Console.WriteLine("Are you ready for the last question ? enter after (y/n) ");
string input9 = Convert.ToString(Console.ReadLine());



do {
    switch (input9)
    {
        case "y":
        case "Y":
            Console.WriteLine("Ok , answer it honsetly .");
            break;
        case "n":
        case "N":
            Console.WriteLine("No problem , Goodbye dude (: . ");
            return;
        default:
            break;
    }
    break;
} while (input9 != "n" && input9 != "N");




Console.WriteLine("Did you like our program ? enter after (y/n) ");
string input10 = Convert.ToString(Console.ReadLine());
switch (input10)
{
    case "y":
    case "Y":
        Console.WriteLine("Thank you so much for your opinion .");
        Console.WriteLine("Goodbye");
        break;
    case "n":
    case "N":
        Console.WriteLine("Oh , we will try to be better next time . ");
        Console.WriteLine("Goodbye");
        break;
    default:
        Console.WriteLine("You entered a wrong character and i will ask next question ");
        Console.Beep();
        break;
}




///////////////////..............................Methods............................///////////////////////////
void LockYNquestion()
{
    do
    {
        input1 = Console.ReadKey(true).KeyChar.ToString();
        Console.Beep();
    } while (input1.ToLower() != "y" && input1.ToLower() != "n");
}