using FluentResults;
using PetsFile.Domain.Pets.Entities;

namespace PetsFile.Application.Pets.Interfaces
{
    public interface IPetWriter
    {
        Task<Result> WriteAsync(Pet pet);
    }
}