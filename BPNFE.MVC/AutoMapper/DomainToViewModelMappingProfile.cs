using AutoMapper;
using BPNFE.Dominio.Entidades;
using BPNFE.MVC.ViewModels;

namespace BPNFE.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<FaturamentoDiaViewModel, FaturamentoDia>();
            Mapper.CreateMap<FornecedorViewModel, Fornecedor>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
            Mapper.CreateMap<UsuarioViewModel, Usuario>();
        }
    }
}