using AutoMapper;
using BPNFE.Dominio.Entidades;
using BPNFE.MVC.ViewModels;

namespace BPNFE.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Produto, ProdutoViewModel>();
            Mapper.CreateMap<Usuario, UsuarioViewModel>();
        }
    }
}