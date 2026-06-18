using Microsoft.AspNetCore.Mvc;
using Shortly.Application.DTOs;
using Shortly.Application.Interfaces;

namespace Shortly.Endpoints;

public static class ApiEndpoints
{
    public static void MapApiEndpoints(this WebApplication app)
    {
        var api = app.MapGroup("/api");

        api.MapPost("/urls", async (
            HttpContext context,
            CreateUrlRequest request,
            ILinkService service) =>
        {
            var result = await service.CreateLink(request.Url, 1);

            return Results.Created(
                $"/api/urls/{result.Id}",
                result);
        });

        api.MapGet("/urls", async (ILinkService service) =>
        {
            return Results.Ok(await service.GetAllLinks());
        });

        api.MapGet("/urls/{id:long}", async (
            long id,
            ILinkService service) =>
        {
            try
            {
                return Results.Ok(await service.GetLinkById(id));
            }
            catch
            {
                return Results.NotFound();
            }
        });

        api.MapDelete("/urls/{id:long}", async (
            long id,
            ILinkService service) =>
        {
            try
            {
                await service.DeleteLink(id);

                return Results.NoContent();
            }
            catch
            {
                return Results.NotFound();
            }
        });

        api.MapGet("/stats", async (ILinkService service) =>
        {
            return Results.Ok(await service.GetStats());
        });
    }
}