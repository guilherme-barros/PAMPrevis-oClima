﻿using ClimaTempo.Models;
using ClimaTempo.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClimaTempo.ViewModels
{
    public partial class PrevisaoViewModel : ObservableObject
    {
        [ObservableProperty]
        private string cidade;
        private Previsao previsao;

        public ICommand BuscarPrevicaoCommnd { get; }

        public PrevisaoViewModel()
        {
            BuscarPrevicaoCommnd = new Command(BuscarPrevisao);
        }

        public async void BuscarPrevisao()
        {
            previsao = await new PrevisaoService().GetPrevisaoById(244);
            Cidade = previsao.Cidade;
        }

    }
}
