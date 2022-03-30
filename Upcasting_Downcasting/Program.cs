using Upcasting_Downcasting.Entities;



Account acc1 = new Account(1001, "Luiz Fernando", 500.00);
Account acc2 = new SavingsAccount(1002, "Thais", 500.0, 0.01);

acc1.Withdraw(10.0);
acc2.Withdraw(20.0);

Console.WriteLine(acc1.Balance);
Console.WriteLine(acc2.Balance);



//Account acc = new Account(2696, "Luiz Fernando", 100.0);
//BusinessAccount bacc = new BusinessAccount(1002, "Thais Ribeiro", 0.0, 1000.0); //AG, Holder, Saldo, Limite

////UPCASTING - Conversão da Subclasse para Superclasse

//Account acc1 = bacc;
//Account acc2 = new BusinessAccount(1003, "Tiago", 0.0, 200.00);
//Account acc3 = new SavingsAccount(1004, "Manu", 0.0, 0.05);

////DOWNCASTING - Conversão da Superclasse para Subclasse

//BusinessAccount acc4 = (BusinessAccount)acc2;
//acc4.Loan(3000.00);


//if (acc3 is BusinessAccount)
//{
//    // BusinessAccount acc5 = (BusinessAccount)acc3;
//    BusinessAccount acc5 = acc3 as BusinessAccount; //Outra forma de fazer o Casting - operador AS
//    acc5.Loan(250.0);
//    Console.WriteLine("Loan approved!");
//}

//if (acc3 is SavingsAccount)
//{
//    //SavingsAccout acc5 = acc3 as SavingsAccount;
//    SavingsAccount acc5 = (SavingsAccount)acc3;
//    acc5.UpdateBalance();
//    Console.WriteLine("Update!");
//}