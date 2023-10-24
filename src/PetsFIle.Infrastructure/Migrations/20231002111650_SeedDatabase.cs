using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PetsFIle.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OwnerAddress_Owners_OwnerId",
                table: "OwnerAddress");

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "DateOfBirth", "DateOfRegistration", "Email", "Name", "Password", "Surname" },
                values: new object[,]
                {
                    { new Guid("0be58f5e-e1f2-49a1-9393-014ee916a0a9"), new DateTime(2023, 5, 8, 9, 23, 2, 951, DateTimeKind.Unspecified).AddTicks(7727), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(8752), "8bcbc222-74fb-47e7-a7ea-67197d7564bf", "Briar", "eb462f71-d66b-44c1-a977-ed7d17f5e174", "Justice" },
                    { new Guid("0d3d8223-595d-46e5-a162-fcfafbb58ddd"), new DateTime(2022, 10, 21, 19, 41, 16, 882, DateTimeKind.Unspecified).AddTicks(4051), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(2929), "343d6861-68d4-4f09-91c8-30eebc58edb6", "Milena", "9b1e0a41-cf3a-4fe9-9b6d-e1fa3a33231a", "Paula" },
                    { new Guid("119aa302-917a-49cb-8605-c02d18fb97b8"), new DateTime(2021, 11, 2, 7, 43, 39, 37, DateTimeKind.Unspecified).AddTicks(5038), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(71), "416890f6-5ff1-4f1e-b525-2d9e8cb3c7a6", "Dane", "e133e95b-9a8d-4c02-8f83-77d330292317", "Milena" },
                    { new Guid("20c2f6e4-b90f-454f-83f1-7dba98e0b279"), new DateTime(2024, 1, 8, 9, 0, 40, 931, DateTimeKind.Unspecified).AddTicks(1175), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(6115), "cdd96559-ab62-48fc-ad0c-2d3fa9da77ed", "Hope", "f672fe72-4d99-4786-91c2-e679f9d7aa5b", "Helen" },
                    { new Guid("214a5e13-fdce-414f-998d-9127248be72a"), new DateTime(2024, 9, 23, 9, 55, 46, 907, DateTimeKind.Unspecified).AddTicks(4031), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(1961), "e53eb52a-2381-40af-a0a1-3717e66e20e1", "Dane", "3fdc41cb-04a9-41aa-b9b1-1774d4b0736c", "Amber" },
                    { new Guid("21c4fb69-db5a-43d2-84f4-f4a66bcd6acf"), new DateTime(2024, 1, 6, 0, 44, 0, 75, DateTimeKind.Unspecified).AddTicks(3675), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(8291), "0e67706b-fb6b-4f6c-b918-5f7632e128c8", "Milena", "84877878-2195-488e-9507-8d15e58593c4", "Paula" },
                    { new Guid("2549c1b5-dc1c-411f-b748-ac8fa8eb8b96"), new DateTime(2025, 8, 4, 23, 25, 18, 228, DateTimeKind.Unspecified).AddTicks(3133), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(2452), "a008f8ed-addc-4aa3-9ac1-a21543d6ce1f", "Lu", "ea07ac09-64b2-49b1-8735-b699d32f4e0a", "Lu" },
                    { new Guid("266d3186-0341-4f26-b659-6e77e4b59b09"), new DateTime(2022, 4, 10, 7, 24, 26, 457, DateTimeKind.Unspecified).AddTicks(261), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(5638), "e035b71d-4e56-4566-9939-f92db4c2f071", "Chana", "33526304-25c7-48c0-be54-3dcf1fc3fd8f", "Crosby" },
                    { new Guid("2842931d-ba22-49d9-a210-5ec7da7f0e38"), new DateTime(2021, 10, 30, 11, 32, 36, 8, DateTimeKind.Unspecified).AddTicks(9895), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(9813), "7dfd94f0-2274-4d8a-b167-725d093200bd", "Clark", "0a3504dd-55e7-49ee-a90d-33527b3e1b2f", "Leonard" },
                    { new Guid("28990dcf-8b93-432d-ae75-577e666d99ea"), new DateTime(2022, 4, 28, 16, 8, 23, 569, DateTimeKind.Unspecified).AddTicks(3379), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(5402), "39d81214-906b-4ad9-9242-f91f429975a4", "Hope", "91a3c771-811e-493b-b787-268e5b0b5973", "Hope" },
                    { new Guid("29f4611b-bbcf-4b99-a0e4-31f99e9ebce5"), new DateTime(2022, 12, 22, 9, 5, 6, 269, DateTimeKind.Unspecified).AddTicks(3814), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(8985), "6ce54a42-288f-4bde-aa1b-478bc1fa811c", "Khalani", "0f976a99-86c3-4e37-a8d5-043b684ac5c6", "Hope" },
                    { new Guid("2e5c7a4b-18f4-4b29-af19-b42f30c6590e"), new DateTime(2024, 11, 25, 15, 10, 28, 514, DateTimeKind.Unspecified).AddTicks(7373), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(6607), "e377126e-3eed-45a7-b189-e307b11a5d9d", "Hope", "241f8c4d-fb7c-424e-9d9b-39d6066e6c32", "Dane" },
                    { new Guid("347b934f-660e-4b43-bbdc-10275d952d19"), new DateTime(2024, 2, 1, 1, 7, 59, 312, DateTimeKind.Unspecified).AddTicks(9515), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(8521), "7319cafc-1016-4491-a060-b6e8053aaf16", "Lu", "a2ba2f23-a310-4838-8ac2-27fb3dcdeb66", "Briar" },
                    { new Guid("37ff66ff-3316-45aa-9e47-af2beb60a493"), new DateTime(2024, 5, 14, 13, 31, 21, 630, DateTimeKind.Unspecified).AddTicks(5479), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(4441), "9e48558d-4048-4d8c-8cd1-ac6f20c3ec11", "Micah", "10aa89dc-21dd-4cf0-9ac1-8a91031a9f23", "Dane" },
                    { new Guid("3acae947-bc99-4c80-910c-d2b061fed7fc"), new DateTime(2023, 7, 18, 12, 44, 45, 817, DateTimeKind.Unspecified).AddTicks(9691), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(6370), "e597654b-6474-4d3a-918e-10d94231bb0b", "Amber", "d54bc200-f284-446b-bd18-c5ac905b8b3a", "Coen" },
                    { new Guid("3b961c37-0585-4a8c-b1c8-e41d198d6ae8"), new DateTime(2024, 2, 2, 2, 50, 59, 88, DateTimeKind.Unspecified).AddTicks(7513), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(3469), "311e1253-474d-41b8-bd32-6705bd9914af", "Crosby", "ece4cbe4-be25-40a3-ad9d-57de68ac5133", "Clark" },
                    { new Guid("3c3cf92e-cc87-4a76-aec2-f59db3b64a51"), new DateTime(2024, 1, 30, 9, 39, 50, 656, DateTimeKind.Unspecified).AddTicks(6155), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(9330), "27322f30-7a29-4562-8937-3c334e8bed34", "Avayah", "3605833e-94cd-4807-b090-01f4a89c3c3c", "Demi" },
                    { new Guid("3ea5a79e-7868-4546-968a-658871805fd0"), new DateTime(2023, 9, 20, 9, 14, 12, 706, DateTimeKind.Unspecified).AddTicks(7416), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(532), "853b5cec-2cb6-4717-94dd-c47846af3a84", "Clark", "d78c1138-502d-454f-9003-87e5f0c6e610", "Crosby" },
                    { new Guid("42d3c77e-cde9-4f3a-a863-2793f9cdab63"), new DateTime(2024, 10, 27, 7, 21, 2, 301, DateTimeKind.Unspecified).AddTicks(6953), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(302), "b8180c42-bf08-4e2a-b0f5-13e3be5e72c1", "Clark", "840709d0-5c0e-49a9-a9e1-337b9a11a80a", "Avayah" },
                    { new Guid("46ee8744-a25d-4264-a376-cefcb2cfc73f"), new DateTime(2025, 1, 26, 12, 45, 49, 374, DateTimeKind.Unspecified).AddTicks(6413), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(8033), "9f8f5c5d-60d5-4526-afb5-42b78ad247c4", "Avayah", "b333f966-49f8-43b5-a246-31528ae1893d", "Briar" },
                    { new Guid("596aeaa0-becc-4bac-b667-a7bec72ed4a2"), new DateTime(2023, 7, 23, 1, 23, 59, 171, DateTimeKind.Unspecified).AddTicks(4685), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(3708), "f66c0565-eb68-4fa1-ba4b-d89b2c37c568", "Beckett", "840623c8-7a35-487f-9a06-d11332721c8a", "Coen" },
                    { new Guid("5973c3ed-9258-4032-84b8-ab5ad714ec2e"), new DateTime(2024, 3, 16, 10, 19, 24, 688, DateTimeKind.Unspecified).AddTicks(3430), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(8836), "e62d1aff-fc8e-4698-954f-2ac5bddb6106", "Crosby", "77ddc290-f147-435b-9ff3-9b4a5f40b4de", "Beckett" },
                    { new Guid("60814896-8c94-4042-b987-77bda8f41325"), new DateTime(2024, 4, 18, 11, 49, 21, 801, DateTimeKind.Unspecified).AddTicks(2971), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(990), "d73e392b-f78d-4a5f-a1b8-c6f2a8bef200", "Helen", "5047d455-06f9-45ee-ab62-2038188fa846", "Avayah" },
                    { new Guid("6328beb4-2df9-4e6a-bb38-04e21fbeb955"), new DateTime(2022, 12, 5, 13, 2, 29, 922, DateTimeKind.Unspecified).AddTicks(5054), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(7644), "ad6a6dca-5341-477f-859c-681765806a20", "Beckett", "2c13b37c-8687-4e51-a37c-ee76e5ee9375", "Crosby" },
                    { new Guid("67c29be0-2642-4e68-ad1d-118d0cccbd28"), new DateTime(2025, 4, 10, 21, 44, 40, 217, DateTimeKind.Unspecified).AddTicks(2519), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(7383), "2881b372-814d-46e6-ab7a-060a916b29fb", "Paula", "a1b7b318-86dc-42f3-b488-ea00cd8244eb", "Lu" },
                    { new Guid("72b53a77-e52c-4084-ae72-a03bf2119969"), new DateTime(2025, 4, 10, 4, 36, 39, 2, DateTimeKind.Unspecified).AddTicks(2317), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(4200), "9454b754-7c3f-47ee-914c-2b507e4082a1", "Micah", "e8bf6651-b1f0-4de7-bb32-c4e98d7958e1", "Clark" },
                    { new Guid("74411985-f1b7-41cd-81c9-bded310d51cb"), new DateTime(2025, 3, 25, 7, 1, 48, 96, DateTimeKind.Unspecified).AddTicks(2626), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(4909), "cc4c9b04-86cc-4672-a0d8-647cdedeb8c3", "Crosby", "60cb4797-af02-4bbb-8949-f992c0c9cfb0", "Milena" },
                    { new Guid("87321221-5e60-486d-aab7-800ebd589376"), new DateTime(2022, 1, 9, 1, 50, 37, 254, DateTimeKind.Unspecified).AddTicks(2284), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(4674), "e2191f70-ba2a-405d-a502-8d298cd81ddc", "Hope", "73bfaabc-cab6-49c2-8b7b-3f055163482b", "Micah" },
                    { new Guid("94066b79-d947-45fd-a930-aa8b6e99e41d"), new DateTime(2022, 11, 20, 3, 8, 54, 234, DateTimeKind.Unspecified).AddTicks(6182), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(7069), "005c0164-b293-4537-bfda-e94a43a62950", "Avayah", "e28b329c-01e4-4585-a6b5-6e576dfb35c5", "Micah" },
                    { new Guid("9425065c-8e24-47c3-a752-d6f8a2e4e10d"), new DateTime(2025, 7, 30, 11, 19, 46, 431, DateTimeKind.Unspecified).AddTicks(2484), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(3187), "d6fce0d9-19f8-41f1-9d36-6a623ebbb8ec", "Clark", "10f49274-f76e-4b5c-abb8-6f36ca34a9de", "Amber" },
                    { new Guid("94d6caa2-9251-4519-9adb-0460389096cc"), new DateTime(2023, 10, 31, 12, 50, 33, 193, DateTimeKind.Unspecified).AddTicks(3333), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(6837), "4dee231e-2975-493b-91c3-ad6f6bee2aa5", "Avayah", "f820dcc9-e6e2-4e68-a2ce-3c706ce34349", "Micah" },
                    { new Guid("96a6650a-050b-43ef-884e-32f954bff12b"), new DateTime(2024, 1, 3, 10, 53, 24, 59, DateTimeKind.Unspecified).AddTicks(508), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(1486), "c8c88f26-2ff7-460f-9af6-75a8b8c8561d", "Avayah", "5251fbed-4c2d-4bd2-bfad-6d1893214a9e", "Leonard" },
                    { new Guid("9af75ebf-9a91-4e1a-963b-30882a3b6833"), new DateTime(2025, 5, 22, 0, 5, 57, 303, DateTimeKind.Unspecified).AddTicks(3495), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(8116), "7d1a73a4-5999-480e-9ea6-0aababce0475", "Leonard", "aba49b0c-c506-4885-ac52-8040bffe1e8c", "Paula" },
                    { new Guid("a2efda0f-2935-424d-8244-5aad9d0e0bab"), new DateTime(2025, 7, 25, 6, 22, 35, 473, DateTimeKind.Unspecified).AddTicks(7576), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(2219), "87f094cf-3356-4191-ae62-57db6dd315ef", "Avayah", "39177693-e132-41e7-8914-34b369e79ab9", "Amber" },
                    { new Guid("a67a06d0-786e-4155-9b83-c68de7b902c3"), new DateTime(2022, 12, 21, 21, 15, 36, 994, DateTimeKind.Unspecified).AddTicks(6084), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(8375), "87e0d825-4dba-4885-b240-cb123e9c3735", "Paula", "5019f818-2778-4416-a969-7e71197b83d3", "Hope" },
                    { new Guid("a96e5a6e-0c5e-43f0-818f-00ef2921b266"), new DateTime(2025, 3, 9, 23, 28, 14, 729, DateTimeKind.Unspecified).AddTicks(2832), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(761), "28e2a8f8-39b0-4b34-89bc-0981eaf6fb51", "Milena", "6dae0d22-6f9d-434e-8e3c-3aee12dfe359", "Khalani" },
                    { new Guid("adba297b-1f7d-4268-a350-1263ada38a2f"), new DateTime(2021, 10, 19, 17, 44, 26, 661, DateTimeKind.Unspecified).AddTicks(7988), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(5872), "a5af0970-0da5-40c0-ad8b-fea9495a3068", "Khalani", "9321c1ac-6f26-4711-b73b-e32626f875a7", "Milena" },
                    { new Guid("b186e1b3-729b-4c57-bca8-d7ec734ae894"), new DateTime(2023, 10, 31, 5, 32, 49, 821, DateTimeKind.Unspecified).AddTicks(4216), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(7563), "0161b1b4-37c5-455c-81a7-e2a2ad8fb14a", "Demi", "c0ccfc38-8438-4c92-90e8-a6a7b66dbc32", "Avayah" },
                    { new Guid("b6d63b4d-57ee-4910-8e16-a6f73ded90fd"), new DateTime(2024, 6, 14, 8, 3, 14, 257, DateTimeKind.Unspecified).AddTicks(7972), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(1258), "0282613c-a945-49a1-a938-eeb9f2cd69fd", "Demi", "a2063ee8-9289-4f6e-9a16-ed0f845eae48", "Lu" },
                    { new Guid("b6fb36b8-1df5-44e8-a8ee-986d83dfa39d"), new DateTime(2022, 6, 26, 4, 16, 11, 253, DateTimeKind.Unspecified).AddTicks(685), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(1723), "c4db666b-2017-4b96-9a84-87cdaabfb9b4", "Helen", "da081dcb-e84e-42b1-86ec-bc745ae86acc", "Khalani" },
                    { new Guid("bbdb8554-379e-4905-976b-294d6ed9a8d2"), new DateTime(2024, 5, 10, 19, 35, 30, 150, DateTimeKind.Unspecified).AddTicks(4419), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(5146), "27e5743e-5af1-45cc-8c7d-75a19af23ef6", "Helen", "08d18677-00c5-42b3-8ba3-d465950454e3", "Amber" },
                    { new Guid("bf9600e2-0ab5-4aca-bcca-275d626f7639"), new DateTime(2024, 2, 4, 8, 58, 2, 913, DateTimeKind.Unspecified).AddTicks(2252), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(7324), "63db35a1-ac21-4c00-a35c-8c23ac51c1ad", "Helen", "ff096e6e-32fe-4243-8670-38501b6b3d88", "Micah" },
                    { new Guid("c0826915-d479-4937-8d58-e36a121dd692"), new DateTime(2024, 1, 27, 9, 35, 44, 128, DateTimeKind.Unspecified).AddTicks(6580), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(7800), "68655668-3253-4673-8e0d-3e4776485a7f", "Dane", "f93dd765-f1f6-4ac3-9b13-881c73b3cd9d", "Leonard" },
                    { new Guid("d1bbccf7-e8f2-4eae-991e-9b60c5055f27"), new DateTime(2024, 10, 6, 23, 28, 31, 487, DateTimeKind.Unspecified).AddTicks(7021), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(2687), "06cceaf2-c464-446f-b1f6-4fd9ee3fa989", "Justice", "314309b6-e20b-4f75-b470-bd92b82f91a8", "Justice" },
                    { new Guid("d512e878-c198-4920-b15c-f0fbefc1013b"), new DateTime(2025, 3, 24, 15, 15, 44, 942, DateTimeKind.Unspecified).AddTicks(996), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(9094), "3e93f123-8a95-468b-baff-de8a378f576b", "Beckett", "3ed70b12-d202-4fe9-b173-0dc44306812b", "Coen" },
                    { new Guid("d68651ae-a895-4748-a1e3-83b75ab9db87"), new DateTime(2021, 11, 8, 14, 10, 29, 464, DateTimeKind.Unspecified).AddTicks(8244), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(9232), "a1708ebb-b78b-4b5e-a9ba-104b8a44c55f", "Dane", "724e36a2-42d6-4389-b99a-deaf02203b4f", "Helen" },
                    { new Guid("de0ce7d0-dff5-4143-b2eb-e7904f8053af"), new DateTime(2023, 3, 16, 3, 35, 45, 853, DateTimeKind.Unspecified).AddTicks(3228), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(8606), "8811d136-8533-4a16-b0cf-b809eb0a9c28", "Coen", "bc32e720-f083-4a2f-9d49-5a5ffc482e75", "Briar" },
                    { new Guid("e33d8fba-08ac-4ebf-8e9f-2fb8ec87f9c4"), new DateTime(2024, 10, 28, 14, 38, 23, 219, DateTimeKind.Unspecified).AddTicks(8760), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6830), "e4b241e5-5f83-4dfa-92dc-e09f36fb1c13", "Beckett", "ed128747-0b73-42d6-8b77-991a21da8f40", "Justice" },
                    { new Guid("e75643f0-4bd8-4c16-ab99-ec025c0590a4"), new DateTime(2024, 7, 10, 12, 36, 9, 333, DateTimeKind.Unspecified).AddTicks(4763), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(9562), "f57524d5-7a2a-4df5-9500-95e949f005a4", "Khalani", "9859c5bc-7e90-43e0-8109-10909ab68478", "Amber" },
                    { new Guid("f07194eb-fba3-4579-b59f-875724d0ac95"), new DateTime(2023, 3, 20, 19, 54, 24, 482, DateTimeKind.Unspecified).AddTicks(6413), new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(3942), "0c0036ab-b82d-4651-b3a9-4069727e3daa", "Paula", "e19e4a4a-5f6f-4bfc-b88b-d0dcde95c3b3", "Justice" }
                });

            migrationBuilder.InsertData(
                table: "PetTypes",
                columns: new[] { "Id", "DateOfRegistration", "Type" },
                values: new object[,]
                {
                    { new Guid("02a4c2f0-501f-467f-b8d1-49481192f900"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6337), "Horse" },
                    { new Guid("1471ea91-364e-443d-9053-c2437649b1a9"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6344), "Bird" },
                    { new Guid("19931f50-6aed-4163-b91c-e5ef4ae249a4"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6321), "Horse" },
                    { new Guid("7e9b84bc-ba88-4c9a-9de1-48c3ed5dd325"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6342), "Bird" },
                    { new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6331), "Guinea pig" },
                    { new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6335), "Dog" },
                    { new Guid("bc359535-c27e-488e-a3c8-81f385b61a80"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6324), "Horse" },
                    { new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6329), "Horse" },
                    { new Guid("eadb86e5-2061-4ba3-b944-b72654efe25c"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6338), "Bird" },
                    { new Guid("f4003394-10f9-4023-ae92-4baddeb78356"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6326), "Rat" }
                });

            migrationBuilder.InsertData(
                table: "Traits",
                columns: new[] { "Id", "DateOfRegistration", "Name" },
                values: new object[,]
                {
                    { new Guid("045f5234-991b-4d1d-8da5-af3ee2dd3286"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6210), "brave" },
                    { new Guid("058d9135-d0e2-4763-9f18-40a4213cebd7"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6214), "friendly" },
                    { new Guid("12045f34-a4ad-4f85-8fcc-b368c05cdd80"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6225), "smart" },
                    { new Guid("15974b02-138d-46c2-861e-58447faa82eb"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6208), "loyal" },
                    { new Guid("1c942947-4cec-467b-b4a9-64625f78ec3a"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6223), "gentle" },
                    { new Guid("1fe25ecf-61d9-4f1e-b8b6-1eb0fc01333a"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6221), "cheerful" },
                    { new Guid("2e9b06c3-d649-4f78-b5a9-6e757ce2b406"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6222), "nervous" },
                    { new Guid("2f43c50e-bdbf-4d86-a48f-45e4305dbe81"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6215), "quiet" },
                    { new Guid("384ebf7c-bd18-454c-84d4-808f8235a1ed"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6202), "loud" },
                    { new Guid("43f02c8f-8cc0-4cf7-b5e6-e0e00770a6d0"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6231), "trustworthy" },
                    { new Guid("44c329c7-f791-4ef7-a84f-785ccf427427"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6195), "active" },
                    { new Guid("684387d2-acb0-414c-bebc-d79a386fee0a"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6228), "spoiled" },
                    { new Guid("7c4accb0-3d7a-4b2d-9d40-8ead1853b3e4"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6199), "lazy" },
                    { new Guid("8bafa452-5a48-4e6d-ac2f-af3b3001c86d"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6201), "afraid" },
                    { new Guid("953b615a-ccd7-4d3c-9c7b-83e2063f8729"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6230), "intelligent" },
                    { new Guid("a291e486-dcbb-4f7a-a0a2-b6eaba27923a"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6229), "silly" },
                    { new Guid("b2d03918-cc9c-40e1-9f26-cc39a74dfb3b"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6218), "clumsy" },
                    { new Guid("b6ff5ad8-5295-4e48-ae54-d18d683cee18"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6206), "loving" },
                    { new Guid("d3113723-dee3-44a8-9500-ef40e0159569"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6217), "calm" },
                    { new Guid("db3b8386-beb1-45df-b19f-8f4299f9a511"), new DateTime(2023, 10, 2, 11, 16, 50, 649, DateTimeKind.Utc).AddTicks(6212), "shy" }
                });

            migrationBuilder.InsertData(
                table: "OwnerAddress",
                columns: new[] { "Id", "City", "Country", "DateOfRegistration", "District", "OwnerId", "PostalCode", "Street" },
                values: new object[,]
                {
                    { new Guid("0237c593-b25e-4057-89c2-6391551229c2"), "London", "Italy", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(1514), "Starówka", new Guid("b6fb36b8-1df5-44e8-a8ee-986d83dfa39d"), "80-21", "f42c4eb7-eb7e-41b1-b4b9-99eec409afb1" },
                    { new Guid("0db03bff-5df5-4a3f-8f9d-cc68c8f01ac4"), "Krakow", "UK", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(439), "Starówka", new Guid("de0ce7d0-dff5-4143-b2eb-e7904f8053af"), "80-21", "bddebdd4-2ee5-4d7b-a85d-9341cfee8d71" },
                    { new Guid("1001102b-6201-4483-9dbb-9aabbf46f155"), "Gdansk", "Czech Republic", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(3086), "Wrzeszcz", new Guid("3acae947-bc99-4c80-910c-d2b061fed7fc"), "80-251", "05acdd4e-52be-46af-9640-ede961c235c6" },
                    { new Guid("1191ba9b-4a88-4d53-b0a4-390672ea4d56"), "London", "Italy", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(87), "Wrzeszcz", new Guid("67c29be0-2642-4e68-ad1d-118d0cccbd28"), "80-251", "c8c3db52-c303-4eba-82a3-1e903194891a" },
                    { new Guid("1bc548a7-487e-4fb7-9f4a-27d60673af61"), "Krakow", "UK", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(867), "Orunia", new Guid("2842931d-ba22-49d9-a210-5ec7da7f0e38"), "80-59", "ecf201ab-36d2-41bb-ab94-f2cc75f85172" },
                    { new Guid("23c10e98-2778-46b2-9177-c685740a67de"), "Gdansk", "Poland", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(3494), "Starówka", new Guid("b186e1b3-729b-4c57-bca8-d7ec734ae894"), "80-21", "eb25a9d7-c556-4849-b8fe-42e4cfa8aef4" },
                    { new Guid("27165e4b-24fd-45db-9225-9ac5ebc12598"), "Rome", "UK", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(2916), "Wrzeszcz", new Guid("adba297b-1f7d-4268-a350-1263ada38a2f"), "80-251", "e237d272-e56e-4c21-b090-d29134c72c63" },
                    { new Guid("2c642f40-6717-44d6-b11c-f6f41b3e3ef7"), "Krakow", "Poland", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(1344), "Oliwa", new Guid("b6d63b4d-57ee-4910-8e16-a6f73ded90fd"), "80-398", "f4401b62-fe7a-4fdd-8582-c8b0f875cadc" },
                    { new Guid("318ad972-5fb8-45b6-aabb-04bfbedb26e3"), "Prague", "UK", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(2749), "Starówka", new Guid("28990dcf-8b93-432d-ae75-577e666d99ea"), "80-21", "95f77b98-3ca3-4c26-8ce7-124a921708b6" },
                    { new Guid("417ce465-4982-400c-af9d-15caa5fa970f"), "Gdansk", "Czech Republic", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4076), "Brooklyn", new Guid("d68651ae-a895-4748-a1e3-83b75ab9db87"), "65-154", "917c43f8-07a7-44e0-a76f-6344dd339bfa" },
                    { new Guid("4613afd7-a1f6-469f-9889-21de75f09440"), "Gdansk", "Poland", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(756), "Wrzeszcz", new Guid("e75643f0-4bd8-4c16-ab99-ec025c0590a4"), "80-251", "61f57d7a-ac64-4fd1-bf7f-cfea193c3f65" },
                    { new Guid("46b0cad6-464e-4089-994e-754cf809393f"), "Brno", "UK", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(3731), "Brooklyn", new Guid("21c4fb69-db5a-43d2-84f4-f4a66bcd6acf"), "65-154", "dd3a0583-ad70-4e57-848a-db5802a94bee" },
                    { new Guid("4f84fc45-764f-4778-bd2e-0e2e620451e0"), "Brno", "Poland", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(1846), "Brooklyn", new Guid("d1bbccf7-e8f2-4eae-991e-9b60c5055f27"), "65-154", "9026bbe3-a5ec-4a50-bfbb-3e8815107a17" },
                    { new Guid("57596b4f-77ce-42c9-a48e-c5d260814672"), "Brno", "UK", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(2508), "Wrzeszcz", new Guid("87321221-5e60-486d-aab7-800ebd589376"), "80-251", "e42e0a6e-ca79-4a1a-a7ce-9ada195a4658" },
                    { new Guid("584bd032-f793-42a4-8728-65c3fbfcd796"), "Brno", "Poland", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(1271), "Oliwa", new Guid("60814896-8c94-4042-b987-77bda8f41325"), "80-398", "e2cbf6c6-22aa-4a1a-99a7-5d2a7a2b6a1f" },
                    { new Guid("59f99b19-d877-4cf4-9920-b904acbb26df"), "Slupsk", "Czech Republic", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(1917), "Orunia", new Guid("0d3d8223-595d-46e5-a162-fcfafbb58ddd"), "80-59", "7084dcb6-8411-4b6d-b0dd-d3f4b6149224" },
                    { new Guid("5bbe0d5a-8f88-4f95-8bf0-beee9bfe6363"), "Krakow", "Italy", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(3253), "Starówka", new Guid("94d6caa2-9251-4519-9adb-0460389096cc"), "80-21", "3405bd9e-889a-421f-8508-e0361c27efc6" },
                    { new Guid("61e9ec3e-d321-4a48-9dca-31fc8e749d0e"), "Warsaw", "Italy", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(2160), "Brooklyn", new Guid("596aeaa0-becc-4bac-b667-a7bec72ed4a2"), "65-154", "eb45859f-36ac-45fb-9e53-5122bf5dd1ca" },
                    { new Guid("653b7988-c3af-418e-8e8d-24d53bb26094"), "London", "Italy", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(3563), "Starówka", new Guid("c0826915-d479-4937-8d58-e36a121dd692"), "80-21", "a0015760-8c1c-4dba-beec-2678dd44b458" },
                    { new Guid("6a7594d4-961d-473e-9954-e35a98520e90"), "Madrid", "Czech Republic", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(1034), "Starówka", new Guid("42d3c77e-cde9-4f3a-a863-2793f9cdab63"), "80-21", "a2d0072d-d4b8-45e6-bcab-316a9dfbc05a" },
                    { new Guid("6f7017d0-14ef-4bf5-b7c4-87b0b72f08b9"), "Warsaw", "Czech Republic", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(168), "Starówka", new Guid("6328beb4-2df9-4e6a-bb38-04e21fbeb955"), "80-21", "78c08e05-e5eb-46da-982a-4baedcc07c91" },
                    { new Guid("700d5188-dd70-4ee0-8202-fbf9e1eef61c"), "Slupsk", "Italy", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(1442), "Wrzeszcz", new Guid("96a6650a-050b-43ef-884e-32f954bff12b"), "80-251", "bbc5f080-a2b8-49df-a131-b1aa9854618c" },
                    { new Guid("722d981e-6030-4f9d-9078-ee9aafe02586"), "Krakow", "Czech Republic", new DateTime(2023, 10, 2, 11, 16, 50, 650, DateTimeKind.Utc).AddTicks(9897), "Brooklyn", new Guid("e33d8fba-08ac-4ebf-8e9f-2fb8ec87f9c4"), "65-154", "0f1c1eab-bb7b-448a-8a02-1757385b7ecb" },
                    { new Guid("76494062-c13f-47a3-ac6a-2e32e743f550"), "Prague", "Italy", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(2260), "Orunia", new Guid("f07194eb-fba3-4579-b59f-875724d0ac95"), "80-59", "a668a048-44a9-4d67-a44e-71724991e4d9" },
                    { new Guid("81734981-a9ea-4377-9a03-ab961ca8832d"), "Slupsk", "Poland", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(1585), "Orunia", new Guid("214a5e13-fdce-414f-998d-9127248be72a"), "80-59", "8c7e9b60-6b8d-474b-a5fa-a5810fe7bc12" },
                    { new Guid("82a5c632-5dd9-4937-be9a-09abefd8ee60"), "Krakow", "Poland", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(2845), "Starówka", new Guid("266d3186-0341-4f26-b659-6e77e4b59b09"), "80-21", "6fac557d-aff0-4f5b-8eaf-8676199b4634" },
                    { new Guid("89b07993-a235-4ad3-a7b3-2edebe279538"), "Warsaw", "UK", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(610), "Orunia", new Guid("d512e878-c198-4920-b15c-f0fbefc1013b"), "80-59", "7825a5db-c926-4174-9cfa-df417441c40c" },
                    { new Guid("8a451837-5d9f-4e9e-b3c1-4f4517571dd7"), "Gdansk", "Italy", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(2679), "Oliwa", new Guid("bbdb8554-379e-4905-976b-294d6ed9a8d2"), "80-398", "5d80aba2-edcc-4110-bfe6-8378ec34136b" },
                    { new Guid("916fb205-a457-4545-8666-11c2b1bfabf9"), "Madrid", "Czech Republic", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(2089), "Orunia", new Guid("3b961c37-0585-4a8c-b1c8-e41d198d6ae8"), "80-59", "be98ca53-0122-4a17-adae-5630bcf49fb9" },
                    { new Guid("94436a75-a883-4ccb-a410-b6dc4ee5a21d"), "Brno", "Czech Republic", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(2331), "Orunia", new Guid("72b53a77-e52c-4084-ae72-a03bf2119969"), "80-59", "e5e0413a-cd0e-4d9a-87cc-78f57ab99206" },
                    { new Guid("a267bc5c-db67-487d-9874-f69d20ea28ee"), "London", "Czech Republic", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(2579), "Orunia", new Guid("74411985-f1b7-41cd-81c9-bded310d51cb"), "80-59", "9af5a17e-3a60-4ee5-ae16-5e6335c7932a" },
                    { new Guid("a2a3c89f-5554-487a-845a-fa4b6e4454f2"), "Slupsk", "Poland", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(3827), "Oliwa", new Guid("347b934f-660e-4b43-bbdc-10275d952d19"), "80-398", "d22be7d4-5e1d-4d61-9d39-9f55f8b95854" },
                    { new Guid("a2d5106a-02e7-4706-b657-2e1878204bc0"), "Slupsk", "Poland", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(2437), "Wrzeszcz", new Guid("37ff66ff-3316-45aa-9e47-af2beb60a493"), "80-251", "87285113-6fe1-450e-b7ba-a2cd5b96b3d6" },
                    { new Guid("a8f22a39-57fb-48de-9732-9baca7ea5af3"), "Prague", "Italy", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(1750), "Starówka", new Guid("2549c1b5-dc1c-411f-b748-ac8fa8eb8b96"), "80-21", "af208ef6-87d9-4ac8-a45c-be475b98c73e" },
                    { new Guid("a943a440-cac9-489d-b4de-0bdb993a44ab"), "Warsaw", "Italy", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(939), "Orunia", new Guid("119aa302-917a-49cb-8605-c02d18fb97b8"), "80-59", "20281fc6-12bf-4aad-b7cd-7cbf9fee8cdb" },
                    { new Guid("a9bc6275-1140-43cd-9e57-1305b70bfa40"), "Gdansk", "Poland", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(3971), "Wrzeszcz", new Guid("29f4611b-bbcf-4b99-a0e4-31f99e9ebce5"), "80-251", "bca5a3b2-0294-4656-8870-1528b8f68111" },
                    { new Guid("aa9df198-bf86-48e5-afd6-b9fc4ae97c8c"), "London", "Italy", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(511), "Starówka", new Guid("5973c3ed-9258-4032-84b8-ab5ad714ec2e"), "80-21", "666d8f56-569c-43ca-a3db-d08843aefe50" },
                    { new Guid("ab5dd1df-0fb3-4cbb-8c30-dc2b845e59b1"), "Madrid", "Italy", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(683), "Wrzeszcz", new Guid("3c3cf92e-cc87-4a76-aec2-f59db3b64a51"), "80-251", "742999d5-d649-4aea-a6a1-276b51b09452" },
                    { new Guid("b4c75220-43e4-4824-a334-0d63ca04c2ea"), "Slupsk", "Czech Republic", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(1106), "Oliwa", new Guid("3ea5a79e-7868-4546-968a-658871805fd0"), "80-398", "4e3d32d2-f069-4e56-88a7-408faa1599f8" },
                    { new Guid("b9068051-57e2-4395-ae51-aeb16324a13e"), "Warsaw", "Italy", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(3660), "Wrzeszcz", new Guid("46ee8744-a25d-4264-a376-cefcb2cfc73f"), "80-251", "2fa336f4-daa6-4778-8282-a4975f37aeb5" },
                    { new Guid("b96b6918-2dcb-4dfd-ac7f-0b8abb740287"), "Slupsk", "Italy", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(270), "Starówka", new Guid("9af75ebf-9a91-4e1a-963b-30882a3b6833"), "80-21", "4db1fca8-2341-44f4-9f32-6b36e0b79786" },
                    { new Guid("bb9acf7b-0657-4e1b-a74c-c2559093d41d"), "Brno", "UK", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(1679), "Wrzeszcz", new Guid("a2efda0f-2935-424d-8244-5aad9d0e0bab"), "80-251", "b95f624c-9d82-4b96-90fa-157a507ec58d" },
                    { new Guid("c2f46f39-d4ad-491c-846b-4bc48cd76fa5"), "Krakow", "UK", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(3158), "Brooklyn", new Guid("2e5c7a4b-18f4-4b29-af19-b42f30c6590e"), "65-154", "d7b71631-e422-423b-90a3-4a93d0033ede" },
                    { new Guid("cbbceea7-1ab8-492b-b032-8b494711b8b7"), "Prague", "Poland", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(342), "Wrzeszcz", new Guid("a67a06d0-786e-4155-9b83-c68de7b902c3"), "80-251", "9f29c997-449a-43f0-9ebb-dbf50316b13c" },
                    { new Guid("d35621b2-09d5-4bad-b6fb-9e32887b44d9"), "Brno", "Italy", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(1176), "Brooklyn", new Guid("a96e5a6e-0c5e-43f0-818f-00ef2921b266"), "65-154", "03179cff-c1b3-49e4-b686-b9b5ac5f0f00" },
                    { new Guid("dc23084d-2727-4239-a886-36bc9ff05d64"), "London", "Czech Republic", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(3011), "Orunia", new Guid("20c2f6e4-b90f-454f-83f1-7dba98e0b279"), "80-59", "25c7dde1-8367-4b4e-bbdc-fcf696e9cb1f" },
                    { new Guid("e0401d98-d4a1-48d9-893e-0503b12488cb"), "Krakow", "Italy", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(3422), "Oliwa", new Guid("bf9600e2-0ab5-4aca-bcca-275d626f7639"), "80-398", "e3d0a047-93d0-4eb5-aa3d-6098777a59b0" },
                    { new Guid("e09c1098-6169-4beb-9358-24f93c587b59"), "Madrid", "Poland", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(3898), "Brooklyn", new Guid("0be58f5e-e1f2-49a1-9393-014ee916a0a9"), "65-154", "feed45e7-0784-49c0-b183-7fa247d1dfc2" },
                    { new Guid("e545b8b6-79b2-4165-a1af-6a1c128db0b7"), "Brno", "Czech Republic", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(2015), "Starówka", new Guid("9425065c-8e24-47c3-a752-d6f8a2e4e10d"), "80-21", "66a51dff-523e-42a5-9ff1-428149e4da38" },
                    { new Guid("fe624540-6b24-440f-8fe7-a36cacd071d5"), "Rome", "UK", new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(3325), "Wrzeszcz", new Guid("94066b79-d947-45fd-a930-aa8b6e99e41d"), "80-251", "a022a68b-ba4f-46f7-a23c-0cc7e794c8e8" }
                });

            migrationBuilder.InsertData(
                table: "OwnerBlackLists",
                columns: new[] { "Id", "OwnerId", "PetTypeId" },
                values: new object[,]
                {
                    { new Guid("05d4a986-b50c-4667-b232-3a254ac75839"), new Guid("a96e5a6e-0c5e-43f0-818f-00ef2921b266"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("06dd01bd-ca43-44a6-bc5c-4b04a193645a"), new Guid("6328beb4-2df9-4e6a-bb38-04e21fbeb955"), new Guid("f4003394-10f9-4023-ae92-4baddeb78356") },
                    { new Guid("0a86e9de-e96a-43da-86d7-8e96958e8990"), new Guid("3c3cf92e-cc87-4a76-aec2-f59db3b64a51"), new Guid("bc359535-c27e-488e-a3c8-81f385b61a80") },
                    { new Guid("120afe48-b33c-4d62-8718-6579148fd521"), new Guid("d512e878-c198-4920-b15c-f0fbefc1013b"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("1ef49751-803c-42d4-917b-4bf253ce3d9f"), new Guid("d1bbccf7-e8f2-4eae-991e-9b60c5055f27"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("2b3f2b68-497c-47a2-ba42-49e4da62a733"), new Guid("214a5e13-fdce-414f-998d-9127248be72a"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("355152ed-7403-45ba-aadb-e822e5b8c4fc"), new Guid("0d3d8223-595d-46e5-a162-fcfafbb58ddd"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("3667728d-6e23-4d68-83fe-c5d81ab2bacd"), new Guid("5973c3ed-9258-4032-84b8-ab5ad714ec2e"), new Guid("7e9b84bc-ba88-4c9a-9de1-48c3ed5dd325") },
                    { new Guid("3a6744d8-9845-4591-bdb6-73251db5d745"), new Guid("119aa302-917a-49cb-8605-c02d18fb97b8"), new Guid("f4003394-10f9-4023-ae92-4baddeb78356") },
                    { new Guid("3ed99a2b-b848-4369-95de-6a6b0b0378f7"), new Guid("9425065c-8e24-47c3-a752-d6f8a2e4e10d"), new Guid("7e9b84bc-ba88-4c9a-9de1-48c3ed5dd325") },
                    { new Guid("649e052b-dcfe-41ce-be4a-503f18703e8a"), new Guid("a2efda0f-2935-424d-8244-5aad9d0e0bab"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("6c7d98f6-b5cf-45ec-8e0c-79510ae53df0"), new Guid("9af75ebf-9a91-4e1a-963b-30882a3b6833"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("8541f561-48a7-4018-94d0-9661bfa76a6d"), new Guid("96a6650a-050b-43ef-884e-32f954bff12b"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("98e8670a-5a03-498b-86c5-c8016888aadf"), new Guid("2842931d-ba22-49d9-a210-5ec7da7f0e38"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("a3b44907-6adf-457f-982f-6029e9ea6346"), new Guid("e33d8fba-08ac-4ebf-8e9f-2fb8ec87f9c4"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("c122c85d-6131-40ac-b75d-964de2ec14f4"), new Guid("67c29be0-2642-4e68-ad1d-118d0cccbd28"), new Guid("eadb86e5-2061-4ba3-b944-b72654efe25c") },
                    { new Guid("d2867ab4-a306-473c-99bb-84f882d4b12b"), new Guid("3ea5a79e-7868-4546-968a-658871805fd0"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("dced6412-8712-4729-b537-9c1e6b391fae"), new Guid("60814896-8c94-4042-b987-77bda8f41325"), new Guid("7e9b84bc-ba88-4c9a-9de1-48c3ed5dd325") },
                    { new Guid("e39c7389-52b0-41d8-8b12-1ba2998a9636"), new Guid("a67a06d0-786e-4155-9b83-c68de7b902c3"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("e8de579b-30cd-49d9-95f2-e57f5a460076"), new Guid("b6fb36b8-1df5-44e8-a8ee-986d83dfa39d"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("ec20ece7-57a2-4ddc-9e49-7de81b75d5b0"), new Guid("e75643f0-4bd8-4c16-ab99-ec025c0590a4"), new Guid("19931f50-6aed-4163-b91c-e5ef4ae249a4") },
                    { new Guid("ef137eb7-41a3-4928-aa26-03955da1b4a4"), new Guid("42d3c77e-cde9-4f3a-a863-2793f9cdab63"), new Guid("eadb86e5-2061-4ba3-b944-b72654efe25c") },
                    { new Guid("efacf232-8d66-41a4-ba64-1649e395f73f"), new Guid("b6d63b4d-57ee-4910-8e16-a6f73ded90fd"), new Guid("7e9b84bc-ba88-4c9a-9de1-48c3ed5dd325") },
                    { new Guid("f39ccdd9-8d8c-44ea-aa09-754ed5eba23b"), new Guid("2549c1b5-dc1c-411f-b748-ac8fa8eb8b96"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("f967f5f0-239a-46a3-9f70-597b4bcef6d0"), new Guid("de0ce7d0-dff5-4143-b2eb-e7904f8053af"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") }
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "DateOfBirth", "DateOfRegistration", "Gender", "Name", "OwnerId", "PetTypeId" },
                values: new object[,]
                {
                    { new Guid("0503fb2e-9fe0-4c9c-98f1-048ec3e64643"), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4408), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4408), 0, "CHUEY", new Guid("119aa302-917a-49cb-8605-c02d18fb97b8"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("059555e3-86ef-4a81-bf58-5e650034d03d"), new DateTime(2014, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4831), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4830), 0, "BOOM", new Guid("b6fb36b8-1df5-44e8-a8ee-986d83dfa39d"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("05fa4454-8956-4d0b-8ca5-0fbd57900583"), new DateTime(2018, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4929), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4928), 0, "MIKE", new Guid("28990dcf-8b93-432d-ae75-577e666d99ea"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("098fa3c3-d88b-49b2-9e37-a2bc2728b443"), new DateTime(2022, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4679), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4678), 0, "BLAZ", new Guid("a2efda0f-2935-424d-8244-5aad9d0e0bab"), new Guid("eadb86e5-2061-4ba3-b944-b72654efe25c") },
                    { new Guid("0a3f8a6d-e611-4e84-8eb3-d6eb2c172d6c"), new DateTime(2015, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4739), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4739), 0, "FLOKEY", new Guid("3b961c37-0585-4a8c-b1c8-e41d198d6ae8"), new Guid("bc359535-c27e-488e-a3c8-81f385b61a80") },
                    { new Guid("0ff62f50-6296-4220-8723-80335cbf6500"), new DateTime(2022, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4377), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4376), 0, "JUANBOBO", new Guid("3acae947-bc99-4c80-910c-d2b061fed7fc"), new Guid("f4003394-10f9-4023-ae92-4baddeb78356") },
                    { new Guid("10781e9d-a38d-4029-a3d0-954843518924"), new DateTime(2017, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4851), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4850), 0, "CASABA", new Guid("3c3cf92e-cc87-4a76-aec2-f59db3b64a51"), new Guid("f4003394-10f9-4023-ae92-4baddeb78356") },
                    { new Guid("119909d2-d664-40c8-95a0-3a104200c8ff"), new DateTime(2018, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4882), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4881), 0, "UFEK", new Guid("2e5c7a4b-18f4-4b29-af19-b42f30c6590e"), new Guid("bc359535-c27e-488e-a3c8-81f385b61a80") },
                    { new Guid("12ab61fa-d7a0-419c-a6c9-e24cf747bff3"), new DateTime(2022, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4350), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4350), 0, "JUANBOBO", new Guid("e75643f0-4bd8-4c16-ab99-ec025c0590a4"), new Guid("eadb86e5-2061-4ba3-b944-b72654efe25c") },
                    { new Guid("13203021-b7b2-49f2-8949-d3b1f0461cc6"), new DateTime(2020, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4422), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4422), 0, "UFEK", new Guid("87321221-5e60-486d-aab7-800ebd589376"), new Guid("eadb86e5-2061-4ba3-b944-b72654efe25c") },
                    { new Guid("145344c8-4ba3-4e92-b4b8-2a4e446b2530"), new DateTime(2015, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4363), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4362), 0, "MIKE", new Guid("214a5e13-fdce-414f-998d-9127248be72a"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("170aa5e4-4322-4b43-bdfa-e73c4ee41724"), new DateTime(2018, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4977), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4976), 0, "UFEK", new Guid("e75643f0-4bd8-4c16-ab99-ec025c0590a4"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("18849703-41c1-40b2-98ff-dc9f7a01cbb0"), new DateTime(2014, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4615), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4614), 0, "FLOKEY", new Guid("3b961c37-0585-4a8c-b1c8-e41d198d6ae8"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("1b734894-4dbc-4386-bf9d-b86e62b5dc5e"), new DateTime(2015, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4256), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4255), 0, "TWIGA", new Guid("2842931d-ba22-49d9-a210-5ec7da7f0e38"), new Guid("7e9b84bc-ba88-4c9a-9de1-48c3ed5dd325") },
                    { new Guid("1e36aa36-b3d7-4981-be5e-4fc9624d1729"), new DateTime(2014, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4396), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4396), 0, "CASABA", new Guid("2e5c7a4b-18f4-4b29-af19-b42f30c6590e"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("26ae8be6-a670-4824-93ed-32d3c4f002b4"), new DateTime(2015, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4888), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4887), 0, "UFEK", new Guid("5973c3ed-9258-4032-84b8-ab5ad714ec2e"), new Guid("19931f50-6aed-4163-b91c-e5ef4ae249a4") },
                    { new Guid("28cc2f37-4a21-4648-9ec4-fb9939e9b3ce"), new DateTime(2018, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4758), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4757), 0, "JUANBOBO", new Guid("42d3c77e-cde9-4f3a-a863-2793f9cdab63"), new Guid("7e9b84bc-ba88-4c9a-9de1-48c3ed5dd325") },
                    { new Guid("2a124c1c-b7be-402c-aa46-d5cd95564dc9"), new DateTime(2019, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4302), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4302), 0, "MANDO", new Guid("2549c1b5-dc1c-411f-b748-ac8fa8eb8b96"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("2a9120c7-462d-430e-aa6e-384251468336"), new DateTime(2015, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4628), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4627), 0, "TWIGA", new Guid("a96e5a6e-0c5e-43f0-818f-00ef2921b266"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("2b62fd2a-5684-43bd-a189-25e385effd2a"), new DateTime(2020, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4289), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4288), 0, "FLOKEY", new Guid("67c29be0-2642-4e68-ad1d-118d0cccbd28"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("2b6a8d60-3c5f-4fbe-9cb1-6772b7e36afb"), new DateTime(2019, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4733), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4733), 0, "BOOZER", new Guid("f07194eb-fba3-4579-b59f-875724d0ac95"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("2beda2e1-d9aa-42ef-831a-ef8fa730e72d"), new DateTime(2014, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4476), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4475), 0, "SABASTEIN", new Guid("2e5c7a4b-18f4-4b29-af19-b42f30c6590e"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("3393ca84-c374-455a-b8d9-888d16e17315"), new DateTime(2017, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4659), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4658), 0, "CASABA", new Guid("bf9600e2-0ab5-4aca-bcca-275d626f7639"), new Guid("7e9b84bc-ba88-4c9a-9de1-48c3ed5dd325") },
                    { new Guid("398b573a-e90b-4d4e-b98c-f7b55a1eb9d1"), new DateTime(2018, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4228), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4228), 0, "TWIGA", new Guid("b6d63b4d-57ee-4910-8e16-a6f73ded90fd"), new Guid("f4003394-10f9-4023-ae92-4baddeb78356") },
                    { new Guid("440b376b-8add-4b08-8096-176bcc0e2451"), new DateTime(2022, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4489), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4488), 0, "TAIFA", new Guid("37ff66ff-3316-45aa-9e47-af2beb60a493"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("464a03ed-e2da-4f7b-b233-035f92eeea60"), new DateTime(2022, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4713), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4713), 0, "UFEK", new Guid("a67a06d0-786e-4155-9b83-c68de7b902c3"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("46c36839-e09b-4631-a675-682d884ce9f5"), new DateTime(2019, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4296), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4296), 0, "RUBY", new Guid("2842931d-ba22-49d9-a210-5ec7da7f0e38"), new Guid("eadb86e5-2061-4ba3-b944-b72654efe25c") },
                    { new Guid("474324f5-fd5a-4d23-81c7-b5b8b66d7136"), new DateTime(2019, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4983), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4982), 0, "MIKE", new Guid("3c3cf92e-cc87-4a76-aec2-f59db3b64a51"), new Guid("eadb86e5-2061-4ba3-b944-b72654efe25c") },
                    { new Guid("49b637b3-f68f-42e7-b29e-1906e52b132e"), new DateTime(2021, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4502), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4501), 0, "JUANBOBO", new Guid("e33d8fba-08ac-4ebf-8e9f-2fb8ec87f9c4"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("4b5fe238-692a-441d-92c4-b7adfd464d02"), new DateTime(2014, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4764), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4763), 0, "TAIFA", new Guid("b186e1b3-729b-4c57-bca8-d7ec734ae894"), new Guid("bc359535-c27e-488e-a3c8-81f385b61a80") },
                    { new Guid("4d30da1c-70f7-435e-9534-a79cb70fc9ab"), new DateTime(2015, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4789), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4788), 0, "BOOZER", new Guid("67c29be0-2642-4e68-ad1d-118d0cccbd28"), new Guid("19931f50-6aed-4163-b91c-e5ef4ae249a4") },
                    { new Guid("52ff43df-86f8-49f2-b90d-ea832a37e610"), new DateTime(2017, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4707), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4707), 0, "JUANBOBO", new Guid("2e5c7a4b-18f4-4b29-af19-b42f30c6590e"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("55eae726-586b-4357-b446-cf7f0b9a7a47"), new DateTime(2021, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4856), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4856), 0, "TAIFA", new Guid("28990dcf-8b93-432d-ae75-577e666d99ea"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("56ed86a3-d97f-43f7-9548-7960670c4995"), new DateTime(2019, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4969), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4968), 0, "BROWNEY", new Guid("e75643f0-4bd8-4c16-ab99-ec025c0590a4"), new Guid("bc359535-c27e-488e-a3c8-81f385b61a80") },
                    { new Guid("5a3afcfa-2691-4868-84b9-db7d461a5990"), new DateTime(2014, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4862), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4862), 0, "BOOZER", new Guid("de0ce7d0-dff5-4143-b2eb-e7904f8053af"), new Guid("19931f50-6aed-4163-b91c-e5ef4ae249a4") },
                    { new Guid("5ab7c84c-fc9f-41d8-8840-853bec4b1f56"), new DateTime(2017, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4345), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4344), 0, "BOOZER", new Guid("37ff66ff-3316-45aa-9e47-af2beb60a493"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("5b350f92-70d9-4797-a0c3-c59bfbedd5b9"), new DateTime(2016, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4802), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4802), 0, "CHUEY", new Guid("de0ce7d0-dff5-4143-b2eb-e7904f8053af"), new Guid("eadb86e5-2061-4ba3-b944-b72654efe25c") },
                    { new Guid("5e7c00c7-d0a1-41b1-9dd6-6d5eef899993"), new DateTime(2016, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4429), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4428), 0, "FLOKEY", new Guid("a67a06d0-786e-4155-9b83-c68de7b902c3"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("5ff5f1d7-d3fb-4f28-98a1-cb841bf038ba"), new DateTime(2021, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4389), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4388), 0, "LUCKIE", new Guid("e75643f0-4bd8-4c16-ab99-ec025c0590a4"), new Guid("f4003394-10f9-4023-ae92-4baddeb78356") },
                    { new Guid("637452d1-38c4-4c80-a0c8-d86ee987f70e"), new DateTime(2021, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4383), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4382), 0, "RUBY", new Guid("119aa302-917a-49cb-8605-c02d18fb97b8"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("677521a5-b4a7-434b-994e-8495c7579762"), new DateTime(2020, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4283), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4282), 0, "CHUEY", new Guid("bf9600e2-0ab5-4aca-bcca-275d626f7639"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("71a44309-af9f-4414-b5ee-59f82a5d617a"), new DateTime(2018, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4243), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4242), 0, "MANDO", new Guid("37ff66ff-3316-45aa-9e47-af2beb60a493"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("73b3d0c5-b3c8-45e6-a275-a2026cdeae52"), new DateTime(2015, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4875), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4875), 0, "CHUEY", new Guid("d1bbccf7-e8f2-4eae-991e-9b60c5055f27"), new Guid("eadb86e5-2061-4ba3-b944-b72654efe25c") },
                    { new Guid("7419c10d-ed3d-4c35-9384-62568f33e97a"), new DateTime(2016, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4213), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4212), 1, "FLOKEY", new Guid("67c29be0-2642-4e68-ad1d-118d0cccbd28"), new Guid("bc359535-c27e-488e-a3c8-81f385b61a80") },
                    { new Guid("75c4bf57-849e-46d6-95ea-3fa604356ccb"), new DateTime(2020, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4795), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4794), 0, "JUANBOBO", new Guid("0be58f5e-e1f2-49a1-9393-014ee916a0a9"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("7770fbcc-96ea-4d03-8323-399eac1deb6e"), new DateTime(2014, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4634), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4633), 0, "LUCKIE", new Guid("29f4611b-bbcf-4b99-a0e4-31f99e9ebce5"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("7901ae91-3642-446a-9325-515c29875ce5"), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4720), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4719), 0, "BROWNEY", new Guid("6328beb4-2df9-4e6a-bb38-04e21fbeb955"), new Guid("f4003394-10f9-4023-ae92-4baddeb78356") },
                    { new Guid("7b61146c-11fb-41fc-8bf8-00b455348109"), new DateTime(2018, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4868), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4867), 0, "MIKE", new Guid("2e5c7a4b-18f4-4b29-af19-b42f30c6590e"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("7cdfc11b-d421-46b4-b358-510d89bea70c"), new DateTime(2015, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4513), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4513), 0, "FLOKEY", new Guid("b186e1b3-729b-4c57-bca8-d7ec734ae894"), new Guid("bc359535-c27e-488e-a3c8-81f385b61a80") },
                    { new Guid("7d0ce67d-7883-4ea3-89fb-dae83e01eb11"), new DateTime(2020, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4270), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4270), 0, "MAYA", new Guid("2e5c7a4b-18f4-4b29-af19-b42f30c6590e"), new Guid("eadb86e5-2061-4ba3-b944-b72654efe25c") },
                    { new Guid("7fc66a1c-f4c8-4708-875f-fac08ed00bda"), new DateTime(2017, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4519), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4519), 0, "MANDO", new Guid("347b934f-660e-4b43-bbdc-10275d952d19"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("84495437-1312-4d2a-8849-46371c080efb"), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4777), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4776), 0, "TWIGA", new Guid("3b961c37-0585-4a8c-b1c8-e41d198d6ae8"), new Guid("bc359535-c27e-488e-a3c8-81f385b61a80") },
                    { new Guid("8699fde6-6e02-4668-b678-cdc38d16673f"), new DateTime(2017, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4745), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4744), 0, "MAYA", new Guid("9425065c-8e24-47c3-a752-d6f8a2e4e10d"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("87eda7d8-0bc1-459f-80fa-f426523cc1dc"), new DateTime(2018, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4894), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4893), 0, "FLOKEY", new Guid("119aa302-917a-49cb-8605-c02d18fb97b8"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("8a7df677-ef15-4d66-a25e-290dcf3bf0fd"), new DateTime(2014, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4671), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4670), 0, "MANDO", new Guid("d1bbccf7-e8f2-4eae-991e-9b60c5055f27"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("8e6a69f1-42a5-44c2-a226-e0a81c8429ea"), new DateTime(2022, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4589), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4588), 0, "CHUEY", new Guid("de0ce7d0-dff5-4143-b2eb-e7904f8053af"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("92d48b28-ab30-4c72-9675-4270abee827e"), new DateTime(2019, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4957), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4957), 0, "FREEDOOM", new Guid("94d6caa2-9251-4519-9adb-0460389096cc"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("9378afde-cd3f-4186-b03a-2ce93a7aa559"), new DateTime(2019, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4621), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4620), 0, "FREEDOOM", new Guid("a2efda0f-2935-424d-8244-5aad9d0e0bab"), new Guid("19931f50-6aed-4163-b91c-e5ef4ae249a4") },
                    { new Guid("9638bbc9-5293-452e-a7cd-ce90433f7133"), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4263), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4262), 0, "FREEDOOM", new Guid("d1bbccf7-e8f2-4eae-991e-9b60c5055f27"), new Guid("7e9b84bc-ba88-4c9a-9de1-48c3ed5dd325") },
                    { new Guid("96aee99f-b9f5-4a23-8085-a68991b03c80"), new DateTime(2022, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4915), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4914), 0, "TWIGA", new Guid("5973c3ed-9258-4032-84b8-ab5ad714ec2e"), new Guid("19931f50-6aed-4163-b91c-e5ef4ae249a4") },
                    { new Guid("98c2f040-4f88-4e6d-b91a-7e3a3b033bd0"), new DateTime(2020, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4357), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4356), 0, "LUPO", new Guid("74411985-f1b7-41cd-81c9-bded310d51cb"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("9baf2404-7a96-44c1-a228-9f415475b004"), new DateTime(2017, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4989), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4988), 0, "BOOZER", new Guid("3acae947-bc99-4c80-910c-d2b061fed7fc"), new Guid("eadb86e5-2061-4ba3-b944-b72654efe25c") },
                    { new Guid("9c233746-048d-4d08-bb0b-6e4cda4d0639"), new DateTime(2020, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4482), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4481), 0, "FREEDOOM", new Guid("21c4fb69-db5a-43d2-84f4-f4a66bcd6acf"), new Guid("eadb86e5-2061-4ba3-b944-b72654efe25c") },
                    { new Guid("9f4f60b5-01ad-4f5b-9c52-86d170c2c895"), new DateTime(2019, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4463), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4462), 0, "BROWNEY", new Guid("21c4fb69-db5a-43d2-84f4-f4a66bcd6acf"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("a0bb695a-f979-4e8e-818a-29fa2d081db9"), new DateTime(2021, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4665), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4664), 0, "TAIFA", new Guid("119aa302-917a-49cb-8605-c02d18fb97b8"), new Guid("f4003394-10f9-4023-ae92-4baddeb78356") },
                    { new Guid("a1d38323-b870-4c9f-9ebe-a6dca6f5fa50"), new DateTime(2015, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4540), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4539), 0, "FREEDOOM", new Guid("5973c3ed-9258-4032-84b8-ab5ad714ec2e"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("a2403760-6713-49b7-8e4a-c5b28d0ebd34"), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4221), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4221), 0, "MAYA", new Guid("347b934f-660e-4b43-bbdc-10275d952d19"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("a524554a-fb05-4c4a-a69a-70c0c444bf33"), new DateTime(2015, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4330), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4329), 0, "FREEDOOM", new Guid("347b934f-660e-4b43-bbdc-10275d952d19"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("a6358f74-1051-4dfa-8905-97d381125692"), new DateTime(2019, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4235), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4234), 0, "KLUSIA", new Guid("a2efda0f-2935-424d-8244-5aad9d0e0bab"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("a7b945b8-5867-44e1-9d39-a1eb93c87817"), new DateTime(2020, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4843), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4842), 0, "MIKE", new Guid("596aeaa0-becc-4bac-b667-a7bec72ed4a2"), new Guid("7e9b84bc-ba88-4c9a-9de1-48c3ed5dd325") },
                    { new Guid("aa0e4eb6-2d57-4bc6-a8d7-a8aff8e97cdb"), new DateTime(2019, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4653), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4652), 0, "UFEK", new Guid("74411985-f1b7-41cd-81c9-bded310d51cb"), new Guid("19931f50-6aed-4163-b91c-e5ef4ae249a4") },
                    { new Guid("aae616ae-efc9-4373-a34e-39f95947bef6"), new DateTime(2020, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4602), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4601), 0, "SABASTEIN", new Guid("2842931d-ba22-49d9-a210-5ec7da7f0e38"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("abb05380-6529-4c21-9d3f-a1895f042da4"), new DateTime(2021, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4250), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4249), 0, "LUCKIE", new Guid("c0826915-d479-4937-8d58-e36a121dd692"), new Guid("eadb86e5-2061-4ba3-b944-b72654efe25c") },
                    { new Guid("aebb428b-c99b-4c89-9537-414a12d6f420"), new DateTime(2014, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4527), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4527), 0, "KLUSIA", new Guid("a96e5a6e-0c5e-43f0-818f-00ef2921b266"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("b109772e-27ea-4e6a-96d4-d81467f27d90"), new DateTime(2019, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4963), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4963), 0, "BOOM", new Guid("3acae947-bc99-4c80-910c-d2b061fed7fc"), new Guid("f4003394-10f9-4023-ae92-4baddeb78356") },
                    { new Guid("b41d27f1-1c81-4159-aaa3-ab7cf41d265b"), new DateTime(2017, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4415), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4414), 0, "FLOKEY", new Guid("72b53a77-e52c-4084-ae72-a03bf2119969"), new Guid("19931f50-6aed-4163-b91c-e5ef4ae249a4") },
                    { new Guid("b8aa9c89-7b43-4e6e-bb90-cd4e7ef19178"), new DateTime(2017, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4640), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4639), 0, "JUANBOBO", new Guid("87321221-5e60-486d-aab7-800ebd589376"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("b8b78e13-7868-45a5-85e9-cfb97e2bfd82"), new DateTime(2016, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4508), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4507), 0, "KLUSIA", new Guid("bf9600e2-0ab5-4aca-bcca-275d626f7639"), new Guid("19931f50-6aed-4163-b91c-e5ef4ae249a4") },
                    { new Guid("bc097847-edf6-4766-8f67-765cb3f1e0a7"), new DateTime(2022, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4553), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4552), 0, "FREEDOOM", new Guid("a2efda0f-2935-424d-8244-5aad9d0e0bab"), new Guid("f4003394-10f9-4023-ae92-4baddeb78356") },
                    { new Guid("c1f2f777-dc87-4dc0-a47d-b0efe742bc4a"), new DateTime(2022, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4769), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4769), 0, "LUPO", new Guid("96a6650a-050b-43ef-884e-32f954bff12b"), new Guid("f4003394-10f9-4023-ae92-4baddeb78356") },
                    { new Guid("c3d8abec-f174-4228-bd88-be7629132b0b"), new DateTime(2019, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4752), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4751), 0, "RUBY", new Guid("37ff66ff-3316-45aa-9e47-af2beb60a493"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("c62b4d43-b09f-4e06-bee7-a8422c5a8a49"), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4469), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4468), 0, "CHUEY", new Guid("3ea5a79e-7868-4546-968a-658871805fd0"), new Guid("bc359535-c27e-488e-a3c8-81f385b61a80") },
                    { new Guid("c9ba1ff4-b7e6-4f75-ba9a-03a30cf5d721"), new DateTime(2022, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4727), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4726), 0, "ALACA", new Guid("37ff66ff-3316-45aa-9e47-af2beb60a493"), new Guid("19931f50-6aed-4163-b91c-e5ef4ae249a4") },
                    { new Guid("ca1db322-9c19-45a4-bd13-5ff5aabe8105"), new DateTime(2017, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4336), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4336), 0, "MAYA", new Guid("a67a06d0-786e-4155-9b83-c68de7b902c3"), new Guid("7e9b84bc-ba88-4c9a-9de1-48c3ed5dd325") },
                    { new Guid("cf0fecc3-095e-4e29-85ee-b6d21824f01c"), new DateTime(2015, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4646), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4645), 0, "BLAZ", new Guid("37ff66ff-3316-45aa-9e47-af2beb60a493"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("cf5057f3-d910-4499-b571-e39c8d4d7737"), new DateTime(2020, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4909), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4908), 0, "ALACA", new Guid("37ff66ff-3316-45aa-9e47-af2beb60a493"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("d0dcf0a7-f2ab-4df4-bf9f-6648d6cd9e3d"), new DateTime(2016, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4837), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4836), 0, "TAIFA", new Guid("e33d8fba-08ac-4ebf-8e9f-2fb8ec87f9c4"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("d648476d-d083-4f15-a6a8-4f3e1e519c5a"), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4546), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4545), 0, "MANDO", new Guid("b6fb36b8-1df5-44e8-a8ee-986d83dfa39d"), new Guid("19931f50-6aed-4163-b91c-e5ef4ae249a4") },
                    { new Guid("dc077741-16d9-4e1f-9eaf-4ee04e9b22d2"), new DateTime(2014, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4494), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4494), 0, "TAIFA", new Guid("96a6650a-050b-43ef-884e-32f954bff12b"), new Guid("f4003394-10f9-4023-ae92-4baddeb78356") },
                    { new Guid("e1038923-d63b-410f-a787-d7247d4cd1e5"), new DateTime(2018, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4783), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4782), 0, "ALACA", new Guid("94d6caa2-9251-4519-9adb-0460389096cc"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("e1073991-e43f-44e6-af9a-1a67949017b6"), new DateTime(2019, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4582), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4581), 0, "RUBY", new Guid("347b934f-660e-4b43-bbdc-10275d952d19"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("e49d4299-a053-48e4-ac05-6761e385edd4"), new DateTime(2018, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4921), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4920), 0, "BLAZ", new Guid("596aeaa0-becc-4bac-b667-a7bec72ed4a2"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("e505b018-fead-41e1-9776-5163c9af3bf6"), new DateTime(2016, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4902), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4901), 0, "FLOKEY", new Guid("d1bbccf7-e8f2-4eae-991e-9b60c5055f27"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("ea40e4ab-2278-4b3d-ba08-6d9b321196fb"), new DateTime(2022, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4203), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4202), 1, "TAIFA", new Guid("347b934f-660e-4b43-bbdc-10275d952d19"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("ebc0863c-afd0-42eb-babf-93cbde85b3e0"), new DateTime(2015, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4370), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4370), 0, "RUBY", new Guid("bbdb8554-379e-4905-976b-294d6ed9a8d2"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("edbc1f03-de75-4830-a960-ed2561b39a48"), new DateTime(2021, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4595), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4594), 0, "LUPO", new Guid("9425065c-8e24-47c3-a752-d6f8a2e4e10d"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("f35ea29f-5753-41f1-9419-91ef94cfb9e5"), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4402), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4402), 0, "FREEDOOM", new Guid("d1bbccf7-e8f2-4eae-991e-9b60c5055f27"), new Guid("7e9b84bc-ba88-4c9a-9de1-48c3ed5dd325") },
                    { new Guid("f57b0ba6-77ed-41a9-bcb8-bd5954e3b90a"), new DateTime(2018, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4533), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4533), 0, "BOOZER", new Guid("adba297b-1f7d-4268-a350-1263ada38a2f"), new Guid("f4003394-10f9-4023-ae92-4baddeb78356") },
                    { new Guid("f8f93377-34b8-462b-b57d-61082c654832"), new DateTime(2018, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4276), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4276), 0, "MAYA", new Guid("60814896-8c94-4042-b987-77bda8f41325"), new Guid("bc359535-c27e-488e-a3c8-81f385b61a80") },
                    { new Guid("fa084b9b-55a5-4766-837b-f4dee2add91c"), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4609), new DateTime(2023, 10, 2, 11, 16, 50, 651, DateTimeKind.Utc).AddTicks(4608), 0, "TAIFA", new Guid("c0826915-d479-4937-8d58-e36a121dd692"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") }
                });

            migrationBuilder.InsertData(
                table: "PetBlackList",
                columns: new[] { "Id", "PetId", "PetTypeId" },
                values: new object[,]
                {
                    { new Guid("003225cf-c0f6-4f6c-ae81-8a830caafb66"), new Guid("a1d38323-b870-4c9f-9ebe-a6dca6f5fa50"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("02e8f653-5e9e-4024-8920-59f5d2322b1a"), new Guid("71a44309-af9f-4414-b5ee-59f82a5d617a"), new Guid("f4003394-10f9-4023-ae92-4baddeb78356") },
                    { new Guid("030ed192-d09a-4dd7-84cf-efd2ae690fdb"), new Guid("1b734894-4dbc-4386-bf9d-b86e62b5dc5e"), new Guid("bc359535-c27e-488e-a3c8-81f385b61a80") },
                    { new Guid("073698eb-ea69-4e41-9c62-429d7dc10e44"), new Guid("637452d1-38c4-4c80-a0c8-d86ee987f70e"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("07706097-3ecd-4cf2-836e-8ce3b0740354"), new Guid("5ab7c84c-fc9f-41d8-8840-853bec4b1f56"), new Guid("eadb86e5-2061-4ba3-b944-b72654efe25c") },
                    { new Guid("0b56ba7f-09d9-451c-a397-d3570bc3c738"), new Guid("7419c10d-ed3d-4c35-9384-62568f33e97a"), new Guid("bc359535-c27e-488e-a3c8-81f385b61a80") },
                    { new Guid("0bdd4a30-dd75-4d15-93e8-08e264e8beaf"), new Guid("f35ea29f-5753-41f1-9419-91ef94cfb9e5"), new Guid("bc359535-c27e-488e-a3c8-81f385b61a80") },
                    { new Guid("0c27aae2-b455-4449-93c6-5927ceb24505"), new Guid("677521a5-b4a7-434b-994e-8495c7579762"), new Guid("eadb86e5-2061-4ba3-b944-b72654efe25c") },
                    { new Guid("106b5745-d123-4356-bf62-f51338f5d519"), new Guid("12ab61fa-d7a0-419c-a6c9-e24cf747bff3"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("142bedfb-a99c-45b1-84ba-c9c957d9a7bc"), new Guid("145344c8-4ba3-4e92-b4b8-2a4e446b2530"), new Guid("19931f50-6aed-4163-b91c-e5ef4ae249a4") },
                    { new Guid("1761e2ba-f944-4cf9-a6ad-06b2e5f825fa"), new Guid("46c36839-e09b-4631-a675-682d884ce9f5"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("1a318d14-b8c7-41fe-ad9a-e15fe9911f6c"), new Guid("5e7c00c7-d0a1-41b1-9dd6-6d5eef899993"), new Guid("f4003394-10f9-4023-ae92-4baddeb78356") },
                    { new Guid("1bf3f428-594a-489e-aa77-969e547245a3"), new Guid("f8f93377-34b8-462b-b57d-61082c654832"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("21a35cba-97eb-4e86-a469-33e2705e93dc"), new Guid("7fc66a1c-f4c8-4708-875f-fac08ed00bda"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("2ae65313-66d5-4a3c-a39a-67c7ad85353a"), new Guid("2b62fd2a-5684-43bd-a189-25e385effd2a"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("2b097b52-1ccb-4177-b4a1-4883e1de9347"), new Guid("12ab61fa-d7a0-419c-a6c9-e24cf747bff3"), new Guid("f4003394-10f9-4023-ae92-4baddeb78356") },
                    { new Guid("2c6272a3-fc48-4619-8a41-8c48fd34957d"), new Guid("5e7c00c7-d0a1-41b1-9dd6-6d5eef899993"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("39aba7e3-34d3-4756-8b8c-32336bdb49bc"), new Guid("13203021-b7b2-49f2-8949-d3b1f0461cc6"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("408e09b9-f471-42c2-b3af-c69a5f6fbcec"), new Guid("a2403760-6713-49b7-8e4a-c5b28d0ebd34"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("4164b12b-17e2-4449-8361-0a7c96fe371a"), new Guid("1e36aa36-b3d7-4981-be5e-4fc9624d1729"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("462f0086-24af-4357-92c1-640558a8e215"), new Guid("dc077741-16d9-4e1f-9eaf-4ee04e9b22d2"), new Guid("7e9b84bc-ba88-4c9a-9de1-48c3ed5dd325") },
                    { new Guid("464703c0-9a49-4aa9-be0e-a53556605b4e"), new Guid("7d0ce67d-7883-4ea3-89fb-dae83e01eb11"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("472dee00-f21a-4528-a939-936cfd0f72ae"), new Guid("637452d1-38c4-4c80-a0c8-d86ee987f70e"), new Guid("f4003394-10f9-4023-ae92-4baddeb78356") },
                    { new Guid("48107319-96b3-403a-8a26-9c153e01423a"), new Guid("9638bbc9-5293-452e-a7cd-ce90433f7133"), new Guid("19931f50-6aed-4163-b91c-e5ef4ae249a4") },
                    { new Guid("4a9433c8-c66a-4c72-b422-63592f0a0a6d"), new Guid("aae616ae-efc9-4373-a34e-39f95947bef6"), new Guid("bc359535-c27e-488e-a3c8-81f385b61a80") },
                    { new Guid("4df79334-885f-42e1-98f7-37134ea9e022"), new Guid("8e6a69f1-42a5-44c2-a226-e0a81c8429ea"), new Guid("19931f50-6aed-4163-b91c-e5ef4ae249a4") },
                    { new Guid("527d9684-9bd9-40c5-8bf0-12378cda7f8e"), new Guid("2a124c1c-b7be-402c-aa46-d5cd95564dc9"), new Guid("7e9b84bc-ba88-4c9a-9de1-48c3ed5dd325") },
                    { new Guid("56708178-6ee7-419e-9655-ce275a226ed0"), new Guid("f8f93377-34b8-462b-b57d-61082c654832"), new Guid("7e9b84bc-ba88-4c9a-9de1-48c3ed5dd325") },
                    { new Guid("57479a16-30c3-440a-9af3-45da21487731"), new Guid("8e6a69f1-42a5-44c2-a226-e0a81c8429ea"), new Guid("bc359535-c27e-488e-a3c8-81f385b61a80") },
                    { new Guid("5930a18d-24bb-4ee6-8d2c-bb9189abc5e6"), new Guid("9f4f60b5-01ad-4f5b-9c52-86d170c2c895"), new Guid("f4003394-10f9-4023-ae92-4baddeb78356") },
                    { new Guid("5e7a53f0-7721-46b1-9a31-79ca25ee4ec4"), new Guid("dc077741-16d9-4e1f-9eaf-4ee04e9b22d2"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("5ec4b659-49cd-4a91-a0f2-8eabc12594d9"), new Guid("9f4f60b5-01ad-4f5b-9c52-86d170c2c895"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("5eeadb53-09ac-4bb4-a0a6-1316372bab34"), new Guid("1b734894-4dbc-4386-bf9d-b86e62b5dc5e"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("605206c3-d956-47ca-9e60-dd43f6b4fad9"), new Guid("aebb428b-c99b-4c89-9537-414a12d6f420"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("638f215b-cd5a-4317-833c-44f3d069a59f"), new Guid("0503fb2e-9fe0-4c9c-98f1-048ec3e64643"), new Guid("19931f50-6aed-4163-b91c-e5ef4ae249a4") },
                    { new Guid("63b5f76f-0da2-435e-a807-3a0c64832812"), new Guid("98c2f040-4f88-4e6d-b91a-7e3a3b033bd0"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("6654415a-a8b7-4096-be9b-f21817c81ff6"), new Guid("ebc0863c-afd0-42eb-babf-93cbde85b3e0"), new Guid("7e9b84bc-ba88-4c9a-9de1-48c3ed5dd325") },
                    { new Guid("68b35cf6-ee02-4d19-8451-b9d51d3b99d0"), new Guid("9c233746-048d-4d08-bb0b-6e4cda4d0639"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("68c6ca2a-03c9-4cfa-9aa5-1a35e52c0391"), new Guid("398b573a-e90b-4d4e-b98c-f7b55a1eb9d1"), new Guid("19931f50-6aed-4163-b91c-e5ef4ae249a4") },
                    { new Guid("69edc0b8-7128-4f7f-a569-7b4a7e5fba11"), new Guid("46c36839-e09b-4631-a675-682d884ce9f5"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("6c02d66c-3b30-41b5-9877-72834e7c7c4b"), new Guid("f35ea29f-5753-41f1-9419-91ef94cfb9e5"), new Guid("7e9b84bc-ba88-4c9a-9de1-48c3ed5dd325") },
                    { new Guid("6c53d234-0226-4927-b441-a18e0ff04dc7"), new Guid("abb05380-6529-4c21-9d3f-a1895f042da4"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("6d0f74bf-c3d8-40c0-aff1-07c6d5b9bbec"), new Guid("98c2f040-4f88-4e6d-b91a-7e3a3b033bd0"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("716da0e5-ced6-4368-b74d-e6dcbb7fbf2d"), new Guid("b8b78e13-7868-45a5-85e9-cfb97e2bfd82"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("75e75ee0-443c-4c29-a708-c0272334e206"), new Guid("ea40e4ab-2278-4b3d-ba08-6d9b321196fb"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("76d6856d-2b46-4965-9fcd-04dab216c382"), new Guid("a6358f74-1051-4dfa-8905-97d381125692"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("77b8d3b8-497a-4535-92f8-76f7f5589733"), new Guid("0ff62f50-6296-4220-8723-80335cbf6500"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("7db8ce35-72e6-4055-b5ec-3fd03485a03c"), new Guid("edbc1f03-de75-4830-a960-ed2561b39a48"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("7f0a6eff-35a2-4ded-8d01-792e79314eee"), new Guid("e1073991-e43f-44e6-af9a-1a67949017b6"), new Guid("19931f50-6aed-4163-b91c-e5ef4ae249a4") },
                    { new Guid("8078676b-5df9-4793-bde6-d40e8e257bb9"), new Guid("2a124c1c-b7be-402c-aa46-d5cd95564dc9"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("8275e8d4-5330-40c8-bfa3-37de1359951e"), new Guid("bc097847-edf6-4766-8f67-765cb3f1e0a7"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("87a1623a-702a-4cf5-b554-ce624aaeb852"), new Guid("0503fb2e-9fe0-4c9c-98f1-048ec3e64643"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("88b61f57-1d53-49ec-9a63-6d91b8cee75f"), new Guid("ca1db322-9c19-45a4-bd13-5ff5aabe8105"), new Guid("eadb86e5-2061-4ba3-b944-b72654efe25c") },
                    { new Guid("8a618706-84f1-4f5f-a9e3-07ea8d9cf4cd"), new Guid("aebb428b-c99b-4c89-9537-414a12d6f420"), new Guid("eadb86e5-2061-4ba3-b944-b72654efe25c") },
                    { new Guid("8ef09fc6-0ba1-464e-99fc-7915f60e7d11"), new Guid("7cdfc11b-d421-46b4-b358-510d89bea70c"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("8f636256-59c0-4c6a-9404-afd174b83034"), new Guid("b8b78e13-7868-45a5-85e9-cfb97e2bfd82"), new Guid("eadb86e5-2061-4ba3-b944-b72654efe25c") },
                    { new Guid("904ab68d-4da0-46aa-9891-a0ab764c1180"), new Guid("f57b0ba6-77ed-41a9-bcb8-bd5954e3b90a"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("904f6861-2cd3-47b4-85c9-2ea512f3fbce"), new Guid("c62b4d43-b09f-4e06-bee7-a8422c5a8a49"), new Guid("eadb86e5-2061-4ba3-b944-b72654efe25c") },
                    { new Guid("9058462f-cfe0-4149-b8ab-a6fbad73d488"), new Guid("5ab7c84c-fc9f-41d8-8840-853bec4b1f56"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("909c2911-84aa-42d3-864e-c026c1e59595"), new Guid("fa084b9b-55a5-4766-837b-f4dee2add91c"), new Guid("7e9b84bc-ba88-4c9a-9de1-48c3ed5dd325") },
                    { new Guid("923802ff-e301-4d57-911d-4a1a5e2a8447"), new Guid("2b62fd2a-5684-43bd-a189-25e385effd2a"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("93e3f82f-b7a2-4629-a0a9-fa73f2fbccd4"), new Guid("398b573a-e90b-4d4e-b98c-f7b55a1eb9d1"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("9619aaa5-ead3-4b58-9f64-bf88024ca6c7"), new Guid("d648476d-d083-4f15-a6a8-4f3e1e519c5a"), new Guid("bc359535-c27e-488e-a3c8-81f385b61a80") },
                    { new Guid("9776098a-377b-4358-ab75-a2ff9dda52eb"), new Guid("0ff62f50-6296-4220-8723-80335cbf6500"), new Guid("19931f50-6aed-4163-b91c-e5ef4ae249a4") },
                    { new Guid("9949380a-5565-42b6-89b3-8f99e966d786"), new Guid("a1d38323-b870-4c9f-9ebe-a6dca6f5fa50"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("a57d9e47-8bab-4824-be5e-77be8136efa9"), new Guid("7cdfc11b-d421-46b4-b358-510d89bea70c"), new Guid("bc359535-c27e-488e-a3c8-81f385b61a80") },
                    { new Guid("aa4ffd9a-0e86-4b3b-bbd0-45057b5c7f3c"), new Guid("e1073991-e43f-44e6-af9a-1a67949017b6"), new Guid("f4003394-10f9-4023-ae92-4baddeb78356") },
                    { new Guid("b04ea160-5262-4038-9e02-81500afc7233"), new Guid("b41d27f1-1c81-4159-aaa3-ab7cf41d265b"), new Guid("bc359535-c27e-488e-a3c8-81f385b61a80") },
                    { new Guid("b3ffdf42-e906-44e2-ba6b-02f553731642"), new Guid("49b637b3-f68f-42e7-b29e-1906e52b132e"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("b7a3acdf-e4d9-4649-8c27-d0fada80112e"), new Guid("b41d27f1-1c81-4159-aaa3-ab7cf41d265b"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("b7f84f68-9861-4b1a-9bef-b83a440a282b"), new Guid("440b376b-8add-4b08-8096-176bcc0e2451"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("bb6e33ee-b98a-4661-a8db-4d9dcd5bb3bc"), new Guid("a6358f74-1051-4dfa-8905-97d381125692"), new Guid("19931f50-6aed-4163-b91c-e5ef4ae249a4") },
                    { new Guid("bc65ead2-2442-4835-afb3-ff0319dadea5"), new Guid("edbc1f03-de75-4830-a960-ed2561b39a48"), new Guid("19931f50-6aed-4163-b91c-e5ef4ae249a4") },
                    { new Guid("c32e4072-034c-45dd-a78a-ac993fa8c73d"), new Guid("9c233746-048d-4d08-bb0b-6e4cda4d0639"), new Guid("eadb86e5-2061-4ba3-b944-b72654efe25c") },
                    { new Guid("c57561a0-389d-4c74-808f-bd8a913f1431"), new Guid("a2403760-6713-49b7-8e4a-c5b28d0ebd34"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("c66c64dd-7afa-4938-bb68-8c529b06d21a"), new Guid("d648476d-d083-4f15-a6a8-4f3e1e519c5a"), new Guid("f4003394-10f9-4023-ae92-4baddeb78356") },
                    { new Guid("ca43f5a4-1785-4548-9365-acd613191fbc"), new Guid("71a44309-af9f-4414-b5ee-59f82a5d617a"), new Guid("7e9b84bc-ba88-4c9a-9de1-48c3ed5dd325") },
                    { new Guid("ca5a9b67-5b15-4d7b-bd8a-d0fa58e92472"), new Guid("7d0ce67d-7883-4ea3-89fb-dae83e01eb11"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("d2f4061f-9f10-45e6-9d44-b865cafffa0a"), new Guid("13203021-b7b2-49f2-8949-d3b1f0461cc6"), new Guid("bc359535-c27e-488e-a3c8-81f385b61a80") },
                    { new Guid("d34571df-40b0-456f-986e-ceab5a01b1e1"), new Guid("abb05380-6529-4c21-9d3f-a1895f042da4"), new Guid("eadb86e5-2061-4ba3-b944-b72654efe25c") },
                    { new Guid("d95f8b76-386b-4865-8a65-70c53f8e3996"), new Guid("bc097847-edf6-4766-8f67-765cb3f1e0a7"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("d9af2421-af59-440e-beb9-b0d1f710da63"), new Guid("9638bbc9-5293-452e-a7cd-ce90433f7133"), new Guid("f4003394-10f9-4023-ae92-4baddeb78356") },
                    { new Guid("d9f7a5e8-a59e-4c92-ac0e-62bb38505508"), new Guid("ca1db322-9c19-45a4-bd13-5ff5aabe8105"), new Guid("bc359535-c27e-488e-a3c8-81f385b61a80") },
                    { new Guid("dbb9750f-8dfc-4d62-a863-11e423f21bb6"), new Guid("677521a5-b4a7-434b-994e-8495c7579762"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("dbdf02b3-489c-4bd5-95b4-b89332d96981"), new Guid("a524554a-fb05-4c4a-a69a-70c0c444bf33"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("dd57b75f-2602-4c7c-b1d9-8cd7408621f8"), new Guid("ea40e4ab-2278-4b3d-ba08-6d9b321196fb"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("ddec6a08-8919-49a6-bf2a-97cfd3d5f570"), new Guid("a524554a-fb05-4c4a-a69a-70c0c444bf33"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("dff319af-444b-40ff-a9e2-09c2f1518849"), new Guid("c62b4d43-b09f-4e06-bee7-a8422c5a8a49"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") },
                    { new Guid("e013a643-094b-430c-b8ef-73093321adfa"), new Guid("7419c10d-ed3d-4c35-9384-62568f33e97a"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("e275f5c9-a88c-43e7-91b0-88d4bb29a89c"), new Guid("aae616ae-efc9-4373-a34e-39f95947bef6"), new Guid("7e9b84bc-ba88-4c9a-9de1-48c3ed5dd325") },
                    { new Guid("e3724244-4faa-4468-822b-fa6091f59a62"), new Guid("f57b0ba6-77ed-41a9-bcb8-bd5954e3b90a"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("e574a586-fe12-457c-a1d2-de1e6d2904d9"), new Guid("fa084b9b-55a5-4766-837b-f4dee2add91c"), new Guid("bc359535-c27e-488e-a3c8-81f385b61a80") },
                    { new Guid("f2cb51ee-86db-4dfa-a7fd-0498428faa73"), new Guid("5ff5f1d7-d3fb-4f28-98a1-cb841bf038ba"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("f3cd6fc4-fb5c-4be6-bbd8-52a749df0c62"), new Guid("2beda2e1-d9aa-42ef-831a-ef8fa730e72d"), new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a") },
                    { new Guid("f4caf8bc-cbd9-4ff3-8359-6dd4b767e2ed"), new Guid("7fc66a1c-f4c8-4708-875f-fac08ed00bda"), new Guid("eadb86e5-2061-4ba3-b944-b72654efe25c") },
                    { new Guid("f6173088-690e-4d9c-9e1c-86b3d0972679"), new Guid("49b637b3-f68f-42e7-b29e-1906e52b132e"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("f6d9d976-6fe3-40fe-9d08-e163da266eec"), new Guid("145344c8-4ba3-4e92-b4b8-2a4e446b2530"), new Guid("f4003394-10f9-4023-ae92-4baddeb78356") },
                    { new Guid("f8f9c155-a1a8-4d1c-a4f1-717951734395"), new Guid("1e36aa36-b3d7-4981-be5e-4fc9624d1729"), new Guid("eadb86e5-2061-4ba3-b944-b72654efe25c") },
                    { new Guid("f9d5f6f1-0ace-42f5-99bc-7127f584e9c7"), new Guid("5ff5f1d7-d3fb-4f28-98a1-cb841bf038ba"), new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100") },
                    { new Guid("fc141f1f-e7db-4afb-a5c9-2b19c41888c1"), new Guid("2beda2e1-d9aa-42ef-831a-ef8fa730e72d"), new Guid("bc359535-c27e-488e-a3c8-81f385b61a80") },
                    { new Guid("fd22d90d-bcd9-4b95-87d6-733d79660356"), new Guid("440b376b-8add-4b08-8096-176bcc0e2451"), new Guid("02a4c2f0-501f-467f-b8d1-49481192f900") },
                    { new Guid("fedc1cbb-bda5-478c-966b-de2369eda8f6"), new Guid("ebc0863c-afd0-42eb-babf-93cbde85b3e0"), new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206") }
                });

            migrationBuilder.InsertData(
                table: "PetTraits",
                columns: new[] { "Id", "PetId", "TraitId" },
                values: new object[,]
                {
                    { new Guid("0099b259-823c-4e87-a92e-2f1f1e4a4ee0"), new Guid("e1073991-e43f-44e6-af9a-1a67949017b6"), new Guid("953b615a-ccd7-4d3c-9c7b-83e2063f8729") },
                    { new Guid("00e514fc-18f6-478d-a1dc-41e0135eb2ae"), new Guid("a1d38323-b870-4c9f-9ebe-a6dca6f5fa50"), new Guid("1fe25ecf-61d9-4f1e-b8b6-1eb0fc01333a") },
                    { new Guid("01538bfe-6e17-4963-8d22-8909af017546"), new Guid("d0dcf0a7-f2ab-4df4-bf9f-6648d6cd9e3d"), new Guid("7c4accb0-3d7a-4b2d-9d40-8ead1853b3e4") },
                    { new Guid("01c59abf-1168-4b97-b0ce-53f31a324ede"), new Guid("cf5057f3-d910-4499-b571-e39c8d4d7737"), new Guid("d3113723-dee3-44a8-9500-ef40e0159569") },
                    { new Guid("01d48669-b75a-4eba-a530-b44debd78f79"), new Guid("170aa5e4-4322-4b43-bdfa-e73c4ee41724"), new Guid("1fe25ecf-61d9-4f1e-b8b6-1eb0fc01333a") },
                    { new Guid("03511d13-b55e-4d90-add0-3b891f771d80"), new Guid("52ff43df-86f8-49f2-b90d-ea832a37e610"), new Guid("d3113723-dee3-44a8-9500-ef40e0159569") },
                    { new Guid("03557ce7-1079-4e7b-9b3c-0dff311d0159"), new Guid("2b6a8d60-3c5f-4fbe-9cb1-6772b7e36afb"), new Guid("d3113723-dee3-44a8-9500-ef40e0159569") },
                    { new Guid("035bb9d9-ede7-40a2-99df-0198dd6e6ecb"), new Guid("b41d27f1-1c81-4159-aaa3-ab7cf41d265b"), new Guid("db3b8386-beb1-45df-b19f-8f4299f9a511") },
                    { new Guid("03d931fb-5ea3-44aa-bc97-48bd93133fd4"), new Guid("5e7c00c7-d0a1-41b1-9dd6-6d5eef899993"), new Guid("db3b8386-beb1-45df-b19f-8f4299f9a511") },
                    { new Guid("05709ba1-5568-4438-b379-0b7ca1096fa6"), new Guid("10781e9d-a38d-4029-a3d0-954843518924"), new Guid("12045f34-a4ad-4f85-8fcc-b368c05cdd80") },
                    { new Guid("0614ea6e-c17a-490f-aae8-994b1da8cbc1"), new Guid("2a9120c7-462d-430e-aa6e-384251468336"), new Guid("058d9135-d0e2-4763-9f18-40a4213cebd7") },
                    { new Guid("064d0fbf-d95c-4986-a92e-ae5c6df98060"), new Guid("2beda2e1-d9aa-42ef-831a-ef8fa730e72d"), new Guid("1fe25ecf-61d9-4f1e-b8b6-1eb0fc01333a") },
                    { new Guid("084e27a3-40b7-4858-8a3a-1d6a93993d9f"), new Guid("059555e3-86ef-4a81-bf58-5e650034d03d"), new Guid("8bafa452-5a48-4e6d-ac2f-af3b3001c86d") },
                    { new Guid("08606f1f-82a7-42ed-aa50-15bac38f0303"), new Guid("0503fb2e-9fe0-4c9c-98f1-048ec3e64643"), new Guid("15974b02-138d-46c2-861e-58447faa82eb") },
                    { new Guid("08ab7b3e-06cb-4c51-8683-aca840263f28"), new Guid("637452d1-38c4-4c80-a0c8-d86ee987f70e"), new Guid("045f5234-991b-4d1d-8da5-af3ee2dd3286") },
                    { new Guid("0924f62e-42fe-4a28-8561-580df27592bc"), new Guid("f57b0ba6-77ed-41a9-bcb8-bd5954e3b90a"), new Guid("384ebf7c-bd18-454c-84d4-808f8235a1ed") },
                    { new Guid("09931254-6dd3-4cdc-adb8-26a31d2d38c1"), new Guid("aa0e4eb6-2d57-4bc6-a8d7-a8aff8e97cdb"), new Guid("953b615a-ccd7-4d3c-9c7b-83e2063f8729") },
                    { new Guid("09d3373d-7831-442a-9697-776d292da404"), new Guid("9378afde-cd3f-4186-b03a-2ce93a7aa559"), new Guid("2f43c50e-bdbf-4d86-a48f-45e4305dbe81") },
                    { new Guid("0a44db6e-6e3b-4dfe-ae31-20494ac6a28a"), new Guid("96aee99f-b9f5-4a23-8085-a68991b03c80"), new Guid("d3113723-dee3-44a8-9500-ef40e0159569") },
                    { new Guid("0b138b54-b9ad-4afe-8058-1216ed75a3ba"), new Guid("b109772e-27ea-4e6a-96d4-d81467f27d90"), new Guid("953b615a-ccd7-4d3c-9c7b-83e2063f8729") },
                    { new Guid("0bfc2729-80a1-4286-9a24-32992108396a"), new Guid("10781e9d-a38d-4029-a3d0-954843518924"), new Guid("8bafa452-5a48-4e6d-ac2f-af3b3001c86d") },
                    { new Guid("0cc8c4b2-605b-47c3-a72b-a62585274739"), new Guid("8699fde6-6e02-4668-b678-cdc38d16673f"), new Guid("7c4accb0-3d7a-4b2d-9d40-8ead1853b3e4") },
                    { new Guid("0dfe3579-c234-4c61-ad6c-9207ce44951f"), new Guid("10781e9d-a38d-4029-a3d0-954843518924"), new Guid("1fe25ecf-61d9-4f1e-b8b6-1eb0fc01333a") },
                    { new Guid("0f7faa22-74c7-40ae-b693-81bc7bdbb01e"), new Guid("7d0ce67d-7883-4ea3-89fb-dae83e01eb11"), new Guid("d3113723-dee3-44a8-9500-ef40e0159569") },
                    { new Guid("0f9976cb-1b5c-40a3-be4b-b231bc817241"), new Guid("4d30da1c-70f7-435e-9534-a79cb70fc9ab"), new Guid("1fe25ecf-61d9-4f1e-b8b6-1eb0fc01333a") },
                    { new Guid("10a4b9c8-3382-447f-b5c5-2028d0c3681b"), new Guid("8a7df677-ef15-4d66-a25e-290dcf3bf0fd"), new Guid("1fe25ecf-61d9-4f1e-b8b6-1eb0fc01333a") },
                    { new Guid("122f013d-4eef-4272-a828-9731bba0f0e3"), new Guid("26ae8be6-a670-4824-93ed-32d3c4f002b4"), new Guid("953b615a-ccd7-4d3c-9c7b-83e2063f8729") },
                    { new Guid("1265bf90-fcfe-4282-9928-ff986249cfc2"), new Guid("0a3f8a6d-e611-4e84-8eb3-d6eb2c172d6c"), new Guid("8bafa452-5a48-4e6d-ac2f-af3b3001c86d") },
                    { new Guid("148f7894-8065-473d-8588-5b780e5d4170"), new Guid("440b376b-8add-4b08-8096-176bcc0e2451"), new Guid("1c942947-4cec-467b-b4a9-64625f78ec3a") },
                    { new Guid("14dda879-fc94-4cc3-a2d9-f9929bfed3c9"), new Guid("5ff5f1d7-d3fb-4f28-98a1-cb841bf038ba"), new Guid("a291e486-dcbb-4f7a-a0a2-b6eaba27923a") },
                    { new Guid("14f7a60f-7013-4fc8-a260-69d5b2e2a82a"), new Guid("abb05380-6529-4c21-9d3f-a1895f042da4"), new Guid("045f5234-991b-4d1d-8da5-af3ee2dd3286") },
                    { new Guid("1549796f-93d6-4d7d-9dbf-b1e18cb96a34"), new Guid("3393ca84-c374-455a-b8d9-888d16e17315"), new Guid("1c942947-4cec-467b-b4a9-64625f78ec3a") },
                    { new Guid("158d22fa-eba4-4e1f-9056-6deb78294b16"), new Guid("b109772e-27ea-4e6a-96d4-d81467f27d90"), new Guid("44c329c7-f791-4ef7-a84f-785ccf427427") },
                    { new Guid("162cf9ca-c91e-48aa-87a0-16c400cee1c6"), new Guid("b8b78e13-7868-45a5-85e9-cfb97e2bfd82"), new Guid("8bafa452-5a48-4e6d-ac2f-af3b3001c86d") },
                    { new Guid("1644d0be-4123-47d0-842f-25681cef95af"), new Guid("8e6a69f1-42a5-44c2-a226-e0a81c8429ea"), new Guid("045f5234-991b-4d1d-8da5-af3ee2dd3286") },
                    { new Guid("166d025d-04ea-462d-812a-e887faca9b11"), new Guid("170aa5e4-4322-4b43-bdfa-e73c4ee41724"), new Guid("d3113723-dee3-44a8-9500-ef40e0159569") },
                    { new Guid("18f3b564-0552-4e46-bc04-a6496307a61e"), new Guid("ca1db322-9c19-45a4-bd13-5ff5aabe8105"), new Guid("db3b8386-beb1-45df-b19f-8f4299f9a511") },
                    { new Guid("1a15acd9-14e8-44a3-b02a-4a3525acb3bd"), new Guid("49b637b3-f68f-42e7-b29e-1906e52b132e"), new Guid("684387d2-acb0-414c-bebc-d79a386fee0a") },
                    { new Guid("1a31df63-4a59-4eb8-97dc-a70beff3e78a"), new Guid("7cdfc11b-d421-46b4-b358-510d89bea70c"), new Guid("058d9135-d0e2-4763-9f18-40a4213cebd7") },
                    { new Guid("1a419f73-fd8c-4d67-a2d9-0ca4a04d9fc3"), new Guid("d0dcf0a7-f2ab-4df4-bf9f-6648d6cd9e3d"), new Guid("12045f34-a4ad-4f85-8fcc-b368c05cdd80") },
                    { new Guid("1a83739b-026d-4eef-86cb-0f2f0431d657"), new Guid("d0dcf0a7-f2ab-4df4-bf9f-6648d6cd9e3d"), new Guid("953b615a-ccd7-4d3c-9c7b-83e2063f8729") },
                    { new Guid("1b5d2509-aefc-4544-aa67-1fa50d4a07b3"), new Guid("71a44309-af9f-4414-b5ee-59f82a5d617a"), new Guid("7c4accb0-3d7a-4b2d-9d40-8ead1853b3e4") },
                    { new Guid("1b901ec5-e529-4d47-a86e-3fcb1bb44a2e"), new Guid("87eda7d8-0bc1-459f-80fa-f426523cc1dc"), new Guid("2e9b06c3-d649-4f78-b5a9-6e757ce2b406") },
                    { new Guid("1c1b9b88-2f9e-4560-a4ae-18f070faa2dc"), new Guid("464a03ed-e2da-4f7b-b233-035f92eeea60"), new Guid("2e9b06c3-d649-4f78-b5a9-6e757ce2b406") },
                    { new Guid("1c32a3b1-9d8a-4919-a0c6-a5a208dfa6ee"), new Guid("145344c8-4ba3-4e92-b4b8-2a4e446b2530"), new Guid("a291e486-dcbb-4f7a-a0a2-b6eaba27923a") },
                    { new Guid("1cb18df2-40f4-4984-8163-ff555280cf3e"), new Guid("7b61146c-11fb-41fc-8bf8-00b455348109"), new Guid("953b615a-ccd7-4d3c-9c7b-83e2063f8729") },
                    { new Guid("1cd961be-adbd-4639-8e5e-a7f734bfe298"), new Guid("abb05380-6529-4c21-9d3f-a1895f042da4"), new Guid("b6ff5ad8-5295-4e48-ae54-d18d683cee18") },
                    { new Guid("1d562a2f-051c-4753-9ec4-e487ca8c6d26"), new Guid("e49d4299-a053-48e4-ac05-6761e385edd4"), new Guid("1fe25ecf-61d9-4f1e-b8b6-1eb0fc01333a") },
                    { new Guid("1d5b6f32-6eef-42d6-90ca-02f3d36841e8"), new Guid("5ab7c84c-fc9f-41d8-8840-853bec4b1f56"), new Guid("b2d03918-cc9c-40e1-9f26-cc39a74dfb3b") },
                    { new Guid("1fb3c379-bbe7-4310-83e0-55aa9a2c9d17"), new Guid("ebc0863c-afd0-42eb-babf-93cbde85b3e0"), new Guid("058d9135-d0e2-4763-9f18-40a4213cebd7") },
                    { new Guid("2059ff78-02d4-4e8f-8bcc-e90fcdbd53d7"), new Guid("55eae726-586b-4357-b446-cf7f0b9a7a47"), new Guid("1c942947-4cec-467b-b4a9-64625f78ec3a") },
                    { new Guid("22005125-b479-44b9-a351-29f2a635f179"), new Guid("5ab7c84c-fc9f-41d8-8840-853bec4b1f56"), new Guid("684387d2-acb0-414c-bebc-d79a386fee0a") },
                    { new Guid("22b2ddeb-a67f-444e-ad7f-a484351f8186"), new Guid("ea40e4ab-2278-4b3d-ba08-6d9b321196fb"), new Guid("15974b02-138d-46c2-861e-58447faa82eb") },
                    { new Guid("2338cc67-93d6-477d-b9d5-08c2c4c44738"), new Guid("75c4bf57-849e-46d6-95ea-3fa604356ccb"), new Guid("1fe25ecf-61d9-4f1e-b8b6-1eb0fc01333a") },
                    { new Guid("23a63d74-8ce7-43b7-81af-eacb9ecf8311"), new Guid("aebb428b-c99b-4c89-9537-414a12d6f420"), new Guid("058d9135-d0e2-4763-9f18-40a4213cebd7") },
                    { new Guid("250c904e-1439-4ef2-9466-208bebcd9e02"), new Guid("49b637b3-f68f-42e7-b29e-1906e52b132e"), new Guid("d3113723-dee3-44a8-9500-ef40e0159569") },
                    { new Guid("26b72833-60b5-4683-9824-2a701fcd294f"), new Guid("e49d4299-a053-48e4-ac05-6761e385edd4"), new Guid("1fe25ecf-61d9-4f1e-b8b6-1eb0fc01333a") },
                    { new Guid("2769c03c-c436-4e6b-a6eb-850254f7de20"), new Guid("9baf2404-7a96-44c1-a228-9f415475b004"), new Guid("1fe25ecf-61d9-4f1e-b8b6-1eb0fc01333a") },
                    { new Guid("27fb5dba-7467-4d19-baeb-233dacbe8525"), new Guid("fa084b9b-55a5-4766-837b-f4dee2add91c"), new Guid("8bafa452-5a48-4e6d-ac2f-af3b3001c86d") },
                    { new Guid("2803d491-2349-4cc8-b104-9356bb1ff185"), new Guid("5b350f92-70d9-4797-a0c3-c59bfbedd5b9"), new Guid("15974b02-138d-46c2-861e-58447faa82eb") },
                    { new Guid("2843d1ff-79d4-438d-b6fa-c3388837cc2d"), new Guid("8699fde6-6e02-4668-b678-cdc38d16673f"), new Guid("1fe25ecf-61d9-4f1e-b8b6-1eb0fc01333a") },
                    { new Guid("2873bd9c-da7a-4ac7-b313-ec6836108ce1"), new Guid("c3d8abec-f174-4228-bd88-be7629132b0b"), new Guid("44c329c7-f791-4ef7-a84f-785ccf427427") },
                    { new Guid("295227f6-88e1-49d5-b68e-f143f5fddfbd"), new Guid("098fa3c3-d88b-49b2-9e37-a2bc2728b443"), new Guid("2e9b06c3-d649-4f78-b5a9-6e757ce2b406") },
                    { new Guid("29fa3692-8042-4c76-a8f8-5ef86071c886"), new Guid("3393ca84-c374-455a-b8d9-888d16e17315"), new Guid("684387d2-acb0-414c-bebc-d79a386fee0a") },
                    { new Guid("2b167b61-b352-4769-9564-021cbccf83a9"), new Guid("637452d1-38c4-4c80-a0c8-d86ee987f70e"), new Guid("b6ff5ad8-5295-4e48-ae54-d18d683cee18") },
                    { new Guid("2b4fc221-d84d-4488-851c-a63295cb0335"), new Guid("5a3afcfa-2691-4868-84b9-db7d461a5990"), new Guid("2f43c50e-bdbf-4d86-a48f-45e4305dbe81") },
                    { new Guid("2bbafb8c-2430-4884-8d3c-4d2fb5cbc1eb"), new Guid("145344c8-4ba3-4e92-b4b8-2a4e446b2530"), new Guid("384ebf7c-bd18-454c-84d4-808f8235a1ed") },
                    { new Guid("2d0a549a-f871-46c7-b7bc-a9bb30a11aa0"), new Guid("49b637b3-f68f-42e7-b29e-1906e52b132e"), new Guid("384ebf7c-bd18-454c-84d4-808f8235a1ed") },
                    { new Guid("2d9eab05-e018-4bf4-a1d9-baf79e7d60c9"), new Guid("474324f5-fd5a-4d23-81c7-b5b8b66d7136"), new Guid("058d9135-d0e2-4763-9f18-40a4213cebd7") },
                    { new Guid("2fa1d2fd-1cb3-41d5-be06-e0984c1dcb74"), new Guid("aa0e4eb6-2d57-4bc6-a8d7-a8aff8e97cdb"), new Guid("db3b8386-beb1-45df-b19f-8f4299f9a511") },
                    { new Guid("2ffb6007-c401-42d4-a6cc-925ab7093741"), new Guid("9378afde-cd3f-4186-b03a-2ce93a7aa559"), new Guid("44c329c7-f791-4ef7-a84f-785ccf427427") },
                    { new Guid("32fca7d5-3946-44a5-a048-b96b1d61ccef"), new Guid("8a7df677-ef15-4d66-a25e-290dcf3bf0fd"), new Guid("db3b8386-beb1-45df-b19f-8f4299f9a511") },
                    { new Guid("3321590a-33bf-43fa-a006-504eb6057864"), new Guid("18849703-41c1-40b2-98ff-dc9f7a01cbb0"), new Guid("2f43c50e-bdbf-4d86-a48f-45e4305dbe81") },
                    { new Guid("34541a31-bbec-44e8-9e33-564d504a9a74"), new Guid("2a124c1c-b7be-402c-aa46-d5cd95564dc9"), new Guid("12045f34-a4ad-4f85-8fcc-b368c05cdd80") },
                    { new Guid("352ffb5a-42c7-442b-803c-bcaaa32d83d4"), new Guid("e1038923-d63b-410f-a787-d7247d4cd1e5"), new Guid("684387d2-acb0-414c-bebc-d79a386fee0a") },
                    { new Guid("354ea457-9e6b-4e9e-acd6-7aedcf36e9fe"), new Guid("1b734894-4dbc-4386-bf9d-b86e62b5dc5e"), new Guid("1c942947-4cec-467b-b4a9-64625f78ec3a") },
                    { new Guid("356c6e4d-ec51-4bdf-b6f0-d85bac5afe72"), new Guid("7d0ce67d-7883-4ea3-89fb-dae83e01eb11"), new Guid("953b615a-ccd7-4d3c-9c7b-83e2063f8729") },
                    { new Guid("377fd826-b90f-4aea-991c-b6294cc5e8f0"), new Guid("119909d2-d664-40c8-95a0-3a104200c8ff"), new Guid("b6ff5ad8-5295-4e48-ae54-d18d683cee18") },
                    { new Guid("3845284e-81c4-4155-944e-c00ad0f2d206"), new Guid("92d48b28-ab30-4c72-9675-4270abee827e"), new Guid("953b615a-ccd7-4d3c-9c7b-83e2063f8729") },
                    { new Guid("3ac7ee72-dfa1-4749-b88e-2930c02b683f"), new Guid("a6358f74-1051-4dfa-8905-97d381125692"), new Guid("2f43c50e-bdbf-4d86-a48f-45e4305dbe81") },
                    { new Guid("3b2f230b-4f4f-420a-941b-ed8883502907"), new Guid("2a124c1c-b7be-402c-aa46-d5cd95564dc9"), new Guid("684387d2-acb0-414c-bebc-d79a386fee0a") },
                    { new Guid("3bdebf08-f49b-4c59-80a8-2ba7197b164b"), new Guid("7cdfc11b-d421-46b4-b358-510d89bea70c"), new Guid("2f43c50e-bdbf-4d86-a48f-45e4305dbe81") },
                    { new Guid("3c6fbe94-70a3-43a6-ab0f-e83aacdfef53"), new Guid("2a124c1c-b7be-402c-aa46-d5cd95564dc9"), new Guid("d3113723-dee3-44a8-9500-ef40e0159569") },
                    { new Guid("3db5c3bc-05b3-47a3-ba43-1d18c4795e6d"), new Guid("aae616ae-efc9-4373-a34e-39f95947bef6"), new Guid("1fe25ecf-61d9-4f1e-b8b6-1eb0fc01333a") },
                    { new Guid("4052f13d-6ee5-4c34-9d9e-0da4b466333f"), new Guid("098fa3c3-d88b-49b2-9e37-a2bc2728b443"), new Guid("db3b8386-beb1-45df-b19f-8f4299f9a511") },
                    { new Guid("40776424-d70c-4ee7-a437-9f0cac2ad36c"), new Guid("0503fb2e-9fe0-4c9c-98f1-048ec3e64643"), new Guid("1fe25ecf-61d9-4f1e-b8b6-1eb0fc01333a") },
                    { new Guid("41246e59-7b47-42ac-9e17-0637d9707ed2"), new Guid("28cc2f37-4a21-4648-9ec4-fb9939e9b3ce"), new Guid("953b615a-ccd7-4d3c-9c7b-83e2063f8729") },
                    { new Guid("4134c602-7cb0-479f-88e7-278b594e0d7f"), new Guid("1e36aa36-b3d7-4981-be5e-4fc9624d1729"), new Guid("44c329c7-f791-4ef7-a84f-785ccf427427") },
                    { new Guid("4358c6f7-62d2-44b8-8955-06e2fafd1505"), new Guid("2beda2e1-d9aa-42ef-831a-ef8fa730e72d"), new Guid("44c329c7-f791-4ef7-a84f-785ccf427427") },
                    { new Guid("43c41d6f-e22a-41aa-9951-9fab6c71b404"), new Guid("75c4bf57-849e-46d6-95ea-3fa604356ccb"), new Guid("7c4accb0-3d7a-4b2d-9d40-8ead1853b3e4") },
                    { new Guid("45e251c2-5428-4f57-8793-cf0b07a30e0f"), new Guid("edbc1f03-de75-4830-a960-ed2561b39a48"), new Guid("b6ff5ad8-5295-4e48-ae54-d18d683cee18") },
                    { new Guid("45e55ae4-a497-4a53-86d5-2a5ed6e02b39"), new Guid("56ed86a3-d97f-43f7-9548-7960670c4995"), new Guid("15974b02-138d-46c2-861e-58447faa82eb") },
                    { new Guid("47790557-25d4-4771-bedc-056da521ce36"), new Guid("9c233746-048d-4d08-bb0b-6e4cda4d0639"), new Guid("d3113723-dee3-44a8-9500-ef40e0159569") },
                    { new Guid("47c4d3b7-e7e2-4344-8f4a-5a51247cc085"), new Guid("3393ca84-c374-455a-b8d9-888d16e17315"), new Guid("15974b02-138d-46c2-861e-58447faa82eb") },
                    { new Guid("499c51cb-8cb8-4e01-ba57-649c5c6d74cb"), new Guid("7fc66a1c-f4c8-4708-875f-fac08ed00bda"), new Guid("a291e486-dcbb-4f7a-a0a2-b6eaba27923a") },
                    { new Guid("4b655747-00bc-479a-899a-b1d10dec2714"), new Guid("1b734894-4dbc-4386-bf9d-b86e62b5dc5e"), new Guid("a291e486-dcbb-4f7a-a0a2-b6eaba27923a") },
                    { new Guid("4b9d1005-8aa4-4cbd-a60a-dd02274ac316"), new Guid("098fa3c3-d88b-49b2-9e37-a2bc2728b443"), new Guid("7c4accb0-3d7a-4b2d-9d40-8ead1853b3e4") },
                    { new Guid("4c0a63d9-e0c1-4a09-9f04-afbef1b7601a"), new Guid("f8f93377-34b8-462b-b57d-61082c654832"), new Guid("db3b8386-beb1-45df-b19f-8f4299f9a511") },
                    { new Guid("4d82e408-ff7e-4e3d-a671-5b2b54fb2983"), new Guid("ea40e4ab-2278-4b3d-ba08-6d9b321196fb"), new Guid("15974b02-138d-46c2-861e-58447faa82eb") },
                    { new Guid("4e1e2d39-bbe6-4e18-afe2-f48aae736efe"), new Guid("2b6a8d60-3c5f-4fbe-9cb1-6772b7e36afb"), new Guid("b6ff5ad8-5295-4e48-ae54-d18d683cee18") },
                    { new Guid("4e4c2686-3ca1-422d-9512-ecee28f00644"), new Guid("7770fbcc-96ea-4d03-8323-399eac1deb6e"), new Guid("b6ff5ad8-5295-4e48-ae54-d18d683cee18") },
                    { new Guid("4e8ce494-0c7b-4ba4-81ec-a343251a1bce"), new Guid("059555e3-86ef-4a81-bf58-5e650034d03d"), new Guid("058d9135-d0e2-4763-9f18-40a4213cebd7") },
                    { new Guid("4fbf5fce-38da-45b0-9472-a885618fb113"), new Guid("5ab7c84c-fc9f-41d8-8840-853bec4b1f56"), new Guid("d3113723-dee3-44a8-9500-ef40e0159569") },
                    { new Guid("50e941ae-2be9-4ac8-b494-e31e62cdeb15"), new Guid("5ff5f1d7-d3fb-4f28-98a1-cb841bf038ba"), new Guid("953b615a-ccd7-4d3c-9c7b-83e2063f8729") },
                    { new Guid("524511c5-8b3a-4e4c-8891-9ece3971da24"), new Guid("a7b945b8-5867-44e1-9d39-a1eb93c87817"), new Guid("2e9b06c3-d649-4f78-b5a9-6e757ce2b406") },
                    { new Guid("55463d25-0c0a-47e5-8422-0f059a8a5b85"), new Guid("7770fbcc-96ea-4d03-8323-399eac1deb6e"), new Guid("045f5234-991b-4d1d-8da5-af3ee2dd3286") },
                    { new Guid("557163c6-d348-4de0-bb7b-70e97e9f98aa"), new Guid("9baf2404-7a96-44c1-a228-9f415475b004"), new Guid("b2d03918-cc9c-40e1-9f26-cc39a74dfb3b") },
                    { new Guid("569d5cd0-43a0-4359-b16c-7aee532fda18"), new Guid("474324f5-fd5a-4d23-81c7-b5b8b66d7136"), new Guid("b2d03918-cc9c-40e1-9f26-cc39a74dfb3b") },
                    { new Guid("578afd84-c025-499b-bcb1-e21703ed79ec"), new Guid("0a3f8a6d-e611-4e84-8eb3-d6eb2c172d6c"), new Guid("7c4accb0-3d7a-4b2d-9d40-8ead1853b3e4") },
                    { new Guid("57bb418d-57ec-4b14-9b2d-0acf9c90e8b1"), new Guid("f57b0ba6-77ed-41a9-bcb8-bd5954e3b90a"), new Guid("953b615a-ccd7-4d3c-9c7b-83e2063f8729") },
                    { new Guid("58c29997-77d4-44d2-b77d-b4cbc821e05e"), new Guid("84495437-1312-4d2a-8849-46371c080efb"), new Guid("8bafa452-5a48-4e6d-ac2f-af3b3001c86d") },
                    { new Guid("5a24b953-cfb8-4c46-8d11-1489d266f969"), new Guid("398b573a-e90b-4d4e-b98c-f7b55a1eb9d1"), new Guid("7c4accb0-3d7a-4b2d-9d40-8ead1853b3e4") },
                    { new Guid("5d930b1f-f414-496d-b6d5-9fdae0f07ad3"), new Guid("cf0fecc3-095e-4e29-85ee-b6d21824f01c"), new Guid("2f43c50e-bdbf-4d86-a48f-45e4305dbe81") },
                    { new Guid("5f7873e5-a2b1-4ad0-bdbc-83ce96401c60"), new Guid("fa084b9b-55a5-4766-837b-f4dee2add91c"), new Guid("2f43c50e-bdbf-4d86-a48f-45e4305dbe81") },
                    { new Guid("5ffc3b7e-493e-4096-823e-b7fa44a7d2da"), new Guid("a7b945b8-5867-44e1-9d39-a1eb93c87817"), new Guid("a291e486-dcbb-4f7a-a0a2-b6eaba27923a") },
                    { new Guid("600707d5-43cd-4428-af7d-72ee88259d1a"), new Guid("e505b018-fead-41e1-9776-5163c9af3bf6"), new Guid("1fe25ecf-61d9-4f1e-b8b6-1eb0fc01333a") },
                    { new Guid("609e932b-8df1-4640-954f-797bcc35e1cb"), new Guid("a6358f74-1051-4dfa-8905-97d381125692"), new Guid("045f5234-991b-4d1d-8da5-af3ee2dd3286") },
                    { new Guid("60bdadc4-5558-4818-b1ef-cf1ea18b9b7c"), new Guid("a0bb695a-f979-4e8e-818a-29fa2d081db9"), new Guid("15974b02-138d-46c2-861e-58447faa82eb") },
                    { new Guid("63bce694-06f9-4dfd-a657-5cadc30d614c"), new Guid("f35ea29f-5753-41f1-9419-91ef94cfb9e5"), new Guid("953b615a-ccd7-4d3c-9c7b-83e2063f8729") },
                    { new Guid("649d2c87-9e65-46a5-9c23-def1ccd2f4b7"), new Guid("7b61146c-11fb-41fc-8bf8-00b455348109"), new Guid("953b615a-ccd7-4d3c-9c7b-83e2063f8729") },
                    { new Guid("6519469d-3452-421c-8c99-b67c95402b7c"), new Guid("ebc0863c-afd0-42eb-babf-93cbde85b3e0"), new Guid("1c942947-4cec-467b-b4a9-64625f78ec3a") },
                    { new Guid("670297d5-b6ef-43db-a6c2-d63f0d90d27d"), new Guid("84495437-1312-4d2a-8849-46371c080efb"), new Guid("b2d03918-cc9c-40e1-9f26-cc39a74dfb3b") },
                    { new Guid("672579f1-dc20-4363-bde4-cb914e71099d"), new Guid("ea40e4ab-2278-4b3d-ba08-6d9b321196fb"), new Guid("1c942947-4cec-467b-b4a9-64625f78ec3a") },
                    { new Guid("6855b14e-62f6-492d-b64b-40fd65212281"), new Guid("7fc66a1c-f4c8-4708-875f-fac08ed00bda"), new Guid("44c329c7-f791-4ef7-a84f-785ccf427427") },
                    { new Guid("68756b15-9e8d-46c4-bb0f-1979313d01ca"), new Guid("5a3afcfa-2691-4868-84b9-db7d461a5990"), new Guid("a291e486-dcbb-4f7a-a0a2-b6eaba27923a") },
                    { new Guid("6984fdee-bf5b-4a5e-8d64-fb4e983dcc7a"), new Guid("119909d2-d664-40c8-95a0-3a104200c8ff"), new Guid("15974b02-138d-46c2-861e-58447faa82eb") },
                    { new Guid("69aa8f34-7ac6-479f-bff0-4c1b5ac3bd42"), new Guid("7fc66a1c-f4c8-4708-875f-fac08ed00bda"), new Guid("384ebf7c-bd18-454c-84d4-808f8235a1ed") },
                    { new Guid("6b3eb1dd-fbb7-45f7-9815-356d1b7cf3c5"), new Guid("2b6a8d60-3c5f-4fbe-9cb1-6772b7e36afb"), new Guid("058d9135-d0e2-4763-9f18-40a4213cebd7") },
                    { new Guid("6bdad145-bc45-4c60-8682-9c0c7e836e6e"), new Guid("cf5057f3-d910-4499-b571-e39c8d4d7737"), new Guid("7c4accb0-3d7a-4b2d-9d40-8ead1853b3e4") },
                    { new Guid("6c812672-1baa-4975-931e-5bc5e7afd006"), new Guid("4b5fe238-692a-441d-92c4-b7adfd464d02"), new Guid("b2d03918-cc9c-40e1-9f26-cc39a74dfb3b") },
                    { new Guid("6d12774d-e83c-4625-b270-6d1a8eb69755"), new Guid("05fa4454-8956-4d0b-8ca5-0fbd57900583"), new Guid("2e9b06c3-d649-4f78-b5a9-6e757ce2b406") },
                    { new Guid("6e531c7a-2cf2-4d00-b94e-ace936d41042"), new Guid("a1d38323-b870-4c9f-9ebe-a6dca6f5fa50"), new Guid("44c329c7-f791-4ef7-a84f-785ccf427427") },
                    { new Guid("6e79d3f8-ee2a-421b-a029-a136017c3608"), new Guid("abb05380-6529-4c21-9d3f-a1895f042da4"), new Guid("058d9135-d0e2-4763-9f18-40a4213cebd7") },
                    { new Guid("6ef75c15-0a4d-4084-9349-e69b6ec2eae6"), new Guid("2b62fd2a-5684-43bd-a189-25e385effd2a"), new Guid("384ebf7c-bd18-454c-84d4-808f8235a1ed") },
                    { new Guid("7031e6b3-c0a8-42b5-8a90-0be51bfee06c"), new Guid("145344c8-4ba3-4e92-b4b8-2a4e446b2530"), new Guid("7c4accb0-3d7a-4b2d-9d40-8ead1853b3e4") },
                    { new Guid("7067fb24-67f7-4f9b-8669-7c24b6fceb82"), new Guid("bc097847-edf6-4766-8f67-765cb3f1e0a7"), new Guid("a291e486-dcbb-4f7a-a0a2-b6eaba27923a") },
                    { new Guid("71a44b12-f6d6-4068-8dce-98d8cfda4e03"), new Guid("cf0fecc3-095e-4e29-85ee-b6d21824f01c"), new Guid("d3113723-dee3-44a8-9500-ef40e0159569") },
                    { new Guid("7250a950-7d89-489e-b6fe-9d6b5bd0a9d4"), new Guid("e49d4299-a053-48e4-ac05-6761e385edd4"), new Guid("12045f34-a4ad-4f85-8fcc-b368c05cdd80") },
                    { new Guid("72bb5f04-5101-4b8e-91d5-c85bc4ed3bc6"), new Guid("440b376b-8add-4b08-8096-176bcc0e2451"), new Guid("15974b02-138d-46c2-861e-58447faa82eb") },
                    { new Guid("7367f1dc-a129-4f37-b9aa-1505f0bd43c8"), new Guid("4b5fe238-692a-441d-92c4-b7adfd464d02"), new Guid("2f43c50e-bdbf-4d86-a48f-45e4305dbe81") },
                    { new Guid("73d3dac9-c116-4516-8764-336bcdbe654d"), new Guid("7901ae91-3642-446a-9325-515c29875ce5"), new Guid("a291e486-dcbb-4f7a-a0a2-b6eaba27923a") },
                    { new Guid("74d87a35-32dc-45ff-9397-7d6a43c41008"), new Guid("170aa5e4-4322-4b43-bdfa-e73c4ee41724"), new Guid("2e9b06c3-d649-4f78-b5a9-6e757ce2b406") },
                    { new Guid("74e32076-c0f8-42cd-8912-21ac9646fbcb"), new Guid("c9ba1ff4-b7e6-4f75-ba9a-03a30cf5d721"), new Guid("684387d2-acb0-414c-bebc-d79a386fee0a") },
                    { new Guid("76b7ca53-91a8-4d0a-a380-534134e3e9b2"), new Guid("92d48b28-ab30-4c72-9675-4270abee827e"), new Guid("7c4accb0-3d7a-4b2d-9d40-8ead1853b3e4") },
                    { new Guid("76d44945-45f5-4621-9bac-ee50855aa479"), new Guid("a1d38323-b870-4c9f-9ebe-a6dca6f5fa50"), new Guid("1c942947-4cec-467b-b4a9-64625f78ec3a") },
                    { new Guid("77d41165-0ad4-431b-aa64-993cc646c0e7"), new Guid("edbc1f03-de75-4830-a960-ed2561b39a48"), new Guid("8bafa452-5a48-4e6d-ac2f-af3b3001c86d") },
                    { new Guid("786d437f-61a6-4f74-bc43-9a3c5ec17439"), new Guid("e1073991-e43f-44e6-af9a-1a67949017b6"), new Guid("44c329c7-f791-4ef7-a84f-785ccf427427") },
                    { new Guid("789383f6-7675-44f7-a59b-0e6987b4ea72"), new Guid("8e6a69f1-42a5-44c2-a226-e0a81c8429ea"), new Guid("2f43c50e-bdbf-4d86-a48f-45e4305dbe81") },
                    { new Guid("7896ccd1-65be-4c13-8fce-934e620d0d57"), new Guid("7d0ce67d-7883-4ea3-89fb-dae83e01eb11"), new Guid("045f5234-991b-4d1d-8da5-af3ee2dd3286") },
                    { new Guid("792350eb-6993-4042-9369-6d038c1be193"), new Guid("2beda2e1-d9aa-42ef-831a-ef8fa730e72d"), new Guid("953b615a-ccd7-4d3c-9c7b-83e2063f8729") },
                    { new Guid("79c2c4ab-8806-4927-8421-2705e13db617"), new Guid("f35ea29f-5753-41f1-9419-91ef94cfb9e5"), new Guid("2e9b06c3-d649-4f78-b5a9-6e757ce2b406") },
                    { new Guid("7ad5620a-17a3-490f-8224-eeb34de4d086"), new Guid("677521a5-b4a7-434b-994e-8495c7579762"), new Guid("12045f34-a4ad-4f85-8fcc-b368c05cdd80") },
                    { new Guid("7c152d4f-8f22-4cda-86ef-21d335c88186"), new Guid("d648476d-d083-4f15-a6a8-4f3e1e519c5a"), new Guid("7c4accb0-3d7a-4b2d-9d40-8ead1853b3e4") },
                    { new Guid("7c97a02a-a838-44b2-88b2-6fd15098d577"), new Guid("8e6a69f1-42a5-44c2-a226-e0a81c8429ea"), new Guid("15974b02-138d-46c2-861e-58447faa82eb") },
                    { new Guid("7ca683a6-0b00-4e49-9883-134cb1e455bd"), new Guid("b8aa9c89-7b43-4e6e-bb90-cd4e7ef19178"), new Guid("7c4accb0-3d7a-4b2d-9d40-8ead1853b3e4") },
                    { new Guid("7d9a1cd0-b92f-47b1-bc8f-3eb13de317cc"), new Guid("677521a5-b4a7-434b-994e-8495c7579762"), new Guid("8bafa452-5a48-4e6d-ac2f-af3b3001c86d") },
                    { new Guid("80aaa463-863d-4b79-86e3-ca1c56435477"), new Guid("0ff62f50-6296-4220-8723-80335cbf6500"), new Guid("8bafa452-5a48-4e6d-ac2f-af3b3001c86d") },
                    { new Guid("81ef368f-0899-49b2-b23b-9c25412923d9"), new Guid("f35ea29f-5753-41f1-9419-91ef94cfb9e5"), new Guid("058d9135-d0e2-4763-9f18-40a4213cebd7") },
                    { new Guid("8275c514-a3d3-483b-997d-c43e18673787"), new Guid("7419c10d-ed3d-4c35-9384-62568f33e97a"), new Guid("384ebf7c-bd18-454c-84d4-808f8235a1ed") },
                    { new Guid("827ae99d-bab0-472f-a95a-ca9751ce62e3"), new Guid("1e36aa36-b3d7-4981-be5e-4fc9624d1729"), new Guid("384ebf7c-bd18-454c-84d4-808f8235a1ed") },
                    { new Guid("83565c63-813d-478e-bb87-ecf30f4064fb"), new Guid("5e7c00c7-d0a1-41b1-9dd6-6d5eef899993"), new Guid("8bafa452-5a48-4e6d-ac2f-af3b3001c86d") },
                    { new Guid("83b51c48-dd78-4a13-a227-9b729a177b63"), new Guid("a6358f74-1051-4dfa-8905-97d381125692"), new Guid("7c4accb0-3d7a-4b2d-9d40-8ead1853b3e4") },
                    { new Guid("83dce356-31c7-4c6e-9837-8f1299958116"), new Guid("e505b018-fead-41e1-9776-5163c9af3bf6"), new Guid("7c4accb0-3d7a-4b2d-9d40-8ead1853b3e4") },
                    { new Guid("85180ab3-313a-4897-a1e4-59611504af50"), new Guid("7419c10d-ed3d-4c35-9384-62568f33e97a"), new Guid("a291e486-dcbb-4f7a-a0a2-b6eaba27923a") },
                    { new Guid("873023e8-a533-411e-84f7-ba449e421d56"), new Guid("464a03ed-e2da-4f7b-b233-035f92eeea60"), new Guid("1c942947-4cec-467b-b4a9-64625f78ec3a") },
                    { new Guid("895671f4-0999-4d81-b038-6820f1c6d010"), new Guid("d648476d-d083-4f15-a6a8-4f3e1e519c5a"), new Guid("2f43c50e-bdbf-4d86-a48f-45e4305dbe81") },
                    { new Guid("89ca983b-77e4-466b-aa57-f924ae9ded82"), new Guid("a524554a-fb05-4c4a-a69a-70c0c444bf33"), new Guid("684387d2-acb0-414c-bebc-d79a386fee0a") },
                    { new Guid("89f536dd-974c-4724-9cf6-5359c2038a4b"), new Guid("ebc0863c-afd0-42eb-babf-93cbde85b3e0"), new Guid("15974b02-138d-46c2-861e-58447faa82eb") },
                    { new Guid("8b4ffb96-fce6-41f4-afb1-69414474baf7"), new Guid("0a3f8a6d-e611-4e84-8eb3-d6eb2c172d6c"), new Guid("1c942947-4cec-467b-b4a9-64625f78ec3a") },
                    { new Guid("8b620117-d79f-45c3-bf39-77572eaba270"), new Guid("13203021-b7b2-49f2-8949-d3b1f0461cc6"), new Guid("15974b02-138d-46c2-861e-58447faa82eb") },
                    { new Guid("8c036cc9-a5bc-4cba-9fc2-ccf3d51dd3fd"), new Guid("f8f93377-34b8-462b-b57d-61082c654832"), new Guid("384ebf7c-bd18-454c-84d4-808f8235a1ed") },
                    { new Guid("8c232d75-24ca-4621-9646-02228c94eb24"), new Guid("464a03ed-e2da-4f7b-b233-035f92eeea60"), new Guid("12045f34-a4ad-4f85-8fcc-b368c05cdd80") },
                    { new Guid("8c296a37-7175-472c-b629-8c11514d6e47"), new Guid("b109772e-27ea-4e6a-96d4-d81467f27d90"), new Guid("058d9135-d0e2-4763-9f18-40a4213cebd7") },
                    { new Guid("8caaedbd-b326-443a-9480-e8d544887168"), new Guid("56ed86a3-d97f-43f7-9548-7960670c4995"), new Guid("953b615a-ccd7-4d3c-9c7b-83e2063f8729") },
                    { new Guid("8f80b24d-677f-4203-9a42-7c635a4f905f"), new Guid("b8b78e13-7868-45a5-85e9-cfb97e2bfd82"), new Guid("684387d2-acb0-414c-bebc-d79a386fee0a") },
                    { new Guid("910b983d-3089-4418-88f2-66e3fef82cd6"), new Guid("aebb428b-c99b-4c89-9537-414a12d6f420"), new Guid("1c942947-4cec-467b-b4a9-64625f78ec3a") },
                    { new Guid("91371253-f155-4c6f-becb-bbadf7dbde67"), new Guid("2b62fd2a-5684-43bd-a189-25e385effd2a"), new Guid("684387d2-acb0-414c-bebc-d79a386fee0a") },
                    { new Guid("920c0fce-9157-43b9-b50d-3d363a89a712"), new Guid("aae616ae-efc9-4373-a34e-39f95947bef6"), new Guid("684387d2-acb0-414c-bebc-d79a386fee0a") },
                    { new Guid("93ec977c-aed7-4584-a2e5-8f3af749374a"), new Guid("119909d2-d664-40c8-95a0-3a104200c8ff"), new Guid("1fe25ecf-61d9-4f1e-b8b6-1eb0fc01333a") },
                    { new Guid("953b4317-3f17-4cf0-a2ca-ba26e09057a1"), new Guid("28cc2f37-4a21-4648-9ec4-fb9939e9b3ce"), new Guid("12045f34-a4ad-4f85-8fcc-b368c05cdd80") },
                    { new Guid("9562e3bf-a2d0-4ee5-873c-6b63a8a1023e"), new Guid("13203021-b7b2-49f2-8949-d3b1f0461cc6"), new Guid("db3b8386-beb1-45df-b19f-8f4299f9a511") },
                    { new Guid("983ee90c-fb7f-4efb-9807-6b1d1cd04719"), new Guid("05fa4454-8956-4d0b-8ca5-0fbd57900583"), new Guid("db3b8386-beb1-45df-b19f-8f4299f9a511") },
                    { new Guid("986e109d-dd9d-46ff-9f60-ab56a1f92914"), new Guid("87eda7d8-0bc1-459f-80fa-f426523cc1dc"), new Guid("a291e486-dcbb-4f7a-a0a2-b6eaba27923a") },
                    { new Guid("98b0b1a1-31b7-40b8-89c5-a6ec8a3c95c4"), new Guid("84495437-1312-4d2a-8849-46371c080efb"), new Guid("db3b8386-beb1-45df-b19f-8f4299f9a511") },
                    { new Guid("98d9f49a-26a5-4cca-8817-45fe53b037e9"), new Guid("7770fbcc-96ea-4d03-8323-399eac1deb6e"), new Guid("15974b02-138d-46c2-861e-58447faa82eb") },
                    { new Guid("9a27ae12-037f-42e8-8fad-02aa7346a9e6"), new Guid("aae616ae-efc9-4373-a34e-39f95947bef6"), new Guid("045f5234-991b-4d1d-8da5-af3ee2dd3286") },
                    { new Guid("9bb4dda9-491e-4620-97bf-1370a72638a7"), new Guid("cf0fecc3-095e-4e29-85ee-b6d21824f01c"), new Guid("7c4accb0-3d7a-4b2d-9d40-8ead1853b3e4") },
                    { new Guid("9bdd8767-5ecb-4014-a8b6-f9feeabea04c"), new Guid("f8f93377-34b8-462b-b57d-61082c654832"), new Guid("8bafa452-5a48-4e6d-ac2f-af3b3001c86d") },
                    { new Guid("9c73edd2-47a2-4a52-a4ac-07ee98ee12da"), new Guid("4d30da1c-70f7-435e-9534-a79cb70fc9ab"), new Guid("b2d03918-cc9c-40e1-9f26-cc39a74dfb3b") },
                    { new Guid("9caa897b-5d56-484f-a77a-fac982cf683b"), new Guid("05fa4454-8956-4d0b-8ca5-0fbd57900583"), new Guid("b2d03918-cc9c-40e1-9f26-cc39a74dfb3b") },
                    { new Guid("9cb69f64-eafe-42fd-9256-421b8c45f1bc"), new Guid("637452d1-38c4-4c80-a0c8-d86ee987f70e"), new Guid("953b615a-ccd7-4d3c-9c7b-83e2063f8729") },
                    { new Guid("9d12035f-abd5-4698-9c31-d38d5558e054"), new Guid("e1073991-e43f-44e6-af9a-1a67949017b6"), new Guid("684387d2-acb0-414c-bebc-d79a386fee0a") },
                    { new Guid("9e45f7a5-bbff-4027-840b-f99e81700555"), new Guid("73b3d0c5-b3c8-45e6-a275-a2026cdeae52"), new Guid("2f43c50e-bdbf-4d86-a48f-45e4305dbe81") },
                    { new Guid("9e8439ac-7f7c-4021-aa69-812e1028a8d9"), new Guid("1e36aa36-b3d7-4981-be5e-4fc9624d1729"), new Guid("44c329c7-f791-4ef7-a84f-785ccf427427") },
                    { new Guid("a1c5ceb0-6508-4b1a-8c9f-4f8866b1c4bc"), new Guid("dc077741-16d9-4e1f-9eaf-4ee04e9b22d2"), new Guid("7c4accb0-3d7a-4b2d-9d40-8ead1853b3e4") },
                    { new Guid("a1fdcd05-957c-483b-ba9c-a4b64a679de0"), new Guid("c3d8abec-f174-4228-bd88-be7629132b0b"), new Guid("12045f34-a4ad-4f85-8fcc-b368c05cdd80") },
                    { new Guid("a4012123-5224-497d-a433-bd31a8f65327"), new Guid("9f4f60b5-01ad-4f5b-9c52-86d170c2c895"), new Guid("384ebf7c-bd18-454c-84d4-808f8235a1ed") },
                    { new Guid("a42972f8-f417-4739-8176-6d22c310e2f6"), new Guid("c1f2f777-dc87-4dc0-a47d-b0efe742bc4a"), new Guid("8bafa452-5a48-4e6d-ac2f-af3b3001c86d") },
                    { new Guid("a47096a5-2ff4-4ef2-9fd6-87b678dc7983"), new Guid("059555e3-86ef-4a81-bf58-5e650034d03d"), new Guid("384ebf7c-bd18-454c-84d4-808f8235a1ed") },
                    { new Guid("a5392afd-f2e8-4e6c-bbfb-fbc00465abc7"), new Guid("98c2f040-4f88-4e6d-b91a-7e3a3b033bd0"), new Guid("db3b8386-beb1-45df-b19f-8f4299f9a511") },
                    { new Guid("a552b519-f905-4995-b113-16c7bc6dba1f"), new Guid("52ff43df-86f8-49f2-b90d-ea832a37e610"), new Guid("d3113723-dee3-44a8-9500-ef40e0159569") },
                    { new Guid("a5c6a55b-ef81-4535-aacb-813f4cbde7a5"), new Guid("7cdfc11b-d421-46b4-b358-510d89bea70c"), new Guid("b2d03918-cc9c-40e1-9f26-cc39a74dfb3b") },
                    { new Guid("a64f2ca5-e31f-48ce-a060-6edb70b8274f"), new Guid("2a9120c7-462d-430e-aa6e-384251468336"), new Guid("db3b8386-beb1-45df-b19f-8f4299f9a511") },
                    { new Guid("a7278561-fba7-4bd7-857c-6a85bb696df9"), new Guid("96aee99f-b9f5-4a23-8085-a68991b03c80"), new Guid("a291e486-dcbb-4f7a-a0a2-b6eaba27923a") },
                    { new Guid("a73d8b00-ea73-4cf4-964d-8bbcd67a1ead"), new Guid("9638bbc9-5293-452e-a7cd-ce90433f7133"), new Guid("44c329c7-f791-4ef7-a84f-785ccf427427") },
                    { new Guid("a755059e-0202-4667-87f4-0333cb33d7dc"), new Guid("aa0e4eb6-2d57-4bc6-a8d7-a8aff8e97cdb"), new Guid("058d9135-d0e2-4763-9f18-40a4213cebd7") },
                    { new Guid("a7636519-a902-49ab-9cf1-021fe5277304"), new Guid("71a44309-af9f-4414-b5ee-59f82a5d617a"), new Guid("b2d03918-cc9c-40e1-9f26-cc39a74dfb3b") },
                    { new Guid("a8a5d480-7385-48bc-871e-3154f3eeb2a1"), new Guid("9638bbc9-5293-452e-a7cd-ce90433f7133"), new Guid("b2d03918-cc9c-40e1-9f26-cc39a74dfb3b") },
                    { new Guid("a9da9afd-a7f3-4722-93db-f8af15b72e90"), new Guid("55eae726-586b-4357-b446-cf7f0b9a7a47"), new Guid("a291e486-dcbb-4f7a-a0a2-b6eaba27923a") },
                    { new Guid("a9de4b03-8a67-431b-8324-e8f89549739e"), new Guid("26ae8be6-a670-4824-93ed-32d3c4f002b4"), new Guid("db3b8386-beb1-45df-b19f-8f4299f9a511") },
                    { new Guid("ab149b3d-9466-4579-bc90-f643024a60a3"), new Guid("677521a5-b4a7-434b-994e-8495c7579762"), new Guid("b6ff5ad8-5295-4e48-ae54-d18d683cee18") },
                    { new Guid("abd62278-b1ca-4ec8-a6a1-6a5711bb7043"), new Guid("5e7c00c7-d0a1-41b1-9dd6-6d5eef899993"), new Guid("953b615a-ccd7-4d3c-9c7b-83e2063f8729") },
                    { new Guid("acd5f126-6827-4fce-adbc-bf8367021724"), new Guid("9f4f60b5-01ad-4f5b-9c52-86d170c2c895"), new Guid("12045f34-a4ad-4f85-8fcc-b368c05cdd80") },
                    { new Guid("ad43d2e9-85ca-4865-b08d-b05f3856e418"), new Guid("2b62fd2a-5684-43bd-a189-25e385effd2a"), new Guid("a291e486-dcbb-4f7a-a0a2-b6eaba27923a") },
                    { new Guid("aea3daec-1ee4-4041-8b79-a7f807820a36"), new Guid("440b376b-8add-4b08-8096-176bcc0e2451"), new Guid("15974b02-138d-46c2-861e-58447faa82eb") },
                    { new Guid("af088f78-b070-45d3-a92c-83bb07031a2e"), new Guid("5b350f92-70d9-4797-a0c3-c59bfbedd5b9"), new Guid("44c329c7-f791-4ef7-a84f-785ccf427427") },
                    { new Guid("af5bc843-c814-4277-9b4f-99268f6e7334"), new Guid("9c233746-048d-4d08-bb0b-6e4cda4d0639"), new Guid("2f43c50e-bdbf-4d86-a48f-45e4305dbe81") },
                    { new Guid("afb5e653-7a35-4362-a753-d68d60c1e3c5"), new Guid("75c4bf57-849e-46d6-95ea-3fa604356ccb"), new Guid("d3113723-dee3-44a8-9500-ef40e0159569") },
                    { new Guid("b0b73433-f15a-4149-939e-ffbdc9b365e6"), new Guid("d648476d-d083-4f15-a6a8-4f3e1e519c5a"), new Guid("44c329c7-f791-4ef7-a84f-785ccf427427") },
                    { new Guid("b1a70a58-f1ed-4ca6-af18-50da70c08562"), new Guid("28cc2f37-4a21-4648-9ec4-fb9939e9b3ce"), new Guid("15974b02-138d-46c2-861e-58447faa82eb") },
                    { new Guid("b3e339cc-9ac7-48e2-9446-39e312c612ab"), new Guid("b8aa9c89-7b43-4e6e-bb90-cd4e7ef19178"), new Guid("2f43c50e-bdbf-4d86-a48f-45e4305dbe81") },
                    { new Guid("b4d14e8c-0b48-4de5-8449-a45a01be6472"), new Guid("c9ba1ff4-b7e6-4f75-ba9a-03a30cf5d721"), new Guid("953b615a-ccd7-4d3c-9c7b-83e2063f8729") },
                    { new Guid("b596a74b-f0ca-406b-a7f8-d6534b626b6b"), new Guid("26ae8be6-a670-4824-93ed-32d3c4f002b4"), new Guid("1fe25ecf-61d9-4f1e-b8b6-1eb0fc01333a") },
                    { new Guid("b5a33092-8a86-42c0-bf4b-58e4d5355c41"), new Guid("398b573a-e90b-4d4e-b98c-f7b55a1eb9d1"), new Guid("db3b8386-beb1-45df-b19f-8f4299f9a511") },
                    { new Guid("b7119c83-0459-47b1-83b9-0dc3f4d43e49"), new Guid("dc077741-16d9-4e1f-9eaf-4ee04e9b22d2"), new Guid("384ebf7c-bd18-454c-84d4-808f8235a1ed") },
                    { new Guid("b78fc6a3-3c6f-4479-98c3-5466c25543d3"), new Guid("7419c10d-ed3d-4c35-9384-62568f33e97a"), new Guid("2e9b06c3-d649-4f78-b5a9-6e757ce2b406") },
                    { new Guid("b9d565d4-0e1c-4de7-b2ab-01e91d01f67c"), new Guid("fa084b9b-55a5-4766-837b-f4dee2add91c"), new Guid("12045f34-a4ad-4f85-8fcc-b368c05cdd80") },
                    { new Guid("bab1fae6-6f2e-4e08-a6d5-b74c06799f67"), new Guid("98c2f040-4f88-4e6d-b91a-7e3a3b033bd0"), new Guid("7c4accb0-3d7a-4b2d-9d40-8ead1853b3e4") },
                    { new Guid("bc2952ab-4901-4994-af52-6c923fc8abe0"), new Guid("7901ae91-3642-446a-9325-515c29875ce5"), new Guid("44c329c7-f791-4ef7-a84f-785ccf427427") },
                    { new Guid("bd6f9c0d-3d72-4930-8e5c-855efa670533"), new Guid("9378afde-cd3f-4186-b03a-2ce93a7aa559"), new Guid("b6ff5ad8-5295-4e48-ae54-d18d683cee18") },
                    { new Guid("bf411688-39cb-4d4e-9b04-d9922a3961c3"), new Guid("e1038923-d63b-410f-a787-d7247d4cd1e5"), new Guid("1c942947-4cec-467b-b4a9-64625f78ec3a") },
                    { new Guid("c032d50b-319d-4149-ab62-870dfc6251f7"), new Guid("71a44309-af9f-4414-b5ee-59f82a5d617a"), new Guid("2e9b06c3-d649-4f78-b5a9-6e757ce2b406") },
                    { new Guid("c0813168-5f51-4475-b000-4acfad956ac3"), new Guid("7901ae91-3642-446a-9325-515c29875ce5"), new Guid("7c4accb0-3d7a-4b2d-9d40-8ead1853b3e4") },
                    { new Guid("c08c31a4-6c07-4193-a765-4d6cbb3dc3b3"), new Guid("c62b4d43-b09f-4e06-bee7-a8422c5a8a49"), new Guid("15974b02-138d-46c2-861e-58447faa82eb") },
                    { new Guid("c196bd53-7742-4b2e-a3f3-cc68d121a13e"), new Guid("b8aa9c89-7b43-4e6e-bb90-cd4e7ef19178"), new Guid("2f43c50e-bdbf-4d86-a48f-45e4305dbe81") },
                    { new Guid("c1b2ea4c-429b-4998-96b0-e301e9cf0122"), new Guid("56ed86a3-d97f-43f7-9548-7960670c4995"), new Guid("384ebf7c-bd18-454c-84d4-808f8235a1ed") },
                    { new Guid("c20f30cb-d49d-40da-a2c6-6f3dc2889217"), new Guid("dc077741-16d9-4e1f-9eaf-4ee04e9b22d2"), new Guid("8bafa452-5a48-4e6d-ac2f-af3b3001c86d") },
                    { new Guid("c56df44e-cf58-41ba-88c5-23d013298fdc"), new Guid("2a9120c7-462d-430e-aa6e-384251468336"), new Guid("8bafa452-5a48-4e6d-ac2f-af3b3001c86d") },
                    { new Guid("c5c1c959-3579-4360-a061-d437fb2c3e30"), new Guid("e505b018-fead-41e1-9776-5163c9af3bf6"), new Guid("12045f34-a4ad-4f85-8fcc-b368c05cdd80") },
                    { new Guid("c8f0d12f-ddfe-4469-8d77-cd53af419e81"), new Guid("a2403760-6713-49b7-8e4a-c5b28d0ebd34"), new Guid("12045f34-a4ad-4f85-8fcc-b368c05cdd80") },
                    { new Guid("c8f323cf-da40-429a-9764-331eccd0787c"), new Guid("edbc1f03-de75-4830-a960-ed2561b39a48"), new Guid("8bafa452-5a48-4e6d-ac2f-af3b3001c86d") },
                    { new Guid("c9204a76-b01e-41a7-8d19-56bb70bb9ff7"), new Guid("f57b0ba6-77ed-41a9-bcb8-bd5954e3b90a"), new Guid("2e9b06c3-d649-4f78-b5a9-6e757ce2b406") },
                    { new Guid("ca3453db-869b-4472-9282-4f9399c25b5e"), new Guid("9c233746-048d-4d08-bb0b-6e4cda4d0639"), new Guid("a291e486-dcbb-4f7a-a0a2-b6eaba27923a") },
                    { new Guid("cb008f23-8b2f-4541-b8b2-1fe22e2abf3a"), new Guid("bc097847-edf6-4766-8f67-765cb3f1e0a7"), new Guid("2e9b06c3-d649-4f78-b5a9-6e757ce2b406") },
                    { new Guid("cbe2dfca-8943-45bc-a8f0-412253c72967"), new Guid("474324f5-fd5a-4d23-81c7-b5b8b66d7136"), new Guid("384ebf7c-bd18-454c-84d4-808f8235a1ed") },
                    { new Guid("cc2c2870-f418-46ae-ab38-74c873785f6d"), new Guid("ca1db322-9c19-45a4-bd13-5ff5aabe8105"), new Guid("058d9135-d0e2-4763-9f18-40a4213cebd7") },
                    { new Guid("cc9dd020-31d9-49b9-84af-3295e102ef41"), new Guid("0ff62f50-6296-4220-8723-80335cbf6500"), new Guid("d3113723-dee3-44a8-9500-ef40e0159569") },
                    { new Guid("cca8beaf-036f-455d-aace-464e755cbb1a"), new Guid("1b734894-4dbc-4386-bf9d-b86e62b5dc5e"), new Guid("15974b02-138d-46c2-861e-58447faa82eb") },
                    { new Guid("d15156e2-a40f-4bf0-8af7-f7171c659d87"), new Guid("0ff62f50-6296-4220-8723-80335cbf6500"), new Guid("12045f34-a4ad-4f85-8fcc-b368c05cdd80") },
                    { new Guid("d3a5d9a7-323b-4793-9d8f-9ad69587483b"), new Guid("96aee99f-b9f5-4a23-8085-a68991b03c80"), new Guid("12045f34-a4ad-4f85-8fcc-b368c05cdd80") },
                    { new Guid("d4e5da16-4ada-4cb2-a823-ae650b20fce4"), new Guid("4b5fe238-692a-441d-92c4-b7adfd464d02"), new Guid("045f5234-991b-4d1d-8da5-af3ee2dd3286") },
                    { new Guid("d5e4e9ff-b8e1-469a-9795-33d94e3d7b67"), new Guid("55eae726-586b-4357-b446-cf7f0b9a7a47"), new Guid("384ebf7c-bd18-454c-84d4-808f8235a1ed") },
                    { new Guid("d7abd28d-bc2e-475d-8ec9-d250920b3ee7"), new Guid("7b61146c-11fb-41fc-8bf8-00b455348109"), new Guid("44c329c7-f791-4ef7-a84f-785ccf427427") },
                    { new Guid("da3b06ac-ff63-47dd-b4aa-70c8a7fc0c44"), new Guid("e1038923-d63b-410f-a787-d7247d4cd1e5"), new Guid("2f43c50e-bdbf-4d86-a48f-45e4305dbe81") },
                    { new Guid("db4c64b7-c490-438a-a79e-18bde702e446"), new Guid("12ab61fa-d7a0-419c-a6c9-e24cf747bff3"), new Guid("8bafa452-5a48-4e6d-ac2f-af3b3001c86d") },
                    { new Guid("de04574b-4411-4193-906a-74f32256f30d"), new Guid("9638bbc9-5293-452e-a7cd-ce90433f7133"), new Guid("7c4accb0-3d7a-4b2d-9d40-8ead1853b3e4") },
                    { new Guid("de264dc0-3bed-4765-a4d6-e52b664a6c35"), new Guid("12ab61fa-d7a0-419c-a6c9-e24cf747bff3"), new Guid("a291e486-dcbb-4f7a-a0a2-b6eaba27923a") },
                    { new Guid("dfb5e290-3691-45fa-9a00-e6da06c0177a"), new Guid("b41d27f1-1c81-4159-aaa3-ab7cf41d265b"), new Guid("8bafa452-5a48-4e6d-ac2f-af3b3001c86d") },
                    { new Guid("e094e8cc-f376-4ca1-a367-60effb883d73"), new Guid("8a7df677-ef15-4d66-a25e-290dcf3bf0fd"), new Guid("2e9b06c3-d649-4f78-b5a9-6e757ce2b406") },
                    { new Guid("e13673b1-5523-4f91-b73b-2a13d85ad1ed"), new Guid("c1f2f777-dc87-4dc0-a47d-b0efe742bc4a"), new Guid("8bafa452-5a48-4e6d-ac2f-af3b3001c86d") },
                    { new Guid("e1fa6fcc-44d9-49fc-b8f4-e6044e4f24c0"), new Guid("b8b78e13-7868-45a5-85e9-cfb97e2bfd82"), new Guid("12045f34-a4ad-4f85-8fcc-b368c05cdd80") },
                    { new Guid("e22a6543-7427-4c6b-9b95-67085092caf0"), new Guid("46c36839-e09b-4631-a675-682d884ce9f5"), new Guid("953b615a-ccd7-4d3c-9c7b-83e2063f8729") },
                    { new Guid("e2a265f4-577a-49bd-bb43-6c81be92a03c"), new Guid("46c36839-e09b-4631-a675-682d884ce9f5"), new Guid("2e9b06c3-d649-4f78-b5a9-6e757ce2b406") },
                    { new Guid("e3e8693b-00a5-47a0-a4da-c032c82cd165"), new Guid("bc097847-edf6-4766-8f67-765cb3f1e0a7"), new Guid("2e9b06c3-d649-4f78-b5a9-6e757ce2b406") },
                    { new Guid("e3eeb031-f0bb-45c9-a880-d33078f34d9b"), new Guid("a0bb695a-f979-4e8e-818a-29fa2d081db9"), new Guid("2f43c50e-bdbf-4d86-a48f-45e4305dbe81") },
                    { new Guid("e40036c8-dfb1-4f94-84ac-7c1fc6b68d93"), new Guid("73b3d0c5-b3c8-45e6-a275-a2026cdeae52"), new Guid("1c942947-4cec-467b-b4a9-64625f78ec3a") },
                    { new Guid("e47d9d71-8cca-464b-a163-895024be76ac"), new Guid("87eda7d8-0bc1-459f-80fa-f426523cc1dc"), new Guid("045f5234-991b-4d1d-8da5-af3ee2dd3286") },
                    { new Guid("e4945771-51bd-496d-9dc7-73bdcd47c76a"), new Guid("398b573a-e90b-4d4e-b98c-f7b55a1eb9d1"), new Guid("058d9135-d0e2-4763-9f18-40a4213cebd7") },
                    { new Guid("e523bde9-f4cb-4c90-beab-bf77668a1898"), new Guid("5a3afcfa-2691-4868-84b9-db7d461a5990"), new Guid("b2d03918-cc9c-40e1-9f26-cc39a74dfb3b") },
                    { new Guid("e63825dd-a5a5-4fa0-b8c2-e9fe7a3f5435"), new Guid("a0bb695a-f979-4e8e-818a-29fa2d081db9"), new Guid("953b615a-ccd7-4d3c-9c7b-83e2063f8729") },
                    { new Guid("e6801fca-b351-43d6-897e-9a15126a3cc3"), new Guid("46c36839-e09b-4631-a675-682d884ce9f5"), new Guid("44c329c7-f791-4ef7-a84f-785ccf427427") },
                    { new Guid("e73640ea-1b5d-422e-a682-be8fc2679841"), new Guid("5ff5f1d7-d3fb-4f28-98a1-cb841bf038ba"), new Guid("1c942947-4cec-467b-b4a9-64625f78ec3a") },
                    { new Guid("e8350546-b8a2-4850-aec2-af506dde71c6"), new Guid("c9ba1ff4-b7e6-4f75-ba9a-03a30cf5d721"), new Guid("384ebf7c-bd18-454c-84d4-808f8235a1ed") },
                    { new Guid("e8cc1b79-961d-4bef-a316-e226878bc353"), new Guid("4d30da1c-70f7-435e-9534-a79cb70fc9ab"), new Guid("058d9135-d0e2-4763-9f18-40a4213cebd7") },
                    { new Guid("e9180000-630d-4d93-ab85-9457f465fb9f"), new Guid("9f4f60b5-01ad-4f5b-9c52-86d170c2c895"), new Guid("b6ff5ad8-5295-4e48-ae54-d18d683cee18") },
                    { new Guid("ea54d9a7-05d8-42c0-b765-c28415f8e82a"), new Guid("18849703-41c1-40b2-98ff-dc9f7a01cbb0"), new Guid("2f43c50e-bdbf-4d86-a48f-45e4305dbe81") },
                    { new Guid("eb346eb2-4f70-48e5-9e55-4c378c2b7b6e"), new Guid("18849703-41c1-40b2-98ff-dc9f7a01cbb0"), new Guid("44c329c7-f791-4ef7-a84f-785ccf427427") },
                    { new Guid("ec815026-8c6f-45b2-8ddb-1bb9c9ffa561"), new Guid("52ff43df-86f8-49f2-b90d-ea832a37e610"), new Guid("384ebf7c-bd18-454c-84d4-808f8235a1ed") },
                    { new Guid("ec8666cf-5efe-4ae3-a39f-b8c907e1305c"), new Guid("9baf2404-7a96-44c1-a228-9f415475b004"), new Guid("8bafa452-5a48-4e6d-ac2f-af3b3001c86d") },
                    { new Guid("ed54bb30-06d3-4c42-89d1-2d69600741b3"), new Guid("92d48b28-ab30-4c72-9675-4270abee827e"), new Guid("a291e486-dcbb-4f7a-a0a2-b6eaba27923a") },
                    { new Guid("edb0110b-9f91-4539-a83d-0ececbf0ad78"), new Guid("73b3d0c5-b3c8-45e6-a275-a2026cdeae52"), new Guid("2f43c50e-bdbf-4d86-a48f-45e4305dbe81") },
                    { new Guid("eec23ca5-b94d-4f09-9a1c-a4c7a324eb7b"), new Guid("13203021-b7b2-49f2-8949-d3b1f0461cc6"), new Guid("12045f34-a4ad-4f85-8fcc-b368c05cdd80") },
                    { new Guid("eee8e6e3-50d5-40e2-839f-dd8553d9f0f3"), new Guid("8699fde6-6e02-4668-b678-cdc38d16673f"), new Guid("8bafa452-5a48-4e6d-ac2f-af3b3001c86d") },
                    { new Guid("ef168976-6c91-4859-ada0-4eca4dba4417"), new Guid("12ab61fa-d7a0-419c-a6c9-e24cf747bff3"), new Guid("045f5234-991b-4d1d-8da5-af3ee2dd3286") },
                    { new Guid("efdcac59-fcda-44bc-ac65-739a9e30e40d"), new Guid("5b350f92-70d9-4797-a0c3-c59bfbedd5b9"), new Guid("1fe25ecf-61d9-4f1e-b8b6-1eb0fc01333a") },
                    { new Guid("f0100f0d-4bd9-4dc5-be25-d7ea6b1bbda5"), new Guid("a7b945b8-5867-44e1-9d39-a1eb93c87817"), new Guid("44c329c7-f791-4ef7-a84f-785ccf427427") },
                    { new Guid("f037bb54-0412-4a6a-9bfc-eb74ac4cbab0"), new Guid("c3d8abec-f174-4228-bd88-be7629132b0b"), new Guid("1c942947-4cec-467b-b4a9-64625f78ec3a") },
                    { new Guid("f07ecc70-f81e-4846-b20b-d002dcd91770"), new Guid("98c2f040-4f88-4e6d-b91a-7e3a3b033bd0"), new Guid("1fe25ecf-61d9-4f1e-b8b6-1eb0fc01333a") },
                    { new Guid("f15a368c-83a7-4346-87d0-81d40a89faf9"), new Guid("a2403760-6713-49b7-8e4a-c5b28d0ebd34"), new Guid("684387d2-acb0-414c-bebc-d79a386fee0a") },
                    { new Guid("f3180523-de0b-40ad-b77f-690a48fd494d"), new Guid("c62b4d43-b09f-4e06-bee7-a8422c5a8a49"), new Guid("44c329c7-f791-4ef7-a84f-785ccf427427") },
                    { new Guid("f37ef3ca-b80a-42c9-82b7-5817f0acf2f9"), new Guid("a524554a-fb05-4c4a-a69a-70c0c444bf33"), new Guid("7c4accb0-3d7a-4b2d-9d40-8ead1853b3e4") },
                    { new Guid("f6ff7a4d-c590-47a6-b6e0-9333bf9129e4"), new Guid("cf5057f3-d910-4499-b571-e39c8d4d7737"), new Guid("684387d2-acb0-414c-bebc-d79a386fee0a") },
                    { new Guid("f8dea574-6e7d-4246-84d1-1d846f612d78"), new Guid("0503fb2e-9fe0-4c9c-98f1-048ec3e64643"), new Guid("44c329c7-f791-4ef7-a84f-785ccf427427") },
                    { new Guid("f9526004-41b9-4fa1-810e-5a164329a2b7"), new Guid("aebb428b-c99b-4c89-9537-414a12d6f420"), new Guid("b6ff5ad8-5295-4e48-ae54-d18d683cee18") },
                    { new Guid("fcbe4344-15a4-4284-b591-e976c4762794"), new Guid("ca1db322-9c19-45a4-bd13-5ff5aabe8105"), new Guid("953b615a-ccd7-4d3c-9c7b-83e2063f8729") },
                    { new Guid("fdc6bf57-5e15-4a8c-acea-1ad360436372"), new Guid("c1f2f777-dc87-4dc0-a47d-b0efe742bc4a"), new Guid("db3b8386-beb1-45df-b19f-8f4299f9a511") },
                    { new Guid("fe63e1e5-3b4f-4ff2-b027-025b6d5be137"), new Guid("c62b4d43-b09f-4e06-bee7-a8422c5a8a49"), new Guid("7c4accb0-3d7a-4b2d-9d40-8ead1853b3e4") },
                    { new Guid("fe87ff2a-bf1c-45c4-98ce-4b234f259c95"), new Guid("a524554a-fb05-4c4a-a69a-70c0c444bf33"), new Guid("045f5234-991b-4d1d-8da5-af3ee2dd3286") },
                    { new Guid("fed3f070-d1ff-4cb3-b143-134e51bcde00"), new Guid("a2403760-6713-49b7-8e4a-c5b28d0ebd34"), new Guid("384ebf7c-bd18-454c-84d4-808f8235a1ed") },
                    { new Guid("ffab779b-618d-4013-b780-e1ce46f01723"), new Guid("b41d27f1-1c81-4159-aaa3-ab7cf41d265b"), new Guid("045f5234-991b-4d1d-8da5-af3ee2dd3286") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerAddress_Owners_OwnerId",
                table: "OwnerAddress",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OwnerAddress_Owners_OwnerId",
                table: "OwnerAddress");

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("0237c593-b25e-4057-89c2-6391551229c2"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("0db03bff-5df5-4a3f-8f9d-cc68c8f01ac4"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("1001102b-6201-4483-9dbb-9aabbf46f155"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("1191ba9b-4a88-4d53-b0a4-390672ea4d56"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("1bc548a7-487e-4fb7-9f4a-27d60673af61"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("23c10e98-2778-46b2-9177-c685740a67de"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("27165e4b-24fd-45db-9225-9ac5ebc12598"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("2c642f40-6717-44d6-b11c-f6f41b3e3ef7"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("318ad972-5fb8-45b6-aabb-04bfbedb26e3"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("417ce465-4982-400c-af9d-15caa5fa970f"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("4613afd7-a1f6-469f-9889-21de75f09440"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("46b0cad6-464e-4089-994e-754cf809393f"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("4f84fc45-764f-4778-bd2e-0e2e620451e0"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("57596b4f-77ce-42c9-a48e-c5d260814672"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("584bd032-f793-42a4-8728-65c3fbfcd796"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("59f99b19-d877-4cf4-9920-b904acbb26df"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("5bbe0d5a-8f88-4f95-8bf0-beee9bfe6363"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("61e9ec3e-d321-4a48-9dca-31fc8e749d0e"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("653b7988-c3af-418e-8e8d-24d53bb26094"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("6a7594d4-961d-473e-9954-e35a98520e90"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("6f7017d0-14ef-4bf5-b7c4-87b0b72f08b9"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("700d5188-dd70-4ee0-8202-fbf9e1eef61c"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("722d981e-6030-4f9d-9078-ee9aafe02586"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("76494062-c13f-47a3-ac6a-2e32e743f550"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("81734981-a9ea-4377-9a03-ab961ca8832d"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("82a5c632-5dd9-4937-be9a-09abefd8ee60"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("89b07993-a235-4ad3-a7b3-2edebe279538"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("8a451837-5d9f-4e9e-b3c1-4f4517571dd7"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("916fb205-a457-4545-8666-11c2b1bfabf9"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("94436a75-a883-4ccb-a410-b6dc4ee5a21d"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("a267bc5c-db67-487d-9874-f69d20ea28ee"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("a2a3c89f-5554-487a-845a-fa4b6e4454f2"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("a2d5106a-02e7-4706-b657-2e1878204bc0"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("a8f22a39-57fb-48de-9732-9baca7ea5af3"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("a943a440-cac9-489d-b4de-0bdb993a44ab"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("a9bc6275-1140-43cd-9e57-1305b70bfa40"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("aa9df198-bf86-48e5-afd6-b9fc4ae97c8c"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("ab5dd1df-0fb3-4cbb-8c30-dc2b845e59b1"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("b4c75220-43e4-4824-a334-0d63ca04c2ea"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("b9068051-57e2-4395-ae51-aeb16324a13e"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("b96b6918-2dcb-4dfd-ac7f-0b8abb740287"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("bb9acf7b-0657-4e1b-a74c-c2559093d41d"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("c2f46f39-d4ad-491c-846b-4bc48cd76fa5"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("cbbceea7-1ab8-492b-b032-8b494711b8b7"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("d35621b2-09d5-4bad-b6fb-9e32887b44d9"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("dc23084d-2727-4239-a886-36bc9ff05d64"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("e0401d98-d4a1-48d9-893e-0503b12488cb"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("e09c1098-6169-4beb-9358-24f93c587b59"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("e545b8b6-79b2-4165-a1af-6a1c128db0b7"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("fe624540-6b24-440f-8fe7-a36cacd071d5"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("05d4a986-b50c-4667-b232-3a254ac75839"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("06dd01bd-ca43-44a6-bc5c-4b04a193645a"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("0a86e9de-e96a-43da-86d7-8e96958e8990"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("120afe48-b33c-4d62-8718-6579148fd521"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("1ef49751-803c-42d4-917b-4bf253ce3d9f"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("2b3f2b68-497c-47a2-ba42-49e4da62a733"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("355152ed-7403-45ba-aadb-e822e5b8c4fc"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("3667728d-6e23-4d68-83fe-c5d81ab2bacd"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("3a6744d8-9845-4591-bdb6-73251db5d745"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("3ed99a2b-b848-4369-95de-6a6b0b0378f7"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("649e052b-dcfe-41ce-be4a-503f18703e8a"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("6c7d98f6-b5cf-45ec-8e0c-79510ae53df0"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("8541f561-48a7-4018-94d0-9661bfa76a6d"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("98e8670a-5a03-498b-86c5-c8016888aadf"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("a3b44907-6adf-457f-982f-6029e9ea6346"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("c122c85d-6131-40ac-b75d-964de2ec14f4"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("d2867ab4-a306-473c-99bb-84f882d4b12b"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("dced6412-8712-4729-b537-9c1e6b391fae"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("e39c7389-52b0-41d8-8b12-1ba2998a9636"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("e8de579b-30cd-49d9-95f2-e57f5a460076"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("ec20ece7-57a2-4ddc-9e49-7de81b75d5b0"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("ef137eb7-41a3-4928-aa26-03955da1b4a4"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("efacf232-8d66-41a4-ba64-1649e395f73f"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("f39ccdd9-8d8c-44ea-aa09-754ed5eba23b"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("f967f5f0-239a-46a3-9f70-597b4bcef6d0"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("003225cf-c0f6-4f6c-ae81-8a830caafb66"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("02e8f653-5e9e-4024-8920-59f5d2322b1a"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("030ed192-d09a-4dd7-84cf-efd2ae690fdb"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("073698eb-ea69-4e41-9c62-429d7dc10e44"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("07706097-3ecd-4cf2-836e-8ce3b0740354"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("0b56ba7f-09d9-451c-a397-d3570bc3c738"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("0bdd4a30-dd75-4d15-93e8-08e264e8beaf"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("0c27aae2-b455-4449-93c6-5927ceb24505"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("106b5745-d123-4356-bf62-f51338f5d519"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("142bedfb-a99c-45b1-84ba-c9c957d9a7bc"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("1761e2ba-f944-4cf9-a6ad-06b2e5f825fa"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("1a318d14-b8c7-41fe-ad9a-e15fe9911f6c"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("1bf3f428-594a-489e-aa77-969e547245a3"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("21a35cba-97eb-4e86-a469-33e2705e93dc"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("2ae65313-66d5-4a3c-a39a-67c7ad85353a"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("2b097b52-1ccb-4177-b4a1-4883e1de9347"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("2c6272a3-fc48-4619-8a41-8c48fd34957d"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("39aba7e3-34d3-4756-8b8c-32336bdb49bc"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("408e09b9-f471-42c2-b3af-c69a5f6fbcec"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("4164b12b-17e2-4449-8361-0a7c96fe371a"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("462f0086-24af-4357-92c1-640558a8e215"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("464703c0-9a49-4aa9-be0e-a53556605b4e"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("472dee00-f21a-4528-a939-936cfd0f72ae"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("48107319-96b3-403a-8a26-9c153e01423a"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("4a9433c8-c66a-4c72-b422-63592f0a0a6d"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("4df79334-885f-42e1-98f7-37134ea9e022"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("527d9684-9bd9-40c5-8bf0-12378cda7f8e"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("56708178-6ee7-419e-9655-ce275a226ed0"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("57479a16-30c3-440a-9af3-45da21487731"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("5930a18d-24bb-4ee6-8d2c-bb9189abc5e6"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("5e7a53f0-7721-46b1-9a31-79ca25ee4ec4"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("5ec4b659-49cd-4a91-a0f2-8eabc12594d9"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("5eeadb53-09ac-4bb4-a0a6-1316372bab34"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("605206c3-d956-47ca-9e60-dd43f6b4fad9"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("638f215b-cd5a-4317-833c-44f3d069a59f"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("63b5f76f-0da2-435e-a807-3a0c64832812"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("6654415a-a8b7-4096-be9b-f21817c81ff6"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("68b35cf6-ee02-4d19-8451-b9d51d3b99d0"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("68c6ca2a-03c9-4cfa-9aa5-1a35e52c0391"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("69edc0b8-7128-4f7f-a569-7b4a7e5fba11"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("6c02d66c-3b30-41b5-9877-72834e7c7c4b"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("6c53d234-0226-4927-b441-a18e0ff04dc7"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("6d0f74bf-c3d8-40c0-aff1-07c6d5b9bbec"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("716da0e5-ced6-4368-b74d-e6dcbb7fbf2d"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("75e75ee0-443c-4c29-a708-c0272334e206"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("76d6856d-2b46-4965-9fcd-04dab216c382"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("77b8d3b8-497a-4535-92f8-76f7f5589733"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("7db8ce35-72e6-4055-b5ec-3fd03485a03c"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("7f0a6eff-35a2-4ded-8d01-792e79314eee"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("8078676b-5df9-4793-bde6-d40e8e257bb9"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("8275e8d4-5330-40c8-bfa3-37de1359951e"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("87a1623a-702a-4cf5-b554-ce624aaeb852"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("88b61f57-1d53-49ec-9a63-6d91b8cee75f"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("8a618706-84f1-4f5f-a9e3-07ea8d9cf4cd"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("8ef09fc6-0ba1-464e-99fc-7915f60e7d11"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("8f636256-59c0-4c6a-9404-afd174b83034"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("904ab68d-4da0-46aa-9891-a0ab764c1180"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("904f6861-2cd3-47b4-85c9-2ea512f3fbce"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("9058462f-cfe0-4149-b8ab-a6fbad73d488"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("909c2911-84aa-42d3-864e-c026c1e59595"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("923802ff-e301-4d57-911d-4a1a5e2a8447"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("93e3f82f-b7a2-4629-a0a9-fa73f2fbccd4"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("9619aaa5-ead3-4b58-9f64-bf88024ca6c7"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("9776098a-377b-4358-ab75-a2ff9dda52eb"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("9949380a-5565-42b6-89b3-8f99e966d786"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("a57d9e47-8bab-4824-be5e-77be8136efa9"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("aa4ffd9a-0e86-4b3b-bbd0-45057b5c7f3c"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("b04ea160-5262-4038-9e02-81500afc7233"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("b3ffdf42-e906-44e2-ba6b-02f553731642"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("b7a3acdf-e4d9-4649-8c27-d0fada80112e"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("b7f84f68-9861-4b1a-9bef-b83a440a282b"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("bb6e33ee-b98a-4661-a8db-4d9dcd5bb3bc"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("bc65ead2-2442-4835-afb3-ff0319dadea5"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("c32e4072-034c-45dd-a78a-ac993fa8c73d"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("c57561a0-389d-4c74-808f-bd8a913f1431"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("c66c64dd-7afa-4938-bb68-8c529b06d21a"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("ca43f5a4-1785-4548-9365-acd613191fbc"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("ca5a9b67-5b15-4d7b-bd8a-d0fa58e92472"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("d2f4061f-9f10-45e6-9d44-b865cafffa0a"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("d34571df-40b0-456f-986e-ceab5a01b1e1"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("d95f8b76-386b-4865-8a65-70c53f8e3996"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("d9af2421-af59-440e-beb9-b0d1f710da63"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("d9f7a5e8-a59e-4c92-ac0e-62bb38505508"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("dbb9750f-8dfc-4d62-a863-11e423f21bb6"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("dbdf02b3-489c-4bd5-95b4-b89332d96981"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("dd57b75f-2602-4c7c-b1d9-8cd7408621f8"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("ddec6a08-8919-49a6-bf2a-97cfd3d5f570"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("dff319af-444b-40ff-a9e2-09c2f1518849"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("e013a643-094b-430c-b8ef-73093321adfa"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("e275f5c9-a88c-43e7-91b0-88d4bb29a89c"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("e3724244-4faa-4468-822b-fa6091f59a62"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("e574a586-fe12-457c-a1d2-de1e6d2904d9"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("f2cb51ee-86db-4dfa-a7fd-0498428faa73"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("f3cd6fc4-fb5c-4be6-bbd8-52a749df0c62"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("f4caf8bc-cbd9-4ff3-8359-6dd4b767e2ed"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("f6173088-690e-4d9c-9e1c-86b3d0972679"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("f6d9d976-6fe3-40fe-9d08-e163da266eec"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("f8f9c155-a1a8-4d1c-a4f1-717951734395"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("f9d5f6f1-0ace-42f5-99bc-7127f584e9c7"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("fc141f1f-e7db-4afb-a5c9-2b19c41888c1"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("fd22d90d-bcd9-4b95-87d6-733d79660356"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("fedc1cbb-bda5-478c-966b-de2369eda8f6"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0099b259-823c-4e87-a92e-2f1f1e4a4ee0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("00e514fc-18f6-478d-a1dc-41e0135eb2ae"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("01538bfe-6e17-4963-8d22-8909af017546"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("01c59abf-1168-4b97-b0ce-53f31a324ede"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("01d48669-b75a-4eba-a530-b44debd78f79"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("03511d13-b55e-4d90-add0-3b891f771d80"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("03557ce7-1079-4e7b-9b3c-0dff311d0159"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("035bb9d9-ede7-40a2-99df-0198dd6e6ecb"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("03d931fb-5ea3-44aa-bc97-48bd93133fd4"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("05709ba1-5568-4438-b379-0b7ca1096fa6"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0614ea6e-c17a-490f-aae8-994b1da8cbc1"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("064d0fbf-d95c-4986-a92e-ae5c6df98060"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("084e27a3-40b7-4858-8a3a-1d6a93993d9f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("08606f1f-82a7-42ed-aa50-15bac38f0303"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("08ab7b3e-06cb-4c51-8683-aca840263f28"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0924f62e-42fe-4a28-8561-580df27592bc"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("09931254-6dd3-4cdc-adb8-26a31d2d38c1"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("09d3373d-7831-442a-9697-776d292da404"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0a44db6e-6e3b-4dfe-ae31-20494ac6a28a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0b138b54-b9ad-4afe-8058-1216ed75a3ba"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0bfc2729-80a1-4286-9a24-32992108396a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0cc8c4b2-605b-47c3-a72b-a62585274739"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0dfe3579-c234-4c61-ad6c-9207ce44951f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0f7faa22-74c7-40ae-b693-81bc7bdbb01e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0f9976cb-1b5c-40a3-be4b-b231bc817241"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("10a4b9c8-3382-447f-b5c5-2028d0c3681b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("122f013d-4eef-4272-a828-9731bba0f0e3"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1265bf90-fcfe-4282-9928-ff986249cfc2"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("148f7894-8065-473d-8588-5b780e5d4170"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("14dda879-fc94-4cc3-a2d9-f9929bfed3c9"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("14f7a60f-7013-4fc8-a260-69d5b2e2a82a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1549796f-93d6-4d7d-9dbf-b1e18cb96a34"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("158d22fa-eba4-4e1f-9056-6deb78294b16"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("162cf9ca-c91e-48aa-87a0-16c400cee1c6"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1644d0be-4123-47d0-842f-25681cef95af"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("166d025d-04ea-462d-812a-e887faca9b11"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("18f3b564-0552-4e46-bc04-a6496307a61e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1a15acd9-14e8-44a3-b02a-4a3525acb3bd"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1a31df63-4a59-4eb8-97dc-a70beff3e78a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1a419f73-fd8c-4d67-a2d9-0ca4a04d9fc3"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1a83739b-026d-4eef-86cb-0f2f0431d657"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1b5d2509-aefc-4544-aa67-1fa50d4a07b3"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1b901ec5-e529-4d47-a86e-3fcb1bb44a2e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1c1b9b88-2f9e-4560-a4ae-18f070faa2dc"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1c32a3b1-9d8a-4919-a0c6-a5a208dfa6ee"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1cb18df2-40f4-4984-8163-ff555280cf3e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1cd961be-adbd-4639-8e5e-a7f734bfe298"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1d562a2f-051c-4753-9ec4-e487ca8c6d26"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1d5b6f32-6eef-42d6-90ca-02f3d36841e8"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1fb3c379-bbe7-4310-83e0-55aa9a2c9d17"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2059ff78-02d4-4e8f-8bcc-e90fcdbd53d7"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("22005125-b479-44b9-a351-29f2a635f179"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("22b2ddeb-a67f-444e-ad7f-a484351f8186"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2338cc67-93d6-477d-b9d5-08c2c4c44738"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("23a63d74-8ce7-43b7-81af-eacb9ecf8311"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("250c904e-1439-4ef2-9466-208bebcd9e02"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("26b72833-60b5-4683-9824-2a701fcd294f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2769c03c-c436-4e6b-a6eb-850254f7de20"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("27fb5dba-7467-4d19-baeb-233dacbe8525"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2803d491-2349-4cc8-b104-9356bb1ff185"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2843d1ff-79d4-438d-b6fa-c3388837cc2d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2873bd9c-da7a-4ac7-b313-ec6836108ce1"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("295227f6-88e1-49d5-b68e-f143f5fddfbd"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("29fa3692-8042-4c76-a8f8-5ef86071c886"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2b167b61-b352-4769-9564-021cbccf83a9"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2b4fc221-d84d-4488-851c-a63295cb0335"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2bbafb8c-2430-4884-8d3c-4d2fb5cbc1eb"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2d0a549a-f871-46c7-b7bc-a9bb30a11aa0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2d9eab05-e018-4bf4-a1d9-baf79e7d60c9"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2fa1d2fd-1cb3-41d5-be06-e0984c1dcb74"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2ffb6007-c401-42d4-a6cc-925ab7093741"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("32fca7d5-3946-44a5-a048-b96b1d61ccef"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("3321590a-33bf-43fa-a006-504eb6057864"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("34541a31-bbec-44e8-9e33-564d504a9a74"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("352ffb5a-42c7-442b-803c-bcaaa32d83d4"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("354ea457-9e6b-4e9e-acd6-7aedcf36e9fe"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("356c6e4d-ec51-4bdf-b6f0-d85bac5afe72"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("377fd826-b90f-4aea-991c-b6294cc5e8f0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("3845284e-81c4-4155-944e-c00ad0f2d206"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("3ac7ee72-dfa1-4749-b88e-2930c02b683f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("3b2f230b-4f4f-420a-941b-ed8883502907"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("3bdebf08-f49b-4c59-80a8-2ba7197b164b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("3c6fbe94-70a3-43a6-ab0f-e83aacdfef53"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("3db5c3bc-05b3-47a3-ba43-1d18c4795e6d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4052f13d-6ee5-4c34-9d9e-0da4b466333f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("40776424-d70c-4ee7-a437-9f0cac2ad36c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("41246e59-7b47-42ac-9e17-0637d9707ed2"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4134c602-7cb0-479f-88e7-278b594e0d7f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4358c6f7-62d2-44b8-8955-06e2fafd1505"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("43c41d6f-e22a-41aa-9951-9fab6c71b404"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("45e251c2-5428-4f57-8793-cf0b07a30e0f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("45e55ae4-a497-4a53-86d5-2a5ed6e02b39"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("47790557-25d4-4771-bedc-056da521ce36"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("47c4d3b7-e7e2-4344-8f4a-5a51247cc085"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("499c51cb-8cb8-4e01-ba57-649c5c6d74cb"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4b655747-00bc-479a-899a-b1d10dec2714"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4b9d1005-8aa4-4cbd-a60a-dd02274ac316"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4c0a63d9-e0c1-4a09-9f04-afbef1b7601a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4d82e408-ff7e-4e3d-a671-5b2b54fb2983"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4e1e2d39-bbe6-4e18-afe2-f48aae736efe"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4e4c2686-3ca1-422d-9512-ecee28f00644"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4e8ce494-0c7b-4ba4-81ec-a343251a1bce"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4fbf5fce-38da-45b0-9472-a885618fb113"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("50e941ae-2be9-4ac8-b494-e31e62cdeb15"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("524511c5-8b3a-4e4c-8891-9ece3971da24"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("55463d25-0c0a-47e5-8422-0f059a8a5b85"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("557163c6-d348-4de0-bb7b-70e97e9f98aa"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("569d5cd0-43a0-4359-b16c-7aee532fda18"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("578afd84-c025-499b-bcb1-e21703ed79ec"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("57bb418d-57ec-4b14-9b2d-0acf9c90e8b1"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("58c29997-77d4-44d2-b77d-b4cbc821e05e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("5a24b953-cfb8-4c46-8d11-1489d266f969"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("5d930b1f-f414-496d-b6d5-9fdae0f07ad3"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("5f7873e5-a2b1-4ad0-bdbc-83ce96401c60"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("5ffc3b7e-493e-4096-823e-b7fa44a7d2da"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("600707d5-43cd-4428-af7d-72ee88259d1a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("609e932b-8df1-4640-954f-797bcc35e1cb"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("60bdadc4-5558-4818-b1ef-cf1ea18b9b7c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("63bce694-06f9-4dfd-a657-5cadc30d614c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("649d2c87-9e65-46a5-9c23-def1ccd2f4b7"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6519469d-3452-421c-8c99-b67c95402b7c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("670297d5-b6ef-43db-a6c2-d63f0d90d27d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("672579f1-dc20-4363-bde4-cb914e71099d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6855b14e-62f6-492d-b64b-40fd65212281"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("68756b15-9e8d-46c4-bb0f-1979313d01ca"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6984fdee-bf5b-4a5e-8d64-fb4e983dcc7a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("69aa8f34-7ac6-479f-bff0-4c1b5ac3bd42"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6b3eb1dd-fbb7-45f7-9815-356d1b7cf3c5"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6bdad145-bc45-4c60-8682-9c0c7e836e6e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6c812672-1baa-4975-931e-5bc5e7afd006"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6d12774d-e83c-4625-b270-6d1a8eb69755"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6e531c7a-2cf2-4d00-b94e-ace936d41042"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6e79d3f8-ee2a-421b-a029-a136017c3608"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6ef75c15-0a4d-4084-9349-e69b6ec2eae6"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("7031e6b3-c0a8-42b5-8a90-0be51bfee06c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("7067fb24-67f7-4f9b-8669-7c24b6fceb82"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("71a44b12-f6d6-4068-8dce-98d8cfda4e03"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("7250a950-7d89-489e-b6fe-9d6b5bd0a9d4"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("72bb5f04-5101-4b8e-91d5-c85bc4ed3bc6"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("7367f1dc-a129-4f37-b9aa-1505f0bd43c8"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("73d3dac9-c116-4516-8764-336bcdbe654d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("74d87a35-32dc-45ff-9397-7d6a43c41008"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("74e32076-c0f8-42cd-8912-21ac9646fbcb"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("76b7ca53-91a8-4d0a-a380-534134e3e9b2"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("76d44945-45f5-4621-9bac-ee50855aa479"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("77d41165-0ad4-431b-aa64-993cc646c0e7"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("786d437f-61a6-4f74-bc43-9a3c5ec17439"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("789383f6-7675-44f7-a59b-0e6987b4ea72"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("7896ccd1-65be-4c13-8fce-934e620d0d57"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("792350eb-6993-4042-9369-6d038c1be193"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("79c2c4ab-8806-4927-8421-2705e13db617"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("7ad5620a-17a3-490f-8224-eeb34de4d086"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("7c152d4f-8f22-4cda-86ef-21d335c88186"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("7c97a02a-a838-44b2-88b2-6fd15098d577"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("7ca683a6-0b00-4e49-9883-134cb1e455bd"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("7d9a1cd0-b92f-47b1-bc8f-3eb13de317cc"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("80aaa463-863d-4b79-86e3-ca1c56435477"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("81ef368f-0899-49b2-b23b-9c25412923d9"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("8275c514-a3d3-483b-997d-c43e18673787"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("827ae99d-bab0-472f-a95a-ca9751ce62e3"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("83565c63-813d-478e-bb87-ecf30f4064fb"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("83b51c48-dd78-4a13-a227-9b729a177b63"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("83dce356-31c7-4c6e-9837-8f1299958116"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("85180ab3-313a-4897-a1e4-59611504af50"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("873023e8-a533-411e-84f7-ba449e421d56"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("895671f4-0999-4d81-b038-6820f1c6d010"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("89ca983b-77e4-466b-aa57-f924ae9ded82"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("89f536dd-974c-4724-9cf6-5359c2038a4b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("8b4ffb96-fce6-41f4-afb1-69414474baf7"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("8b620117-d79f-45c3-bf39-77572eaba270"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("8c036cc9-a5bc-4cba-9fc2-ccf3d51dd3fd"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("8c232d75-24ca-4621-9646-02228c94eb24"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("8c296a37-7175-472c-b629-8c11514d6e47"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("8caaedbd-b326-443a-9480-e8d544887168"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("8f80b24d-677f-4203-9a42-7c635a4f905f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("910b983d-3089-4418-88f2-66e3fef82cd6"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("91371253-f155-4c6f-becb-bbadf7dbde67"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("920c0fce-9157-43b9-b50d-3d363a89a712"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("93ec977c-aed7-4584-a2e5-8f3af749374a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("953b4317-3f17-4cf0-a2ca-ba26e09057a1"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("9562e3bf-a2d0-4ee5-873c-6b63a8a1023e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("983ee90c-fb7f-4efb-9807-6b1d1cd04719"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("986e109d-dd9d-46ff-9f60-ab56a1f92914"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("98b0b1a1-31b7-40b8-89c5-a6ec8a3c95c4"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("98d9f49a-26a5-4cca-8817-45fe53b037e9"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("9a27ae12-037f-42e8-8fad-02aa7346a9e6"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("9bb4dda9-491e-4620-97bf-1370a72638a7"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("9bdd8767-5ecb-4014-a8b6-f9feeabea04c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("9c73edd2-47a2-4a52-a4ac-07ee98ee12da"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("9caa897b-5d56-484f-a77a-fac982cf683b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("9cb69f64-eafe-42fd-9256-421b8c45f1bc"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("9d12035f-abd5-4698-9c31-d38d5558e054"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("9e45f7a5-bbff-4027-840b-f99e81700555"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("9e8439ac-7f7c-4021-aa69-812e1028a8d9"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a1c5ceb0-6508-4b1a-8c9f-4f8866b1c4bc"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a1fdcd05-957c-483b-ba9c-a4b64a679de0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a4012123-5224-497d-a433-bd31a8f65327"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a42972f8-f417-4739-8176-6d22c310e2f6"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a47096a5-2ff4-4ef2-9fd6-87b678dc7983"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a5392afd-f2e8-4e6c-bbfb-fbc00465abc7"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a552b519-f905-4995-b113-16c7bc6dba1f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a5c6a55b-ef81-4535-aacb-813f4cbde7a5"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a64f2ca5-e31f-48ce-a060-6edb70b8274f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a7278561-fba7-4bd7-857c-6a85bb696df9"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a73d8b00-ea73-4cf4-964d-8bbcd67a1ead"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a755059e-0202-4667-87f4-0333cb33d7dc"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a7636519-a902-49ab-9cf1-021fe5277304"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a8a5d480-7385-48bc-871e-3154f3eeb2a1"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a9da9afd-a7f3-4722-93db-f8af15b72e90"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a9de4b03-8a67-431b-8324-e8f89549739e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ab149b3d-9466-4579-bc90-f643024a60a3"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("abd62278-b1ca-4ec8-a6a1-6a5711bb7043"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("acd5f126-6827-4fce-adbc-bf8367021724"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ad43d2e9-85ca-4865-b08d-b05f3856e418"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("aea3daec-1ee4-4041-8b79-a7f807820a36"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("af088f78-b070-45d3-a92c-83bb07031a2e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("af5bc843-c814-4277-9b4f-99268f6e7334"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("afb5e653-7a35-4362-a753-d68d60c1e3c5"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b0b73433-f15a-4149-939e-ffbdc9b365e6"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b1a70a58-f1ed-4ca6-af18-50da70c08562"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b3e339cc-9ac7-48e2-9446-39e312c612ab"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b4d14e8c-0b48-4de5-8449-a45a01be6472"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b596a74b-f0ca-406b-a7f8-d6534b626b6b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b5a33092-8a86-42c0-bf4b-58e4d5355c41"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b7119c83-0459-47b1-83b9-0dc3f4d43e49"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b78fc6a3-3c6f-4479-98c3-5466c25543d3"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b9d565d4-0e1c-4de7-b2ab-01e91d01f67c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("bab1fae6-6f2e-4e08-a6d5-b74c06799f67"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("bc2952ab-4901-4994-af52-6c923fc8abe0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("bd6f9c0d-3d72-4930-8e5c-855efa670533"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("bf411688-39cb-4d4e-9b04-d9922a3961c3"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c032d50b-319d-4149-ab62-870dfc6251f7"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c0813168-5f51-4475-b000-4acfad956ac3"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c08c31a4-6c07-4193-a765-4d6cbb3dc3b3"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c196bd53-7742-4b2e-a3f3-cc68d121a13e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c1b2ea4c-429b-4998-96b0-e301e9cf0122"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c20f30cb-d49d-40da-a2c6-6f3dc2889217"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c56df44e-cf58-41ba-88c5-23d013298fdc"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c5c1c959-3579-4360-a061-d437fb2c3e30"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c8f0d12f-ddfe-4469-8d77-cd53af419e81"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c8f323cf-da40-429a-9764-331eccd0787c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c9204a76-b01e-41a7-8d19-56bb70bb9ff7"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ca3453db-869b-4472-9282-4f9399c25b5e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("cb008f23-8b2f-4541-b8b2-1fe22e2abf3a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("cbe2dfca-8943-45bc-a8f0-412253c72967"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("cc2c2870-f418-46ae-ab38-74c873785f6d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("cc9dd020-31d9-49b9-84af-3295e102ef41"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("cca8beaf-036f-455d-aace-464e755cbb1a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d15156e2-a40f-4bf0-8af7-f7171c659d87"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d3a5d9a7-323b-4793-9d8f-9ad69587483b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d4e5da16-4ada-4cb2-a823-ae650b20fce4"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d5e4e9ff-b8e1-469a-9795-33d94e3d7b67"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d7abd28d-bc2e-475d-8ec9-d250920b3ee7"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("da3b06ac-ff63-47dd-b4aa-70c8a7fc0c44"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("db4c64b7-c490-438a-a79e-18bde702e446"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("de04574b-4411-4193-906a-74f32256f30d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("de264dc0-3bed-4765-a4d6-e52b664a6c35"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("dfb5e290-3691-45fa-9a00-e6da06c0177a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e094e8cc-f376-4ca1-a367-60effb883d73"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e13673b1-5523-4f91-b73b-2a13d85ad1ed"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e1fa6fcc-44d9-49fc-b8f4-e6044e4f24c0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e22a6543-7427-4c6b-9b95-67085092caf0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e2a265f4-577a-49bd-bb43-6c81be92a03c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e3e8693b-00a5-47a0-a4da-c032c82cd165"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e3eeb031-f0bb-45c9-a880-d33078f34d9b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e40036c8-dfb1-4f94-84ac-7c1fc6b68d93"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e47d9d71-8cca-464b-a163-895024be76ac"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e4945771-51bd-496d-9dc7-73bdcd47c76a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e523bde9-f4cb-4c90-beab-bf77668a1898"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e63825dd-a5a5-4fa0-b8c2-e9fe7a3f5435"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e6801fca-b351-43d6-897e-9a15126a3cc3"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e73640ea-1b5d-422e-a682-be8fc2679841"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e8350546-b8a2-4850-aec2-af506dde71c6"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e8cc1b79-961d-4bef-a316-e226878bc353"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e9180000-630d-4d93-ab85-9457f465fb9f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ea54d9a7-05d8-42c0-b765-c28415f8e82a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("eb346eb2-4f70-48e5-9e55-4c378c2b7b6e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ec815026-8c6f-45b2-8ddb-1bb9c9ffa561"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ec8666cf-5efe-4ae3-a39f-b8c907e1305c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ed54bb30-06d3-4c42-89d1-2d69600741b3"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("edb0110b-9f91-4539-a83d-0ececbf0ad78"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("eec23ca5-b94d-4f09-9a1c-a4c7a324eb7b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("eee8e6e3-50d5-40e2-839f-dd8553d9f0f3"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ef168976-6c91-4859-ada0-4eca4dba4417"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("efdcac59-fcda-44bc-ac65-739a9e30e40d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f0100f0d-4bd9-4dc5-be25-d7ea6b1bbda5"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f037bb54-0412-4a6a-9bfc-eb74ac4cbab0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f07ecc70-f81e-4846-b20b-d002dcd91770"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f15a368c-83a7-4346-87d0-81d40a89faf9"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f3180523-de0b-40ad-b77f-690a48fd494d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f37ef3ca-b80a-42c9-82b7-5817f0acf2f9"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f6ff7a4d-c590-47a6-b6e0-9333bf9129e4"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f8dea574-6e7d-4246-84d1-1d846f612d78"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f9526004-41b9-4fa1-810e-5a164329a2b7"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("fcbe4344-15a4-4284-b591-e976c4762794"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("fdc6bf57-5e15-4a8c-acea-1ad360436372"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("fe63e1e5-3b4f-4ff2-b027-025b6d5be137"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("fe87ff2a-bf1c-45c4-98ce-4b234f259c95"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("fed3f070-d1ff-4cb3-b143-134e51bcde00"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ffab779b-618d-4013-b780-e1ce46f01723"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("1471ea91-364e-443d-9053-c2437649b1a9"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("43f02c8f-8cc0-4cf7-b5e6-e0e00770a6d0"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("0d3d8223-595d-46e5-a162-fcfafbb58ddd"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("20c2f6e4-b90f-454f-83f1-7dba98e0b279"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("266d3186-0341-4f26-b659-6e77e4b59b09"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("46ee8744-a25d-4264-a376-cefcb2cfc73f"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("94066b79-d947-45fd-a930-aa8b6e99e41d"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("9af75ebf-9a91-4e1a-963b-30882a3b6833"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("d512e878-c198-4920-b15c-f0fbefc1013b"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("d68651ae-a895-4748-a1e3-83b75ab9db87"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("0503fb2e-9fe0-4c9c-98f1-048ec3e64643"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("059555e3-86ef-4a81-bf58-5e650034d03d"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("05fa4454-8956-4d0b-8ca5-0fbd57900583"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("098fa3c3-d88b-49b2-9e37-a2bc2728b443"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("0a3f8a6d-e611-4e84-8eb3-d6eb2c172d6c"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("0ff62f50-6296-4220-8723-80335cbf6500"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("10781e9d-a38d-4029-a3d0-954843518924"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("119909d2-d664-40c8-95a0-3a104200c8ff"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("12ab61fa-d7a0-419c-a6c9-e24cf747bff3"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("13203021-b7b2-49f2-8949-d3b1f0461cc6"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("145344c8-4ba3-4e92-b4b8-2a4e446b2530"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("170aa5e4-4322-4b43-bdfa-e73c4ee41724"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("18849703-41c1-40b2-98ff-dc9f7a01cbb0"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("1b734894-4dbc-4386-bf9d-b86e62b5dc5e"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("1e36aa36-b3d7-4981-be5e-4fc9624d1729"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("26ae8be6-a670-4824-93ed-32d3c4f002b4"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("28cc2f37-4a21-4648-9ec4-fb9939e9b3ce"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("2a124c1c-b7be-402c-aa46-d5cd95564dc9"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("2a9120c7-462d-430e-aa6e-384251468336"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("2b62fd2a-5684-43bd-a189-25e385effd2a"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("2b6a8d60-3c5f-4fbe-9cb1-6772b7e36afb"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("2beda2e1-d9aa-42ef-831a-ef8fa730e72d"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("3393ca84-c374-455a-b8d9-888d16e17315"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("398b573a-e90b-4d4e-b98c-f7b55a1eb9d1"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("440b376b-8add-4b08-8096-176bcc0e2451"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("464a03ed-e2da-4f7b-b233-035f92eeea60"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("46c36839-e09b-4631-a675-682d884ce9f5"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("474324f5-fd5a-4d23-81c7-b5b8b66d7136"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("49b637b3-f68f-42e7-b29e-1906e52b132e"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("4b5fe238-692a-441d-92c4-b7adfd464d02"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("4d30da1c-70f7-435e-9534-a79cb70fc9ab"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("52ff43df-86f8-49f2-b90d-ea832a37e610"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("55eae726-586b-4357-b446-cf7f0b9a7a47"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("56ed86a3-d97f-43f7-9548-7960670c4995"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("5a3afcfa-2691-4868-84b9-db7d461a5990"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("5ab7c84c-fc9f-41d8-8840-853bec4b1f56"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("5b350f92-70d9-4797-a0c3-c59bfbedd5b9"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("5e7c00c7-d0a1-41b1-9dd6-6d5eef899993"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("5ff5f1d7-d3fb-4f28-98a1-cb841bf038ba"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("637452d1-38c4-4c80-a0c8-d86ee987f70e"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("677521a5-b4a7-434b-994e-8495c7579762"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("71a44309-af9f-4414-b5ee-59f82a5d617a"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("73b3d0c5-b3c8-45e6-a275-a2026cdeae52"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("7419c10d-ed3d-4c35-9384-62568f33e97a"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("75c4bf57-849e-46d6-95ea-3fa604356ccb"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("7770fbcc-96ea-4d03-8323-399eac1deb6e"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("7901ae91-3642-446a-9325-515c29875ce5"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("7b61146c-11fb-41fc-8bf8-00b455348109"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("7cdfc11b-d421-46b4-b358-510d89bea70c"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("7d0ce67d-7883-4ea3-89fb-dae83e01eb11"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("7fc66a1c-f4c8-4708-875f-fac08ed00bda"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("84495437-1312-4d2a-8849-46371c080efb"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("8699fde6-6e02-4668-b678-cdc38d16673f"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("87eda7d8-0bc1-459f-80fa-f426523cc1dc"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("8a7df677-ef15-4d66-a25e-290dcf3bf0fd"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("8e6a69f1-42a5-44c2-a226-e0a81c8429ea"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("92d48b28-ab30-4c72-9675-4270abee827e"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("9378afde-cd3f-4186-b03a-2ce93a7aa559"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("9638bbc9-5293-452e-a7cd-ce90433f7133"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("96aee99f-b9f5-4a23-8085-a68991b03c80"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("98c2f040-4f88-4e6d-b91a-7e3a3b033bd0"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("9baf2404-7a96-44c1-a228-9f415475b004"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("9c233746-048d-4d08-bb0b-6e4cda4d0639"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("9f4f60b5-01ad-4f5b-9c52-86d170c2c895"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("a0bb695a-f979-4e8e-818a-29fa2d081db9"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("a1d38323-b870-4c9f-9ebe-a6dca6f5fa50"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("a2403760-6713-49b7-8e4a-c5b28d0ebd34"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("a524554a-fb05-4c4a-a69a-70c0c444bf33"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("a6358f74-1051-4dfa-8905-97d381125692"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("a7b945b8-5867-44e1-9d39-a1eb93c87817"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("aa0e4eb6-2d57-4bc6-a8d7-a8aff8e97cdb"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("aae616ae-efc9-4373-a34e-39f95947bef6"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("abb05380-6529-4c21-9d3f-a1895f042da4"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("aebb428b-c99b-4c89-9537-414a12d6f420"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("b109772e-27ea-4e6a-96d4-d81467f27d90"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("b41d27f1-1c81-4159-aaa3-ab7cf41d265b"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("b8aa9c89-7b43-4e6e-bb90-cd4e7ef19178"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("b8b78e13-7868-45a5-85e9-cfb97e2bfd82"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("bc097847-edf6-4766-8f67-765cb3f1e0a7"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("c1f2f777-dc87-4dc0-a47d-b0efe742bc4a"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("c3d8abec-f174-4228-bd88-be7629132b0b"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("c62b4d43-b09f-4e06-bee7-a8422c5a8a49"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("c9ba1ff4-b7e6-4f75-ba9a-03a30cf5d721"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("ca1db322-9c19-45a4-bd13-5ff5aabe8105"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("cf0fecc3-095e-4e29-85ee-b6d21824f01c"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("cf5057f3-d910-4499-b571-e39c8d4d7737"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("d0dcf0a7-f2ab-4df4-bf9f-6648d6cd9e3d"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("d648476d-d083-4f15-a6a8-4f3e1e519c5a"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("dc077741-16d9-4e1f-9eaf-4ee04e9b22d2"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("e1038923-d63b-410f-a787-d7247d4cd1e5"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("e1073991-e43f-44e6-af9a-1a67949017b6"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("e49d4299-a053-48e4-ac05-6761e385edd4"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("e505b018-fead-41e1-9776-5163c9af3bf6"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("ea40e4ab-2278-4b3d-ba08-6d9b321196fb"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("ebc0863c-afd0-42eb-babf-93cbde85b3e0"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("edbc1f03-de75-4830-a960-ed2561b39a48"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("f35ea29f-5753-41f1-9419-91ef94cfb9e5"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("f57b0ba6-77ed-41a9-bcb8-bd5954e3b90a"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("f8f93377-34b8-462b-b57d-61082c654832"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("fa084b9b-55a5-4766-837b-f4dee2add91c"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("045f5234-991b-4d1d-8da5-af3ee2dd3286"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("058d9135-d0e2-4763-9f18-40a4213cebd7"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("12045f34-a4ad-4f85-8fcc-b368c05cdd80"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("15974b02-138d-46c2-861e-58447faa82eb"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("1c942947-4cec-467b-b4a9-64625f78ec3a"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("1fe25ecf-61d9-4f1e-b8b6-1eb0fc01333a"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("2e9b06c3-d649-4f78-b5a9-6e757ce2b406"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("2f43c50e-bdbf-4d86-a48f-45e4305dbe81"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("384ebf7c-bd18-454c-84d4-808f8235a1ed"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("44c329c7-f791-4ef7-a84f-785ccf427427"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("684387d2-acb0-414c-bebc-d79a386fee0a"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("7c4accb0-3d7a-4b2d-9d40-8ead1853b3e4"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("8bafa452-5a48-4e6d-ac2f-af3b3001c86d"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("953b615a-ccd7-4d3c-9c7b-83e2063f8729"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("a291e486-dcbb-4f7a-a0a2-b6eaba27923a"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("b2d03918-cc9c-40e1-9f26-cc39a74dfb3b"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("b6ff5ad8-5295-4e48-ae54-d18d683cee18"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("d3113723-dee3-44a8-9500-ef40e0159569"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("db3b8386-beb1-45df-b19f-8f4299f9a511"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("0be58f5e-e1f2-49a1-9393-014ee916a0a9"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("119aa302-917a-49cb-8605-c02d18fb97b8"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("214a5e13-fdce-414f-998d-9127248be72a"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("21c4fb69-db5a-43d2-84f4-f4a66bcd6acf"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("2549c1b5-dc1c-411f-b748-ac8fa8eb8b96"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("2842931d-ba22-49d9-a210-5ec7da7f0e38"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("28990dcf-8b93-432d-ae75-577e666d99ea"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("29f4611b-bbcf-4b99-a0e4-31f99e9ebce5"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("2e5c7a4b-18f4-4b29-af19-b42f30c6590e"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("347b934f-660e-4b43-bbdc-10275d952d19"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("37ff66ff-3316-45aa-9e47-af2beb60a493"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("3acae947-bc99-4c80-910c-d2b061fed7fc"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("3b961c37-0585-4a8c-b1c8-e41d198d6ae8"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("3c3cf92e-cc87-4a76-aec2-f59db3b64a51"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("3ea5a79e-7868-4546-968a-658871805fd0"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("42d3c77e-cde9-4f3a-a863-2793f9cdab63"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("596aeaa0-becc-4bac-b667-a7bec72ed4a2"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("5973c3ed-9258-4032-84b8-ab5ad714ec2e"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("60814896-8c94-4042-b987-77bda8f41325"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("6328beb4-2df9-4e6a-bb38-04e21fbeb955"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("67c29be0-2642-4e68-ad1d-118d0cccbd28"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("72b53a77-e52c-4084-ae72-a03bf2119969"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("74411985-f1b7-41cd-81c9-bded310d51cb"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("87321221-5e60-486d-aab7-800ebd589376"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("9425065c-8e24-47c3-a752-d6f8a2e4e10d"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("94d6caa2-9251-4519-9adb-0460389096cc"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("96a6650a-050b-43ef-884e-32f954bff12b"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("a2efda0f-2935-424d-8244-5aad9d0e0bab"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("a67a06d0-786e-4155-9b83-c68de7b902c3"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("a96e5a6e-0c5e-43f0-818f-00ef2921b266"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("adba297b-1f7d-4268-a350-1263ada38a2f"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("b186e1b3-729b-4c57-bca8-d7ec734ae894"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("b6d63b4d-57ee-4910-8e16-a6f73ded90fd"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("b6fb36b8-1df5-44e8-a8ee-986d83dfa39d"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("bbdb8554-379e-4905-976b-294d6ed9a8d2"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("bf9600e2-0ab5-4aca-bcca-275d626f7639"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("c0826915-d479-4937-8d58-e36a121dd692"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("d1bbccf7-e8f2-4eae-991e-9b60c5055f27"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("de0ce7d0-dff5-4143-b2eb-e7904f8053af"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("e33d8fba-08ac-4ebf-8e9f-2fb8ec87f9c4"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("e75643f0-4bd8-4c16-ab99-ec025c0590a4"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("f07194eb-fba3-4579-b59f-875724d0ac95"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("02a4c2f0-501f-467f-b8d1-49481192f900"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("19931f50-6aed-4163-b91c-e5ef4ae249a4"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("7e9b84bc-ba88-4c9a-9de1-48c3ed5dd325"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("981e0f7b-08c9-44e2-8079-cbcdc9ba5100"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("ae87dc22-8596-46e2-b7a0-926bcb494a1a"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("bc359535-c27e-488e-a3c8-81f385b61a80"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("ea1bbdde-7d04-44b7-8669-7919cb75f206"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("eadb86e5-2061-4ba3-b944-b72654efe25c"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("f4003394-10f9-4023-ae92-4baddeb78356"));

            migrationBuilder.AddForeignKey(
                name: "FK_OwnerAddress_Owners_OwnerId",
                table: "OwnerAddress",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id");
        }
    }
}
