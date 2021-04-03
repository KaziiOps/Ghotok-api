﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Ghotok.Data.UnitOfWork;
using MediatR;

namespace GhotokApi.MediatR.NotificationHandlers
{
    public class ComitDatabaseNotificationHandler : INotificationHandler<ComitDatabaseNotification>
    {
        private readonly IUnitOfWork _unitOfWork;

        public ComitDatabaseNotificationHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Handle(ComitDatabaseNotification request, CancellationToken cancellationToken)
        {
            
                try
                {
                    _unitOfWork.Commit();
                }
                catch (Exception e)
                {
                    throw e;
                }
        }
    }

    public class ComitDatabaseNotification : INotification
    {
    }
}
