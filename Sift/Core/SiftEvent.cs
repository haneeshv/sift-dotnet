﻿namespace Sift
{
    public class SiftEvent : SiftEntity
    {
        public void AddApiKey(string apiKey)
        {
            AddField("$api_key", apiKey);
        }

        public void AddTime(long time)
        {
            AddField("$time", time);
        }
    }
}