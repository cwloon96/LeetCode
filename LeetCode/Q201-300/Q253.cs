using System;

namespace LeetCode.Q201_300
{
    /// <summary>
    /// https://medium.com/nerd-for-tech/meeting-room-amazon-interview-problem-72609de8d776
    /// </summary>
    public class Q253
    {
        public int MinMeetingRoom(int[][] intervals)
        {
            var start = new int[intervals.Length];

            for (int i = 0; i < intervals.Length; i++)
                start[i] = intervals[i][0];

            var end = new int[intervals.Length];

            for(int i = 0; i < intervals.Length; i++)
                end[i] = intervals[i][1];

            Array.Sort(start);
            Array.Sort(end);

            int rooms = 0, curr = 0;
            int startIndex = 0, endIndex = 0;

            while (startIndex < start.Length)
            {
                if (start[startIndex] < end[endIndex])
                {
                    startIndex++;
                    curr++;
                }    
                else
                {
                    endIndex++;
                    curr--;
                }

                rooms = Math.Max(curr, rooms);
            }

            return rooms;
        }
    }
}