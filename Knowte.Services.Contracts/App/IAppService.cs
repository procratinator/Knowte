﻿namespace Knowte.Services.Contracts.App
{
    public delegate void IsBusyChangedEventHandler(object sender, IsBusyChangedEventArgs e);

    public interface IAppService
    {
        event IsBusyChangedEventHandler IsBusyChanged;

        bool IsBusy { get; set; }
    }
}
