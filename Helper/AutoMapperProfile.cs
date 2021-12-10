using AutoMapper;

namespace MVCDemoS.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // CreateMap<Message, MessageDto>()
            //.ForMember(destinationMember => destinationMember.SenderPhotoUrl, opt => opt.MapFrom(
            //       src => src.Sender.Photos.FirstOrDefault(x => x.IsMain).Url));
        }
    }
}
