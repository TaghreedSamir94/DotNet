using Assignment_OOP_03.Q1;
using Assignment_OOP_03.Q2;
using Assignment_OOP_03.Q3;

namespace Assignment_OOP_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part-1
            #region Q1
            //What is the primary purpose of an interface in C#?
            //b) To define a blueprint for a class

            #endregion

            #region Q2
            // Which of the following is NOT a valid access modifier for interface members in C#?
            // a) private
            #endregion

            #region Q3
            // Can an interface contain fields in C#?
            //c) Only if they are static
            #endregion

            #region Q4
            // In C#, can an interface inherit from another interface?
            // b) Yes, interfaces can inherit from multiple interfaces
            #endregion

            #region Q5
            // Which keyword is used to implement an interface in a class in C#?
            // d) implements
            #endregion

            #region Q6
            //Can an interface contain static methods in C#?
            // a) Yes
            #endregion

            #region Q7
            //In C#, can an interface have explicit access modifiers for its members?
            // b) No, all members are implicitly public
            #endregion

            #region Q8
            //What is the purpose of an explicit interface implementation in C#?
            // a) To hide the interface members from outside access

            #endregion

            #region Q9
            //In C#, can an interface have a constructor?
            // b) No, interfaces cannot have constructors
            #endregion

            #region Q10
            // How can a C# class implement multiple interfaces?
            // c) By separating interface names with commas
            #endregion

            //=============Part-2=====================
            #region Q1
            /*Define an interface named IShape with a property Area and a method DisplayShapeInfo.
             * Create two interfaces, ICircle and IRectangle, that inherit from IShape. 
             * Implement these interfaces in classes Circle and Rectangle. 
             * Test your implementation by creating instances of both classes and displaying their shape information.*/

            //Circle circle = new Circle(5.5);
            //Rectangle rectangle = new Rectangle(20, 15);

            //circle.DisplayShapeInfo();
            //rectangle.DisplayShapeInfo();

            #endregion


            #region Q2
            /*In this example, we start by defining the IAuthenticationService interface with two methods: 
             * AuthenticateUser and AuthorizeUser. The BasicAuthenticationService class implements this interface 
             * and provides the specific implementation for these methods.
             In the BasicAuthenticationService class, the AuthenticateUser method compares the provided username
            and password with the stored credentials. It returns true if the user is authenticated and false otherwise. 
            The AuthorizeUser method checks if the user with the given username has the specified role. 
            It returns true if the user is authorized and false otherwise.
            In the Main method, we create an instance of the BasicAuthenticationService class and assign it to the authService 
            variable of type IAuthenticationService. We then call the AuthenticateUser and AuthorizeUser methods using this interface reference.
            This implementation allows you to switch the authentication service implementation easily by creating a new class that implements 
            the IAuthenticationService interface and providing the desired logic for authentication and authorization.
            */


            //BasicAuthenticationService Bs = new BasicAuthenticationService() { UserName = "Taghreed", Password = "Tagh@1234", Role = "Admin" };

            //IAuthenticationService authService = Bs;

            //bool IsAuthen = authService.AuthenticateUser("Taghreed", "Tagh@1234");
            //bool IsAuthen2 = authService.AuthenticateUser("Taghreedsamir", "Tagh@1234");
            //bool IsAuthen3 = authService.AuthenticateUser("Taghreed", "Tagh@1234hjklo");

            //Console.WriteLine($"Authentication successful 01: {IsAuthen}");
            //Console.WriteLine($"Authentication successful 02: {IsAuthen2}");
            //Console.WriteLine($"Authentication successful 03: {IsAuthen3}");

            //Console.WriteLine("-----------------");

            //bool IsAuthrize = authService.AuthorizeUser("Taghreed", "User");
            //bool IsAuthrize2 = authService.AuthorizeUser("Taghreed", "Admin");

            //Console.WriteLine($"Authorization successful 01: {IsAuthrize}");
            //Console.WriteLine($"Authorization successful 02: {IsAuthrize2}");



            #endregion

            #region Q3
            /*we define the INotificationService interface with a method SendNotification that takes a recipient and a message as parameters.
            We then create three classes: EmailNotificationService, SmsNotificationService, and PushNotificationService, which implement the INotificationService interface.
            In each implementation, we provide the logic to send notifications through the respective communication channel:
            The EmailNotificationService class simulates sending an email by outputting a message to the console.
            The SmsNotificationService class simulates sending an SMS by outputting a message to the console.
            The PushNotificationService class simulates sending a push notification by outputting a message to the console.
            In the Main method, we create instances of each notification service class and call the SendNotification method with sample recipient and message values.
            This implementation allows you to easily switch between different notification channels by creating new classes that implement the INotificationService interface and provide the specific logic for each channel.
*/

            //SmsNotificationService sms = new SmsNotificationService();
            //PushNotificationService push = new PushNotificationService();
            //EmailNotificationService email = new EmailNotificationService();

            //sms.SendNotification("Ahmed", "Congratiolations");
            //email.SendNotification("Taghreed", "Congrats, Accepted");
            //push.SendNotification("Yassin", "Welldone");
            #endregion

        }
    }
}
