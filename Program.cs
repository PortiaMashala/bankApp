// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;

//Console.WriteLine("Hello, World!");


Console.WriteLine("*****Register with your name and password*****");
Console.WriteLine("Register your login Username");
string regUser = Console.ReadLine();

Console.WriteLine("Register your login Password");
string regPass = Console.ReadLine();

if (regPass.Length < 4 || regPass.Length > 8)
{
    Console.WriteLine("Minimum password is between 4 and 8 characters ");
    Console.WriteLine("Try again");
    Console.WriteLine("Register your password");
    regPass = Console.ReadLine();
}

Console.WriteLine("\n****Login Username****\n");
Console.WriteLine("Enter your login username");
string usernam = Console.ReadLine();

Console.WriteLine("****Login Password****\n");
Console.WriteLine("Enter your login Password");
string pass = Console.ReadLine();
Console.WriteLine(pass);
//call CheckCredentials method

CheckCredentials(usernam, pass, regPass, regUser);

Optionss();


void CheckCredentials(string loginUsrnme, string loginPassword, string registerloginPassword, string registerLoginPassword)


{

    if (loginUsrnme == registerLoginPassword)
    {

        if (loginPassword == registerloginPassword)
        {
            Console.WriteLine("You are logged in");

            Console.WriteLine("****Options****");
            Optionss();


        }
        else if (loginUsrnme.Length < 10 && loginPassword.Length > 10)
        {
            Console.WriteLine("login Username or login Password is not correct");
        }
    }
    else
    {
        Console.WriteLine("login Username or login Password is not correct");
    }

}

//ChooseOptioning Option method

void ChooseOption(StringBuilder option)
{
    int balance = 2000;
    for (int i = 0; i < option.Length; i++)
    {

        string money;
        Console.WriteLine("*****Please enter your option 1,2,3 or 4 to exit****");
        string choice = Console.ReadLine();

        //string num = s.Substring(0, 1);
        if (choice == "1")
        {
            Console.WriteLine("Your remaining balance is {0} ", balance);
            Console.WriteLine(option);
        }
        else if (choice == "2")
        {
            Console.WriteLine("Enter money to send\n");
            money = Console.ReadLine();
            Console.WriteLine("Enter account number\n");

            if (Console.ReadLine().Length > 10)
            {
                Console.WriteLine("You have entered a long account number");
            }
            else
            {
                if (int.Parse(money) > balance)
                {

                    Console.WriteLine("Insufficient  funds:\n Your balance is: {0}", balance);
                    Console.WriteLine("Enter the correct money \n");
                    money = Console.ReadLine();
                    while (int.Parse(money) < balance)
                    {
                        balance = balance - int.Parse(money);
                        Console.WriteLine("Your balance is: " + balance);
                        break;
                    }

                }
                else
                {
                    balance = balance - int.Parse(money);
                    Console.WriteLine("Your balance is: {0} ", balance);

                }
                Console.WriteLine(option);
            }


        }
        else if (choice == "3")
        {

            Console.WriteLine("Enter money you want to withdraw");
            money = Console.ReadLine();

            if (int.Parse(money) > balance)
            {
                Console.WriteLine("Insufficient  funds:\n Your balance is: {0}", balance);
                Console.WriteLine("Please enter the correct money");
                money = Console.ReadLine();
                while (int.Parse(money) < balance)
                {
                    balance = balance - int.Parse(money);

                    Console.WriteLine("Your remaining balance is: {0}", balance);
                    break;
                }
            }
            else
            {
                balance = balance - int.Parse(money);
                Console.WriteLine("Your remaining balance is: {0}", balance);

            }
            Console.WriteLine(option);
        }
        else if (choice == "4")
        {
            Console.WriteLine("Press enter to exit!");
            Console.ReadKey();
            break;

        }
    }
}
//Options
void Optionss()
{
    StringBuilder option = new StringBuilder();


    option.Append("1. Check balance\n");
    option.Append("2. Send Money\n");
    option.Append("3. Withdraw\n");
    option.Append("4. Exit/Cancel\n");
    Console.WriteLine(option);


    //Call ChooseOption

    ChooseOption(option);
}

