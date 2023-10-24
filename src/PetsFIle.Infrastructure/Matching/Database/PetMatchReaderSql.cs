using Dapper;
using FluentResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PetsFile.Application.Common.Config;
using PetsFile.Application.Common.Interfaces;
using PetsFile.Application.Matching.Interfaces;
using PetsFile.Application.Matching.Models;
using PetsFile.Domain.Matching.Entities;
using PetsFile.Domain.Pets.Entities;
using PetsFIle.Infrastructure.Common.Database;
using System.Text;

namespace PetsFIle.Infrastructure.Matching.Database
{
    public class PetMatchReaderSql : IPetMatchReader
    {
        private readonly IDapperConnectionProvider _connectionProvider;
        private readonly MatchingOptions _matchingOptions;

        public PetMatchReaderSql(IDapperConnectionProvider connectionProvider, MatchingOptions matchingOptions)
        {
            _connectionProvider = connectionProvider;
            _matchingOptions = matchingOptions;
        }

        public async Task<PetMatchingInfo> GetPetMatchingInfo(Guid petId, Guid ownerId, CancellationToken ct = default)
        {
            StringBuilder sb = new StringBuilder();
            using var connection = _connectionProvider.Connect();
            string queryOwnerBLSql = "SELECT PetTypeId FROM dbo.[OwnerBlackLists] WHERE OwnerId=@ownerId";
            var ownerBL = (await connection.QueryAsync<OwnerBlackList>(queryOwnerBLSql)).ToArray();
                //( Id=@petId");
            string queryMatchingInfoSql = sb.ToString();
            try
            {
                var result = await connection.QueryMultipleAsync(queryMatchingInfoSql, new PetMatchingInfo
                {
                    //OwnerAddresses = x.Owner.OwnerAddresses.ToList(),
                    //Traits = x.PetTraits.Select(x => x.TraitId).ToList(),
                    //PetBlackList = x.PetBlackLists.Select(x => x.PetTypeId).ToList(),
                    //OwnerBlackList = queryOwnerBLSql.Where(x => x.OwnerId == ownerId).Select(x => x.PetTypeId)
                });
                var reslt = (await connection.QueryAsync<PetMatchingInfo>(queryMatchingInfoSql)).ToList();
                return null;
                //var outcome = result.Count == 0
                //    ? Result.Fail("Failed to fetch data")
                //    : Result.Ok(result);
                //return outcome.Value;
            }
            catch (TimeoutException ex)
            {
                return null;
                //return Result.Fail(new ExceptionalError(ex));
            }
        }

        public async Task<IEnumerable<Pet>> GetMatchingPets(PetMatchingInfo petMatchingInfo, CancellationToken ct = default)
        {
            var citiesToMatchTo = petMatchingInfo.OwnerAddresses.Select(z => z.City).ToArray();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT TOP (5) Id, DateOfRegistration, Gender, Name, OwnerId, PetTypeId");
            sb.AppendLine("FROM dbo.[Pets] INNER JOIN [Owners] AS [o] ON [Pets].[OwnerId]");
            sb.AppendLine("WHERE EXISTS (SELECT 1 FROM OwnerAddress] AS [oA] WHERE [o].[Id] = [oA].OwnerId] AND [oA].[CIty] = @petMatchingInfo.OwnerAddresses.City");
            sb.AppendLine("AND (( SELECT COUNT(*) FROM [PetTraits] AS [pT] WHERE [Pets].[Id] = [pT].[PetId] AND [pT].[TraitId] IN (@petMatchingInfo.Traits))");
            sb.AppendLine(">= 2 OR (( SELECT COUNT(*) FROM [PetTraits] AS [p1] WHERE [Pets].[Id] = [p1].[PetId] = 1");
            sb.AppendLine("AND (SELECT TOP(1) [p2].TaraitId] FROM [PetTraits] AS [p2] WHERE [Pets].[Id] = [p2].[PetId] IN (@petMatchingInfo.Traits) ORDER BY RAND()");

            using var connection = _connectionProvider.Connect();

        }
    }
}
