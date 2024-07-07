using Application.v1.ViewModels.Requests.Trips;
using Application.v1.ViewModels.Responses.Trips;
using AutoMapper;
using Core.v1.Entities;

namespace Application.v1.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Trip, TripResponse>();
            CreateMap<AddTripRequest, Trip>();
            CreateMap<UpdateTripRequest, Trip>();
            CreateMap<IEnumerable<Trip>, TripListResponse>()
                .ForMember(x => x.TripList, opt => opt.MapFrom(src => src));

        }
    }
}
