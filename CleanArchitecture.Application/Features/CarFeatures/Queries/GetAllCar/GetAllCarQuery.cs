using CleanArchitecture.Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Features.CarFeatures.Queries.GetAllCar;

    public  sealed record GetAllCarQuery(
        //Pagination mantığı için bu değrleri girdik
        int PageNumber = 1,
        int PageSize = 10,
        string Search = "") : IRequest<EntityFrameworkCorePagination.Nuget.Pagination.PaginationResult<Car>>;


