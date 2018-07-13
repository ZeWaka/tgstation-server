﻿using Byond.TopicSender;
using Microsoft.Extensions.Logging;
using System;
using Tgstation.Server.Api.Models.Internal;
using Tgstation.Server.Host.Components.Chat;
using Tgstation.Server.Host.Core;

namespace Tgstation.Server.Host.Components.Watchdog
{
	/// <inheritdoc />
	sealed class WatchdogFactory : IWatchdogFactory
	{
		/// <summary>
		/// The <see cref="IChat"/> for the <see cref="WatchdogFactory"/>
		/// </summary>
		readonly IChat chat;

		/// <summary>
		/// The <see cref="ISessionControllerFactory"/> for the <see cref="WatchdogFactory"/>
		/// </summary>
		readonly ISessionControllerFactory sessionManagerFactory;

		/// <summary>
		/// The <see cref="IServerUpdater"/> for the <see cref="WatchdogFactory"/>
		/// </summary>
		readonly IServerUpdater serverUpdater;

		/// <summary>
		/// The <see cref="ILoggerFactory"/> for the <see cref="WatchdogFactory"/>
		/// </summary>
		readonly ILoggerFactory loggerFactory;

		/// <summary>
		/// The <see cref="IReattachInfoHandler"/> for the <see cref="WatchdogFactory"/>
		/// </summary>
		readonly IReattachInfoHandler reattachInfoHandler;

		/// <summary>
		/// The <see cref="IDatabaseContextFactory"/> for the <see cref="WatchdogFactory"/>
		/// </summary>
		readonly IDatabaseContextFactory databaseContextFactory;

		/// <summary>
		/// The <see cref="IByondTopicSender"/> for the <see cref="WatchdogFactory"/>
		/// </summary>
		readonly IByondTopicSender byondTopicSender;

		/// <summary>
		/// The <see cref="Models.Instance"/> for the <see cref="WatchdogFactory"/>
		/// </summary>
		readonly Models.Instance instance;
	

		/// <summary>
		/// Construct a <see cref="WatchdogFactory"/>
		/// </summary>
		/// <param name="chat">The value of <see cref="chat"/></param>
		/// <param name="sessionManagerFactory">The value of <see cref="sessionManagerFactory"/></param>
		/// <param name="serverUpdater">The value of <see cref="serverUpdater"/></param>
		/// <param name="loggerFactory">The value of <see cref="loggerFactory"/></param>
		/// <param name="reattachInfoHandler">The value of <see cref="reattachInfoHandler"/></param>
		/// <param name="databaseContextFactory">The value of <see cref="databaseContextFactory"/></param>
		/// <param name="byondTopicSender">The value of <see cref="byondTopicSender"/></param>
		/// <param name="instance">The value of <see cref="instance"/></param>
		public WatchdogFactory(IChat chat, ISessionControllerFactory sessionManagerFactory, IServerUpdater serverUpdater, ILoggerFactory loggerFactory, IReattachInfoHandler reattachInfoHandler, IDatabaseContextFactory databaseContextFactory, IByondTopicSender byondTopicSender, Models.Instance instance)
		{
			this.chat = chat ?? throw new ArgumentNullException(nameof(chat));
			this.sessionManagerFactory = sessionManagerFactory ?? throw new ArgumentNullException(nameof(sessionManagerFactory));
			this.serverUpdater = serverUpdater ?? throw new ArgumentNullException(nameof(serverUpdater));
			this.loggerFactory = loggerFactory ?? throw new ArgumentNullException(nameof(loggerFactory));
			this.reattachInfoHandler = reattachInfoHandler ?? throw new ArgumentNullException(nameof(reattachInfoHandler));
			this.databaseContextFactory = databaseContextFactory ?? throw new ArgumentNullException(nameof(databaseContextFactory));
			this.byondTopicSender = byondTopicSender ?? throw new ArgumentNullException(nameof(byondTopicSender));
			this.instance = instance ?? throw new ArgumentNullException(nameof(instance));
		}

		/// <inheritdoc />
		public IWatchdog CreateWatchdog(IDmbFactory dmbFactory, DreamDaemonSettings settings) => new Watchdog(chat, sessionManagerFactory, dmbFactory, serverUpdater, loggerFactory.CreateLogger<Watchdog>(), reattachInfoHandler, databaseContextFactory, byondTopicSender, settings, instance, settings.AutoStart.Value);
	}
}
