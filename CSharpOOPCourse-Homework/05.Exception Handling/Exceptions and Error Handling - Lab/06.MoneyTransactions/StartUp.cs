string[] input = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);

Dictionary<int, decimal> bankAccounts = new();
foreach (string bankAccount in input)
{
    string[] bankAccountArguments = bankAccount.Split('-', StringSplitOptions.RemoveEmptyEntries);
    int bankAccountNumber = int.Parse(bankAccountArguments[0]);
    decimal bankAccountBalance = decimal.Parse(bankAccountArguments[1]);

    bankAccounts.Add(bankAccountNumber, bankAccountBalance);
}

string command;
while ((command = Console.ReadLine()) != "End")
{
    string[] commandArguments = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    int currentAccountNumber = int.Parse(commandArguments[1]);
    decimal sum = decimal.Parse(commandArguments[2]);

    try
    {
        switch (commandArguments[0])
        {
            case "Deposit":
                bankAccounts[currentAccountNumber] += sum;
                break;
            case "Withdraw":
                if (sum > bankAccounts[currentAccountNumber])
                {
                    throw new ArgumentOutOfRangeException("Insufficient balance!");
                }

                bankAccounts[currentAccountNumber] -= sum;
                break;
            default:
                throw new ArgumentException("Invalid command!");
        }

        Console.WriteLine($"Account {currentAccountNumber} has new balance: {bankAccounts[currentAccountNumber]}");
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine(ex.ParamName);
    }
    catch (KeyNotFoundException)
    {
        Console.WriteLine("Invalid account!");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("Enter another command");
    }
}