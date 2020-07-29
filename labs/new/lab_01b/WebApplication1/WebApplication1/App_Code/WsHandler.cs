using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.WebSockets;

namespace WebApplication1.App_Code
{
    public class WsHandler : IHttpHandler
    {
        WebSocket socket;

        public bool IsReusable => false;

        public void ProcessRequest(HttpContext context)
        {
            if (context.IsWebSocketRequest)
            {
                context.AcceptWebSocketRequest(WebSocketRequest);
            }
        }
         
        private async Task WebSocketRequest(AspNetWebSocketContext context)
        {
            socket = context.WebSocket;
            string s = await Recieve();
            //await Send("");
            DateTime dateTime;
            while (socket.State == WebSocketState.Open)
            {
                Thread.Sleep(2000);
                dateTime = DateTime.Now;
                await Send($"[{dateTime.ToLongTimeString()}]");
            }
        }

        private async Task<string> Recieve()
        {
            string rc = null;
            var buffer = new ArraySegment<byte>(new Byte[1024]);
            var result = await socket.ReceiveAsync(buffer, CancellationToken.None);
            rc = System.Text.Encoding.UTF8.GetString(buffer.Array, 0, result.Count);
            return rc;
        }

        private async Task Send(string s)
        {
            var sendBuffer = new ArraySegment<byte>(System.Text.Encoding.UTF8.GetBytes("Res: " + s + "\n"));
            await socket.SendAsync(sendBuffer, WebSocketMessageType.Text, true, CancellationToken.None);
        }
    }
}