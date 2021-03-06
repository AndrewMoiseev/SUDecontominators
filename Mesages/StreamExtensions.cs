﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Mesages
{
    public static class StreamExtensions
    {
        public static async Task<byte[]> ReadRawMessage(this Stream stream)
        {
            var bytesRead = 0;
            var headerRead = 0;
//            var buffer = new byte[4];
            var buffer = new byte[3];

            while (headerRead < 3 && (bytesRead = await stream.ReadAsync(buffer, headerRead, 3 - headerRead).ConfigureAwait(false)) > 0)
            {
                headerRead += bytesRead;
            }

            if (headerRead < 3) return null; // We failed to read the header.

//            var bytesRemaining = BitConverter.ToInt32(buffer, 2) + 2;// +2 CRC
            var bytesRemaining = Convert.ToInt32(buffer[2]) + 2;// +2 CRC

            var data = new byte[bytesRemaining];

            while (bytesRemaining > 0 && (bytesRead = await stream.ReadAsync(data, data.Length - bytesRemaining, bytesRemaining)) != 0)
            {
                bytesRemaining -= bytesRead;

            }

            if (bytesRemaining != 0) return null;

            return data;
        }

        public static Task SendRawMessage(this Stream stream, byte[] data)
        {
//            return Task.WhenAll(stream.WriteAsync(BitConverter.GetBytes(data.Length), 0, 4), stream.WriteAsync(data, 0, data.Length));
            return Task.WhenAll(stream.WriteAsync(data, 0, data.Length));
        }

        public static Task SendStringMessage(this Stream stream, MessageId messageId, string text)
        {
            var messageByteCount = Encoding.UTF8.GetByteCount(text);
            var data = new byte[messageByteCount + 1];

            data[0] = (byte)messageId;
            Encoding.UTF8.GetBytes(text, 0, text.Length, data, 1);

            return stream.SendRawMessage(data);
        }
    }
}
