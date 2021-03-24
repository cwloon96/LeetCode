namespace LeetCode.Q1601_1700
{
    public class Q1629
    {
        public char SlowestKey(int[] releaseTimes, string keysPressed)
        {
            char result = keysPressed[0];
            int max = releaseTimes[0];

            for (int i = 1; i < releaseTimes.Length; i++)
            {
                int duration = releaseTimes[i] - releaseTimes[i - 1];

                if (duration > max)
                {
                    max = duration;
                    result = keysPressed[i];
                }
                else if (max == duration)
                    result = result > keysPressed[i] ? result : keysPressed[i];
            }

            return result;
        }
    }
}