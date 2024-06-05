using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class QueueProcessor
    {
        public static int CalculateQueueTime(int[] clients, int n)
        {
            if (clients.Length <= n)
                return clients.Max();

            int[] queues = new int[n];
            int totalTime = 0;

            foreach (int time in clients)
            {
                int minQueue = queues.Min();
                int minIndex = Array.IndexOf(queues, minQueue);
                queues[minIndex] += time;
                totalTime = Math.Max(totalTime, queues[minIndex]);
            }

            return totalTime;
        }

        public static string Capitalize(string S)
        {
            string c = "";
            for (int i = 0; i < S.Length; i++)
            {
                if (char.IsUpper(S[i]) && i != 0 && char.IsLetter(S[i - 1]))
                {
                    c += char.ToLower(S[i]);
                }
                else if (char.IsLower(S[i]) && (i == 0 || !char.IsLetter(S[i - 1])))
                {
                    c += char.ToUpper(S[i]);
                }
                else
                {
                    c += S[i];
                }
            }
            return c;
        }
    }
}
