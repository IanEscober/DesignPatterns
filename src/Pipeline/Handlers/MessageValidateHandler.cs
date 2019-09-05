namespace Pipeline.Handlers
{
    using System;
    using Pipeline.Pipelines;

    public class MessageValidateHandler : MessageParserPipeline
    {
        public override void Handle(object message)
        {
            var flag = false;

            if (message.GetType() == typeof(ValueTuple<Type, string>))
            {
                var result = (ValueTuple<Type, string>)message;

                if (result.Item1 == typeof(int))
                {
                    if (int.Parse(result.Item2) <= 80)
                    {
                        flag = true;
                        Console.WriteLine("Valid Ultrasonic Reading");
                    }
                    else
                    {
                        flag = false;
                        Console.WriteLine("Invalid Ultrasonic Reading");
                    }
                }

                if (result.Item1 == typeof(double))
                {
                    if (double.Parse(result.Item2) == 121.12)
                    {
                        flag = true;
                        Console.WriteLine("Valid GPS Reading");
                    }
                    else
                    {
                        flag = false;
                        Console.WriteLine("Invalid GPS Reading");
                    }
                }
            }

            this.Next(flag);
        }
    }
}
