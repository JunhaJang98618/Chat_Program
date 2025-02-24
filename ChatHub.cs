using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace Chat_Program
{
    public class ChatHub
    {
        public static ChatHub Parse(string json)
        {
            var chatHub = JsonSerializer.Deserialize<ChatHub>(json);

            // null 체크
            if (chatHub == null)
            {
                throw new InvalidOperationException("Deserialization failed: chatHub is null.");
            }

            return chatHub;
        }


        public string user_id { get; set; } = string.Empty;
        public string message { get; set; } = string.Empty;
        public string ToJsonString
        {
            get
            {
                return JsonSerializer.Serialize(new { user_id, message });
            }
        }
    }
}
