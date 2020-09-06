﻿using System;
using DIYHIIT.Contracts.Services.Data;
using DIYHIIT.Contracts.Services.General;
using DIYHIIT.DependencyInjection;
using DIYHIIT.ViewModels;
using Xamarin.Forms;

namespace DIYHIIT.Views
{
    public partial class AddExerciseView : ContentPage
    {
        AddExerciseViewModel viewModel;

        public AddExerciseView()
        {
            InitializeComponent();

            var exerciseDataService = AppContainer.Resolve<IExerciseDataService>();
            var dialogService = AppContainer.Resolve<IDialogService>();

            BindingContext = viewModel = new AddExerciseViewModel(0, Navigation, dialogService, exerciseDataService);
        }
    }
}
