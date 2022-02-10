using System;
using UserRegistration_LambdaExp;

            Validation validate = new Validation();
            //Defining variables
            string firstName, lastName, emailID, phoneNumber, password;
            //Iterating using while loop to take First name of the user
            while (true)
            {
                Console.WriteLine("Enter your First Name : ");
                firstName = Console.ReadLine();
                //Calling the method Validation from the Validation Class
                //passing the parameters into the method
                //passing the regular expression to ensure that the first letter of the name must be Capital
                bool valid = Validation.validate(firstName, "^[A-Z][a-z]{2,}$");
                //If the boolean returns false then displaying Invalid input otherwise storing the name into the variable firstName
                if (!valid)
                {
                    Console.WriteLine("Invalid Input");
                }
                else
                {
                    break;
                }
            }
            //Iterating using while loop to take Last name of the user
            while (true)
            {
                Console.WriteLine("Enter your Last Name : ");
                lastName = Console.ReadLine();
                //Calling the method Validation from the Validation Class
                //passing the parameters into the method
                //passing the regular expression to ensure that the first letter of the name must be Capital
                bool valid = Validation.validate(lastName, "^[A-Z][a-z]{2,}$");
                //If the boolean returns false then displaying Invalid input otherwise storing the name into the variable lastName
                if (!valid)
                {
                    Console.WriteLine("Invalid Input");
                }
                else
                {
                    break;
                }
            }
            //Iterating using while loop to take Email Id  of the user
            while (true)
            {
                Console.WriteLine("Enter your emailId : ");
                emailID = Console.ReadLine();
                //Calling the method Validation from the Validation Class
                //passing the parameters into the method
                //passing the regular expression to ensure that the email id must be in the correct form
                bool valid = Validation.validate(emailID, @"^[a-zA-Z0-9]+([.+_-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+([.][a-zA-Z]{3})+([.][a-zA-Z]{2})?$");
                //If the boolean returns false then displaying Invalid input otherwise storing the Email Id into the variable emailID
                if (!valid)
                {
                    Console.WriteLine("Invalid Input");
                }
                else
                {
                    break;
                }
            }
            //Iterating using while loop to take Mobile number  of the user
            while (true)
            {
                Console.WriteLine("Enter your mobile number : ");
                phoneNumber = Console.ReadLine();
                //Calling the method Validation from the Validation Class
                //passing the parameters into the method
                //passing the regular expression to ensure that the mobile number must be in the correct form
                bool valid = Validation.validate(phoneNumber, @"^[0-9]{2}[ ][0-9]{10}$");
                //If the boolean returns false then displaying Invalid input otherwise storing the mobile number into the variable phoneNumber
                if (!valid)
                {
                    Console.WriteLine("Invalid Input");
                }
                else
                {
                    break;
                }
            }
            //Iterating using while loop to take Password of the user
            while (true)
            {
                Console.WriteLine("Enter a password : ");
                password = Console.ReadLine();
                //Calling the method Validation from the Validation Class
                //passing the parameters into the method
                //passing the regular expression to ensure that the password must be in the correct form with atleast 8 characters and one special character
                bool valid = Validation.validate(password, @"(^(?=.*[A-Z])(?=.*[0-9])(?=.*[@#+-\._])[A-Za-z0-9@#-+\._]{8,}$)");
                if (!valid)
                {
                    Console.WriteLine("Invalid Input");
                }
                else
                {
                    break;
                }
            }
            //Displaying all the details entered by the user
            Console.WriteLine("Registration Successful.");
            Console.WriteLine("Name :" + firstName + " " + lastName);
            Console.WriteLine("Email ID : " + emailID);
            Console.WriteLine("Contact Number : " + phoneNumber);
