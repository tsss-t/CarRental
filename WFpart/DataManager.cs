using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Channels;
using System.ServiceModel;

namespace WFpart
{
    public static class DataManager
    {
        #region 私有变量
        static string uri = "localhost:12345";
        static IServer channel;
        #endregion

        #region 属性
        public static string URI
        {
            get { return uri; }
            set
            {
                uri = value;
                channel = null;
            }
        }

        public static IServer Channel
        {
            get
            {
                if (channel == null)
                {
                    ICollection<BindingElement> bindingElements = new List<BindingElement>();
                    TcpTransportBindingElement tcpTransport = new TcpTransportBindingElement() { TransferMode = TransferMode.Streamed, MaxReceivedMessageSize = 2147483647 }; ;
                    GZipMessageEncodingBindingElement compBindingElement = new GZipMessageEncodingBindingElement(new BinaryMessageEncodingBindingElement());
                    bindingElements.Add(compBindingElement);
                    bindingElements.Add(tcpTransport);
                    CustomBinding binding = new CustomBinding(bindingElements);
                    binding.Name = "tcpTransport";
                    EndpointAddress address = new EndpointAddress(new Uri("net.tcp://" + uri + "/Server/"));
                    ChannelFactory<IServer> channelFactory = new ChannelFactory<IServer>(binding, address);
                    channelFactory.Endpoint.Behaviors.Add(new ContextHeaderBehavior());
                    channel = channelFactory.CreateChannel();
                }
                return channel;
            }
        }
        #endregion
    }

}
