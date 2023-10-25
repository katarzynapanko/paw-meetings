﻿using FluentResults;
using MediatR;
using Microsoft.AspNetCore.Http;
using PetsFile.Domain.Pets.Enums;

namespace PetsFile.Application.Pets.Messages.Commands
{
    public record SavePetCommand(DateTime DateOfBirth, string Name,
        PetGender PetGender, Guid PetTypeId, Guid OwnerId, Guid[] TraitIds) : IRequest<Result>
    {
        public Stream? PhotoStream { get; private set; }
        public string Path { get; private set; } = string.Empty;

        public async Task AddPhoto(IFormFile photo)
        {
            var memoryStream = new MemoryStream();
            var fileExtension = photo.FileName[^3..];
            await photo.CopyToAsync(memoryStream);
            PhotoStream = memoryStream;
            var fileName = Guid.NewGuid();
            Path = $"{fileName}.{fileExtension}";
        }
    }
}