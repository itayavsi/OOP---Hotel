using System;
using System.Runtime.Serialization;

namespace GamaHotel.Exceptions
{
    [Serializable]
    internal class UnavailableRoomException : Exception
    {
        public UnavailableRoomException()
        {
        }

        public UnavailableRoomException(string message) : base(message)
        {
        }

        public UnavailableRoomException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnavailableRoomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}