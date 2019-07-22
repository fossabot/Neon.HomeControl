﻿using System;
using System.Threading.Tasks;
using Neon.HomeControl.Api.Core.Data.Mqtt;
using Neon.HomeControl.Api.Core.Interfaces.Messages;

namespace Neon.HomeControl.Api.Core.Interfaces.Services
{
	public interface IMqttService : IService
	{
		IObservable<MqttMessage> OnMqttMessage { get; set; }
		Task<bool> SubscribeTopic(string topic);

		Task<bool> SendMessage(string topic, object message);
	}
}