using ClimaTempo.Models;
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
        [ObservableProperty]
        private string estado;
        [ObservableProperty]
        private string condicao;
        [ObservableProperty]
        private DateOnly data;
        [ObservableProperty]
        private double max;
        [ObservableProperty]
        private double min;
        [ObservableProperty]
        private double indiceuv;
        [ObservableProperty]
        private List<Clima> proximosDias;

        private Previsao previsao;
        private Previsao proxprevisao;

        public ICommand BuscarPrevicaoCommnd { get; }

        public PrevisaoViewModel()
        {
            BuscarPrevicaoCommnd = new Command(BuscarPrevisao);
        }

        public async void BuscarPrevisao()
        {
            previsao = await new PrevisaoService().GetPrevisaoById(244);
            Cidade = previsao.Cidade;
            Estado = previsao.Estado;
            Max = previsao.Clima[0].Max;
            Min = previsao.Clima[0].Min;
            Data = previsao.Clima[0].Data;
            Condicao = previsao.Clima[0].Condicao;
            Indiceuv = previsao.Clima[0].Indice_uv;


            proxprevisao = await new PrevisaoService().GetPrevisaoForXDaysById(244, 3);
            ProximosDias = proxprevisao.Clima;
            Max = previsao.Clima[1].Max;
            Min = previsao.Clima[1].Min;
            Data = previsao.Clima[1].Data;
            Condicao = previsao.Clima[1].Condicao;
            Indiceuv = previsao.Clima[1].Indice_uv;
        }


    }
}
