using System;

class OTPGenerator
{
    static void Main()
    {
        int[] otpNumbers = new int[10];
        bool isUnique = GenerateOTPs(otpNumbers);

        if (isUnique)
            Console.WriteLine("All OTP numbers are unique.");
        else
            Console.WriteLine("Some OTP numbers are not unique.");
    }

    static bool GenerateOTPs(int[] otpNumbers)
    {
        Random random = new Random();
        for (int i = 0; i < otpNumbers.Length; i++)
        {
            otpNumbers[i] = GenerateOTP(random);
        }
        return AreOTPsUnique(otpNumbers);
    }

    static int GenerateOTP(Random random)
    {
        return random.Next(100000, 1000000);
    }

    static bool AreOTPsUnique(int[] otpNumbers)
    {
        for (int i = 0; i < otpNumbers.Length; i++)
        {
            for (int j = i + 1; j < otpNumbers.Length; j++)
            {
                if (otpNumbers[i] == otpNumbers[j])
                    return false;
            }
        }
        return true;
    }
}
