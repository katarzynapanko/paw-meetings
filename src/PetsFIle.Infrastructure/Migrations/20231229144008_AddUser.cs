using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PetsFIle.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("0380431f-2a91-483f-91b7-58c5bc695343"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("0779dc2c-e788-448e-ad4e-30410631451d"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("0f74d154-70bc-407a-a4e4-d080c0f97342"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("10001f42-732d-433c-a98a-c4a0c0b9c1e0"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("16645769-e96c-4dce-af81-b3ef6772443c"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("1893cd94-802a-44ce-8a46-496d02fa42e2"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("21c1ada9-3edc-4721-8f09-4b07cb616136"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("30cabea5-162b-4194-9ac4-3f876e14c397"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("35d04b42-eb8d-4816-b339-8280f3372c1e"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("3e07e2fc-bfc1-434f-9f2a-232814ea4662"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("3ed8f065-d3dc-453b-8056-bb112dd2d3c6"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("408443b9-295a-4a2d-a40f-c604cdf35699"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("4782b564-c927-4b9d-b296-3dc12c58e7b7"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("4c33fc7d-6438-4d47-b3ce-5ab4900e2273"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("4caaf810-a45e-4e5e-8fc5-5fe49c6ccb12"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("4d26db57-d47a-4d2e-8785-a63bd60e3740"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("50a4618a-7133-479f-ac4f-919ed23a3fc8"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("54c14ee7-73f3-44d3-bdf3-99127d10923e"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("5c1d5af8-8a7b-44e2-8a6e-31f2bc8244e3"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("5c337906-c071-48a9-8170-9302de4ac395"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("70561884-e744-435e-8305-27d13481533b"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("708f08ec-90f1-4c67-b5e3-5ae3c267f28d"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("745c84fb-fd6c-495e-9cc8-33dde25fffee"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("7516ba1b-d3d6-4a56-bb4d-6600be49ad2b"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("77b10aae-d613-42c2-b4fc-f0c10e7ed5c1"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("791ec2de-aa54-4b90-8b17-dadf2852c42c"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("7c27d8fa-4ab2-43e9-b904-0957496ab8d5"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("7fa38886-02eb-4aab-9321-0476122ede78"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("7fb5d896-972f-435a-8ade-1f3fd3519ab3"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("8ac0132f-35f5-4cb1-8f42-b07f3e22d226"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("8ce399e6-4161-4784-ad51-a86e9cab4098"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("9cdf97f3-56a3-41bf-9c7c-57e042d66b38"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("a32acd3e-a011-444e-a766-86be60cd5757"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("a363627e-7c47-4e5a-b1ce-a651844b377b"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("aabbf190-687b-4922-bac4-50a0e03b901c"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("ae276a81-79c3-42a5-8f69-56f161ed303b"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("b28b1c7b-f21d-49cf-854c-a0d1ebc3bad1"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("b9f5d586-6189-46ef-9fc7-353a5989ca44"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("bcd7c317-9df4-46ae-8799-943c2b9a1f0b"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("bce9ff49-d081-484a-a9f0-672e0649294b"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("bd6d10b3-7674-4e92-b182-06cd270d02d9"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("bfd87b71-6c76-4ab3-9a19-482497cf213e"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("c94f8b83-9fed-44a8-bcfc-fae4962dbe6b"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("d30ef5f2-1feb-415a-abf2-f426786558c8"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("d91f3765-4e55-4043-9e1a-eb5bdf5bb676"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("e0afa3a2-43a9-48ac-a3ae-dbf0a1e5c33b"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("e16ea041-19ac-45b0-85bb-ab7608968f3f"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("ea560724-c5c6-4629-b825-65c7584336f4"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("ec68be28-0fcb-4312-864f-23e492c99157"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("f19261b6-9453-4bac-879b-3aab7e369759"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("1a7d9427-7fa8-41b3-9684-f3ddbd9546cb"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("4c9c977d-fbe6-4690-9fce-8b2a1076666b"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("629b880e-aa6d-4282-87f2-16f74e966591"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("63c172cd-a108-43c9-b452-fd2597dd75e9"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("64cbb4cc-5049-4b4d-ba9d-4b0e6a12d1cf"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("698c9b69-a847-4ac2-af0a-ffd9fdbcf70d"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("6ed77ec7-d61a-4aa5-9a99-2212d3ffabb8"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("7a947ce7-f90b-4a98-8c48-f59ebf64ad6a"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("7bf13508-b247-48e3-9b3b-672a87d6daaf"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("7d809aa3-da05-4d46-ae82-7a4916723143"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("8042f4cc-3bec-4357-88ec-515f303df842"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("9263c3a3-416e-404e-93d2-fd0f0cb1f302"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("95564f49-8bd3-4438-beff-bc1a303eb7be"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("96be0a85-0ee5-43d0-9fb5-c3a6a5943190"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("a01171d2-30e7-41b2-bf3c-bd66612b9ad5"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("a172ddf4-68af-4a3c-b91a-3c0c9d071357"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("a33ab54c-6ea0-4dcc-a59c-9c05cfcbefc0"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("a6d7c560-887c-4171-8b2e-d06e6445a459"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("c83e76a1-eae2-45e4-b2c5-aeca90b69ef1"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("dc67b72a-4997-47fb-8aa0-2f7178b11bdc"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("e671bc41-ef69-4da8-a19b-af42b26b78cf"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("eb8ebb20-2970-4bb4-9449-c868933a63eb"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("efa4dd4b-ae6c-40ad-9ee6-9b0c3471e7e0"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("f47f683f-26d4-4cfa-8aa5-3dc7663ed691"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("f564fbd7-7809-4ae8-81ce-9e88f2364f63"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("019e8c5a-fccb-47e7-9944-cb703f3dffd6"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("026c278f-8125-4890-8bc6-87a00ecc1493"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("04ae2055-c75a-48b8-b69d-ffa44117d162"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("0b558e45-2809-495d-95fe-fd5ed5254fbc"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("0fbe4c2a-9e1c-41e0-9539-770abe838607"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("1169baf2-0803-4fbe-89ab-2bfe1fb58805"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("11d81cdc-2b41-4236-9a8f-e33547829aac"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("126c7493-ff0c-4279-9f69-3d76e1ef3162"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("131d7329-6e04-479c-aaf2-3c0824fcab0c"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("1688cc81-22a2-4ea4-a37f-92e53b1ce612"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("1bb62d68-c523-4ae3-849b-f7029fbdcddf"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("1c538488-5a45-479e-bcbd-1d42284cd532"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("208373ab-953f-4f6f-8600-14fd9f936d0d"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("23ee209f-fda7-4c5c-919f-b07ed6318c90"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("2a7f91de-e2c7-4c3f-9452-a0bf2cdd1e83"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("2aef315a-5b61-48a6-8953-737f498b528b"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("2dc13794-983f-4017-88ad-89935ae12380"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("2eaf6ee3-6255-444e-b807-c7416a82fd06"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("303f0c35-5bbf-4c3d-bd8a-d7a6f33bd871"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("3272dbcf-59a9-4e16-88b4-5405c0d093a0"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("3314b924-6228-4e44-b4ad-403e07322130"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("3506d5e4-1958-46c9-a635-634a208aa86b"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("3545d7a7-c6d5-40c2-95b7-0b545d288582"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("36871fdf-a681-476c-ab9f-021436d4f9b3"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("37009036-a084-4edc-8648-97207ba7bf7b"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("398aea49-0f4a-4f5f-9299-c7eaff21417d"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("3a655685-abc6-4efc-8eb2-4a543b9f41e3"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("3b0ce148-0948-4438-ae99-41e299700a9b"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("3cceded3-00a7-4f68-a3cc-324ca405a7ac"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("443b1bc8-c629-4356-87ce-43b94082b794"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("45f97155-7304-4e68-9a93-335793249eca"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("490c3cdb-c1c2-4c03-b3d5-ea66932ae639"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("4ac7c521-5f49-4b83-91fd-45649c92c937"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("4ba8b882-3deb-47e8-9637-fe9babe7bb59"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("4c009f62-39ff-4c9a-ae41-fbd8a0aecbf0"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("4d6f07d9-5bac-4614-98aa-b0d9cbcae333"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("4fefa680-58dc-4574-97c8-2b0376d6bd7a"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("5248cf2b-35d7-4442-9796-77adb6041791"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("539b60e3-a606-4e8d-b825-0b82091365f6"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("578ababb-aa61-4e27-a589-c84a5cd86725"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("5c7ca38b-593b-4b29-8748-afa0eba65f31"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("5d4b5ad2-3cee-4d85-8a9e-d6ad5d3c45fd"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("5db0d45e-2d83-4bde-b640-a13f486af37b"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("637556e0-90b7-4e8f-99b8-ddcd8809a9ed"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("666d055c-e7da-4d34-85e5-5b762aef2144"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("669d3240-7cc8-4454-92cd-59b2b1b43a32"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("6865b351-cbb4-4e4b-a412-822f3a118843"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("6918f7f9-b321-45bc-bdc9-10b072aebde5"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("69563a14-400e-45d9-896d-bda4ea923f94"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("6b6033c8-85e3-44f4-8ade-43df4814c509"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("6dfa86f3-7e67-4369-bc12-b3a51aad01e5"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("6f70d03e-cb9d-4c1d-8931-5cc811e7f545"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("723e5a76-df58-495a-b249-a04b7108c0e3"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("74310f5c-2a8a-4aed-ad91-0a1b2bd1ecb3"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("7500f22a-c879-4742-924c-c506bd1c1027"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("771bb554-7fe4-456a-86b6-f711e225232d"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("7f0ef5e6-7ca9-4a3d-bceb-f5846350d37e"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("7f57b1bf-3f95-46df-9082-78956ae8d052"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("80962af8-491e-4311-9bdd-605048358928"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("8119219c-147c-4535-ba12-b070643a6586"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("816062a8-c383-406e-a4ad-462a7cbbaaf7"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("83de430b-10bf-4ff5-835a-1c35bb7e0a82"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("87dbe55e-1a51-487e-bbf2-c06f756c6ca2"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("88081b91-3030-48f9-8296-dc467b8e12c7"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("89e3684f-9a46-4686-8c87-7f975ad836be"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("8db0bb0b-cfe5-402f-9c8a-e4e6e32b3b8a"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("903945f2-7f6e-40d5-b9fd-ff3646377e9f"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("90fd2d06-770b-4f29-99ad-176514bfc27d"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("9265fa3b-507b-49cb-8383-b9500ebcc758"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("935ac570-bc61-40c5-ae47-dedeb9d4b444"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("9adaf0c0-b834-46f4-9e0d-595f5844f3e5"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("9aed6858-c3bc-4ebe-800a-a95d9b7005e2"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("9ba9eafd-0908-45cc-b118-99f368c0fae5"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("9c38893c-10e7-4183-b2b0-8564e8bf7099"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("9d52e1c5-836a-475e-9e6e-3c5d12d01ec2"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("9dcd8cb5-66c3-4628-b910-6aa2c5f12458"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("9dde11e4-f047-46dc-8df5-0604a2d23880"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("a1cef83e-cc91-44ac-8829-810242a10b6d"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("aaf9dbd2-7d22-4c12-af1a-d3bcacbd4a41"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("ad5afa70-a161-4914-a7fa-c106b9fd34cc"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("ad8e3d27-4b9c-48d5-a484-a124bf7b8165"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("af09e0f3-a698-400a-83df-603949ce969f"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("af525f83-9b1c-4de2-8811-c382d5bbea96"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("b5b58500-1c23-4207-8f63-2c4601625a80"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("b7db7ca7-4385-48e0-822f-e5a38d1b605c"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("bb874a84-3c21-4f26-8625-39a80d71d462"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("bc282da8-1ec2-435e-b2b0-c62dbe4d18db"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("be346b02-984f-48de-8c64-ade53c9dbc70"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("c4af494a-8ebc-4864-8bb8-12dc49edada4"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("c5654abc-0057-4c2f-a8ff-9a78d1c00bc2"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("cb12300b-f263-4461-98ac-86c129dd9891"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("d3b1eaff-5876-4c27-9767-96ab57381527"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("d5b12ed6-4641-4622-a34a-068b71b4606e"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("da3ed200-fc26-4b44-839c-d944fc21ff67"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("db1bfe8f-9363-43b2-88af-dc5186e69dd8"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("e248bef2-a6a8-4c7d-be3c-358c6b36f196"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("eae9b954-7232-428c-941a-acca5a2ffd7a"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("ecad70f2-1625-4e86-8d59-68b71d452c07"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("ed3c62ed-03b5-48e7-b547-7e2ae6f6e19f"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("f8a2b05a-7772-4bfe-af28-8aab223c26a3"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("f9f46ef5-c6a8-496b-be83-42fe834c5a9b"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("fd76f8d3-f294-4cbb-8657-778d6c046757"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("01680bfe-44e6-4fef-9bd5-339bba533ec7"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("03911ac2-c255-4b89-8fd5-52024cce2711"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0464a97d-7139-4169-81c3-1790da9e9ac7"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("048314b3-c26e-4ce1-86b4-7fa98febffc9"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("04f830bb-eaab-4fbb-92da-c7867a9aa165"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0767ad23-6d30-4d70-8ca7-73d7537261fb"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0821f020-c8e3-4f83-8383-46f5098d7edc"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("084cac44-5a4a-4401-9cda-15fe38acc1ef"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0879ddd5-f538-44b2-8334-617d2dde7364"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("088d13d8-0e16-444b-b679-ed43853e404c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("093391a0-3943-4439-9d13-76d00e3e2305"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("09886ac6-ce5c-49a4-abba-7d46bc08affe"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("09992585-94c8-46ff-9dd1-f4f5e40212e1"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0a2d5a46-68cd-4802-8d87-ed449f5f0c15"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0a2dc66f-d48d-4e11-8c87-dfdcef6ec28f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0b80ac7d-b3ba-40c9-8ad9-4eff35eebeca"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0b8615ec-75ad-48dd-976b-8cf3e590b3c1"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0c50f4c4-7b88-4cf8-9a6f-e5540a361b02"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0cad2f39-e46e-4f83-b60d-a5dfe12a64a1"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0d37ebf5-f285-4341-8e6f-cdb7a0207243"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0f68447b-c430-4112-a4ca-5fec386a9baa"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("116eb0dd-038e-4a6c-b52c-84bf4dae8d1d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("140ccb80-171f-4bb3-8ceb-1ea39864dfba"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("166bb6c6-9835-499f-b5b4-332f53b2e222"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("17be3eef-62bd-4d1a-98a2-8e2238b6ffce"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("18b7449b-08ac-4438-bf98-0e9d37da7841"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1926a8fc-c200-4733-8680-e22c27ae32ec"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("194253df-bb9a-493a-acb0-f15140a2545a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("19ed1778-8cb1-4fe3-93c6-7aa59c623f9f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1a3075f7-cbfa-48b1-a2de-838223980691"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1b219f47-c50b-4515-a897-05617093b27b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1c994005-4898-463b-bc56-9f713fb900c2"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1d4a8589-829a-4503-a52d-99913089aa53"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1e1994ae-8e47-4fa3-818a-7fe91614281e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1e37fc2a-57ac-4c0b-b3b4-fd33d1869737"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1eef26cb-1c47-4fdd-a787-28d84b461b68"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1f9d3639-534d-4e82-a325-be7f841f2feb"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("212652bf-f4e0-464e-affa-be293f943e74"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2343120d-158e-49b9-b9ac-e7b5c1d5f92a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2372e184-26f2-4ead-85c1-1fdbb5414cff"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("24cac3ec-2a14-4612-a235-33df0bc49f47"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("253c1c65-6213-4207-b142-debe55e31075"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2570f5ea-ae0d-422a-9f78-066d32832316"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("26407616-65bb-4410-89e3-8aaeae7c61c2"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("267d70b1-bd08-41b9-8a31-65bafe165500"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("270ff418-af48-4640-ba0d-c92574fb0d71"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("28399d92-c0b6-49f2-852e-f0504d648518"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("28706e78-f263-46da-ac5d-2fc9c9ce8ab4"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("29b26cdc-7e85-4c07-a455-58d38d3dc4fe"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2a1adf91-65ef-4e58-8db3-58ca172753a0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2c26a6b4-3236-4949-a145-1dae5f477e98"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2d3a7a32-ebe6-43e6-8439-24b873c034ac"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2d7c0599-95ed-4c46-8f6e-97cd801de4a4"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2dedf7c8-c821-4bb9-9afe-cd3fe97fcbbe"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2f354dcf-f00d-4288-b743-aa54dbf50ac7"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2f4384ad-0ce3-4ad0-a97f-b5374e43d197"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("304d0184-7baa-43fc-ad47-d127e7418cb7"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("311631e1-38e8-4a3b-b21a-493afdc81e15"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("31de2fa0-95b3-471d-97c9-33e5be5e88fc"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("3278dd74-906a-4709-a15f-32ad7aa25074"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("338fd116-5834-4870-a807-5494bb333118"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("34a8ae77-e92a-4021-9895-66c297a340c0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("356e04a3-c850-4dc1-b10f-eb4ab3359882"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("3585d010-bfd6-4882-8930-5bfe3126ef46"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("35b8c348-8203-4f74-9d71-b327ebfa24b3"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("386c4648-0f59-4728-bd87-4ecaf9629cfd"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("387bb0e6-f27d-4c7f-96de-c0860975ab09"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("3898ade0-ab99-4f55-9263-51d34fd460fc"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("38f8b2a5-f047-453f-9816-06b370a3e703"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("3bb81d92-1f58-4ff8-a4c6-8b0524e4a9fe"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("3c7c0ba9-f5d9-4fb3-b9f8-4618e223b54a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("3c853b7b-054e-471a-896c-b02610efc5de"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("3c958aa0-c5b6-4958-91c1-14854c816599"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("3d4dde51-62d6-43fa-859d-39792d275c97"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("3d71e179-3e3b-4a83-b09a-44ef3ebf02a8"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("3d87eafa-99c8-4048-8fdc-93c65e09461e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("3dd26f08-9489-41c7-b75d-f2d387c96781"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("3ed4a03a-6504-41d8-aa99-8aabcc6f7cbe"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("3ff52b32-bd18-4991-a130-a624fdc339fd"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("3ff5cbc1-e333-49d8-8d23-f4dc9ff3e5df"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("40bbda74-3089-42e9-804d-46a1546886ab"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("412bd5e4-1b2e-45b5-acee-6aa3d8548cb3"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("41ce6a81-9b27-4a12-8a6a-03fc53d673e7"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("41e9ac4a-8321-4b46-a3e8-f541f7d5d6c6"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4363dccc-43dd-4340-a7ba-d2cad54624a6"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("43b37b41-f0f4-4b85-a7a0-c359bc9c7dac"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("44101a3e-f62d-4893-b043-9659dfae2c80"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("45147866-f8fe-4dfa-9bc3-24c0640d71e3"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("465e2997-7ea3-4ba2-8246-91aabf414249"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("46cad2cf-3d61-4637-8a2d-1537d9eaf015"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("46f35201-e012-4968-bfb6-efe3d86e1581"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4791ad0d-7a91-45c6-a300-9eb347102708"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4a1322ed-918f-4e18-9509-f61563344305"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4b163f00-6383-4a98-a286-fe427f5f320c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4bdf16d0-d3ba-4e88-9930-56e317e1ea12"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4c8d1e8a-dfb5-46a6-b06d-0dd0dc912d08"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4e9bb444-1b99-4d4a-8fbd-578270649016"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4f84ceed-c3ed-4e3d-a9e0-1c40cd0d24e3"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("509d7c0d-f275-480e-b3dd-da510f784956"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("50bcffcc-b5b8-4300-9f34-b1a6345efa88"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("50ea0c01-56da-4912-9347-643e35b8ad19"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("513fcfb2-1679-49a5-bd47-324a14ee5bad"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("52474629-e232-4763-8515-3d10aa9afe0d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("52e8ef2f-a602-4812-988d-6fc271232a82"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("5506402e-a9e1-4819-8c58-4bdb16107208"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("555252cb-ce1a-47a1-bfa0-e3535a1dd1c5"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("58815ec2-0d1d-4f45-aefd-2ba297a8a4ff"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("589440d9-f54f-429e-98e1-a4c0356f1c66"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("58cb6a6a-885d-492e-9343-eaf6a5726ac9"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("5d8b5339-a1bf-4e1c-94ff-3be20ce9f67e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("5e6dce34-a5c3-4d2c-9912-afe9e00f93f0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("5e8a7e55-b3f4-41ad-9532-2aa689358f0d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("5f099656-61b5-4b4f-aa0c-83b855fed0fa"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("600dc686-1d05-4c21-b2b0-b97fefa3743a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("60253779-bfed-4b10-9b68-c4757763cbb6"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("607af096-2f97-4803-9746-f5f41d3957fc"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("60c7b134-52ba-4d4e-85a5-50223df8cdaf"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("60da468f-785b-468e-af0d-c2e0ff3542c3"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("61e3cbc0-5747-4eca-b925-8048480593c4"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("62353aed-d672-4bb7-9670-6b07e6027340"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("62c42d1b-4cc6-4a6a-87a6-d0ba50f140f4"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("639923b2-d20c-4c21-babf-15aa8261970d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("63d6010e-4752-4d93-bfdf-8d228f2be361"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("653de686-640d-4a36-810c-abdc7bff6bd5"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("65829ce6-c0fa-48da-9e58-9ff71b7adc50"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("662e91b6-acfc-45d6-a39e-2a542618f18e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6846124d-d9a3-4bcf-906f-9b6f4fc40bc7"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("68f37dbc-c771-43f1-9e87-67c709931851"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6955448e-8b4f-43c2-b513-aa332ba56d7e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6980fc46-c12f-4d62-abd5-2a612980093f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6983e91b-44a3-4b23-b1ca-410bb56c771b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6a3d2895-309e-492a-9359-cc9ac6136d73"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6b1fa673-c9a6-4fcb-bd56-dae9b2cc1eee"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6b6873b0-c35a-41fb-ac13-c59069683265"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6bc56ac2-3a51-42b6-9440-9c3d876c80e4"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6d00f95e-bd77-4a6b-b15c-99997ec354aa"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6dba5916-45f2-4574-a099-fe698f296bc6"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6e04906a-c1c2-49db-8b23-0634104f371d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6e49ae11-974f-4484-af8a-02ccc9eaf919"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6f5f5a29-c21f-4126-8999-b2a47dcdb83a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("720530ad-d87f-4ad8-8405-f8b9449f8fad"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("7351c6e0-ac41-48aa-895d-c492df299011"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("7433d28b-166e-4002-adc2-4e935ec4740e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("744f1dc2-b08a-43ba-b955-c070fa4ca7ea"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("77833a76-a903-4972-833c-21436f1da5ba"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("77a2966c-ce3c-4eda-b98c-45a40cd8b905"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("78fa8fee-a21c-4feb-8ab5-8ffea557d38e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("79154f67-5da8-4801-862b-fbbbe47c31ef"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("7b1bdae1-7fd0-4c70-9c7f-f95dbd80c702"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("7c51f86f-1fe2-4053-b7cb-567928c21276"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("7e05ec01-91ff-49fe-b7b7-f4a26824cb07"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("7e15da88-d2c4-49c7-a157-9dd2e302f595"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("7f3531e2-ec0e-4a71-84c4-f4bbefedea96"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("7f653831-b3b1-46ae-9035-882b4009314a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("82f98c33-0261-4b2d-8b07-bfbeca562dc9"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("834952b8-811d-43d5-8f0f-717b55c86027"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("84020ba0-7d0a-4e0d-b660-785288276bc1"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("863017bd-52a5-4657-8c03-a0d6988e9d31"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("87a27699-283c-47ed-968e-46f0010c794d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("88111a0d-6601-4e88-be8b-66dd87fd1904"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("8942e924-cdb9-4e7b-9267-d9955dbfcca8"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("8a0ec8e9-06ac-4500-bc51-af8c6ce89e89"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("8b00848b-d275-4797-8440-fd29fbad8299"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("8cf96c93-2bcc-4f58-aa78-5cf9ded150ed"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("8f1f64c2-c55d-453a-a6c7-36170243d8e8"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("91561a37-e8a4-4c33-8a25-fe22474b4f9e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("91a98893-4bdb-435e-bdd5-f5d91dab145c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("94512428-671b-477e-a529-1c40ac72dfbc"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("96daff3f-01d1-45d0-9129-ef666659bcad"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("976b4899-11ee-4e63-ad20-04e3b6c81477"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("97b39df7-ab73-4fb0-9403-674684cdc039"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("98be9015-1d8d-4031-a11b-9b792cc05346"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("99e2893c-a42c-4407-aec9-05d8bdfbbab9"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("9a8d9cdc-001d-4a96-be98-a4f15f182ffe"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("9a946417-7ef9-4351-97fc-0c9ab4a1553a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("9b01cd03-657c-4db8-98ac-581caa36fc88"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("9c80cecd-4358-42b4-8fd4-c4ac0290dde1"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("9d321838-d4fe-4640-942e-8ce19032bb8b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("9e959cbf-8505-409f-8596-ea97a8b32d23"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("9fbaa40e-c146-41ff-a7fb-3b4eb43d58a2"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a028593d-1eb8-41bd-8551-5d7af62a26fd"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a076186c-7365-41b9-adea-9a662b431cf6"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a15c45da-e045-4322-8bf7-2bb99182dcc8"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a1c87a44-71e2-4646-b576-90bbaa58dedd"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a20296c9-b8a9-4160-942c-9a788f72da80"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a2f95b8e-5540-4168-944f-0229b5023e10"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a30f5595-d983-49d3-8d91-9c8b695216ce"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a57c32fe-35a2-4669-b1b8-3af1e8a522bf"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a5b4517a-e5c6-4aa9-8c30-23ffb0a70b3a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a64e7d38-542a-495c-9729-23b0937cf077"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a6f479b9-7032-4738-8340-8b24ec39b8b6"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a719e6b2-6fe7-40b3-b013-cf46377850ac"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a7682b06-869b-48f2-b0e5-a478edaa3bd0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a8509c21-89c3-445d-b104-080233cada63"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a8acba3a-ca07-4dfb-86bd-dcd705a8fbd2"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a8d7b5e4-02f3-460e-bc9d-ccc3bbae9a75"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a8fb764e-4d6b-4a14-9dd2-b047f4671ea6"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ab9e91e7-adae-4492-b641-feb4407f7f35"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("aba5d4b1-5d1f-4f3a-8cf7-ac8f6a5359ab"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ac5f51ec-eea8-4aec-9f9a-93a478f80303"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("acf04327-526d-4724-876b-52893421fd54"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ad622d42-b13e-4b09-97b3-44b01a372cbe"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("afa603c3-7c88-4926-8fd9-45ba7ffdf441"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("afcefc31-49f5-4e22-9459-1ed74e56cd3a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b06c8557-1b6e-43b7-9658-072a893805b9"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b1bc803a-0794-4453-a077-fa0625f7d9df"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b1f1dbbf-673d-4a93-9033-eef721cc1c43"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b20da405-3dab-431c-8336-11b77511ab9b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b21e0d76-d3ae-40ca-a9df-a29a6d9fdfff"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b2808bda-8d78-4c38-be83-802a77ea1d01"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b2c09345-a255-4f4c-acc0-af2d777dfb87"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b2c5b8b9-1569-4351-8f8f-01636097a876"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b30bc4fc-b9ab-4298-af74-232f51f4d1b3"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b4a4b256-e01b-4645-a11e-1b7d0a947bc1"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b666adfe-fd74-4fe8-9dbe-d229c20a4572"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b67670dd-f91b-4e6e-9908-ea1ed14e228b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b7645c34-09c6-474f-ab2c-75370450766c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b802ca69-10d1-4fc1-930a-47e8854938d0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b941b336-bc6f-4c29-bdc3-716255cef070"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("bbbd9e58-10b9-4b20-add4-51b8e8b8013f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("bbffc636-82d4-40f3-9c90-8b1b879872c8"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("becf68e0-a668-4c5f-ac51-9f20a2cb9c43"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("bf2b9981-1fac-4832-8126-86075d7da6a9"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("bf65a428-6753-4f57-b2b3-fbf86ac9da3e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c15732eb-1575-45ef-b9c6-edcfd86f197d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c1eef6a7-5b32-4286-865c-fa59bfd45ca5"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c3a9b54a-39ff-4c9f-a022-b1ab69e048d6"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c430388b-4c8e-498b-87ea-a182a66347b9"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c5fef073-6bcc-4912-adba-dbd6b8ba25e2"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c637cbd2-ac3f-400d-9267-f37cddb04393"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c7330fa6-2d9a-4bb6-9e98-684f52d79bd6"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c73fa445-25f6-4866-9311-081ae53e4b0f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c8ad3d44-8b8a-4204-b486-a7f8d1931fd3"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c952040d-a30f-4ddb-b228-101c1bd4cbc2"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c9857ea6-7155-4788-988f-af4b04d92016"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("caf19498-bbbc-4941-9312-1ec381d128e5"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("cbb64cd1-0cd1-4e5b-b02d-acfe2da64870"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("cc6f82f2-18f5-479d-9079-e0319fa136c8"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ccdd249e-2b7e-4afe-9bdb-25a192b1e149"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("cd252e12-7d7a-4b0d-a8c6-1da7d798bb90"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ce707b78-d7ca-459a-966a-9e61790f7811"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d01dc10f-0b9d-4521-97e2-37d8335835cf"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d0a85244-3ba1-49cf-9a9b-411334d13a93"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d13e3082-b919-4528-acd2-4b3151e04190"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d2fcd117-ded9-4d55-8a6b-d6a5b5039a5e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d3348247-3c12-463f-85cf-4f3d2b2bd72c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d4d12f1d-30b1-41dd-b901-67ca17db3181"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d5ece201-0d28-482f-92ac-8516f4672334"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d641efc7-3541-4c2f-aa9a-c251c57e7c1d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d686670d-f24f-4165-b61a-2fa3967a56ed"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d6cb7806-0a4b-4eab-bd27-38e1a9ee4b04"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d83c943c-3ccb-4371-b970-628925b592c0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d899a902-908b-4da1-9bb9-7bd72d9cf3e5"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("da5344d5-23db-4728-9985-f3d73befda14"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("dac95288-eec3-4cd4-8cde-b8b4c28d8c04"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ddd018ab-8ed3-448d-882a-5edb6091e52b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("dde28d89-bb08-43bd-ade1-98d97e845441"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("deeb134b-2a66-4264-95dd-c5a7c9216450"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("dfd24015-37c7-43da-a924-567b95b5f602"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e084c0be-d18a-4be4-96dd-6c70155c7188"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e13792a9-7727-49e2-9f0c-aaa5242bf8d4"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e14d80d8-c7ce-4a7b-a486-dfa5741a3366"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e1f7a9ba-2b42-4010-8839-ecc244a52bf8"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e2104e7c-55ad-43bf-9860-05923cfca2f0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e249e2a0-f4d0-43bc-acb7-d727c67e5c59"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e39d0f16-6a6d-47a4-af17-70294c958cee"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e48dcd8d-29d4-4bb0-a23b-039497eb46a0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e50cce81-546b-4dcd-b247-e68f5b53a585"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e672d363-1138-4bdb-aa90-e0b07d16d0f7"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e6dd5e10-9c8b-44b5-b24c-f2c8cfebb48f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e79d0467-c74f-40f9-98ab-251b8b598b7b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e7e744a9-8cbb-4274-b674-78b87e7fc039"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e8fccdb8-b64c-43fe-9e24-66e0504692cf"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ea02dcf5-672e-478a-b045-ac5538021a16"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ea3943a5-fddf-4f9d-a36a-875373a4dcf5"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("eb0f7361-84a0-4ca5-a680-f319c7fe42ac"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("eb4922ac-dcf1-45c9-8004-6ed8c6b39958"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("eb7eec6f-6788-4275-bf2b-12a0208838b7"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ec60e009-152e-4e87-b691-b2217f647d4b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("edda4bd7-954d-4368-a796-c2b9cf67f2e0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f07565d0-76f2-4a64-9c46-02827bee2a5e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f27c1942-efa3-4923-8083-531d3e6470fe"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f315d108-d0b0-4f85-8720-ddfddd72e527"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f39d94ba-1dde-429f-a25e-43d4f889e1ad"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f51dc71c-ce3c-44d6-aa06-b6c85851539b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f5aade08-aeb7-4c58-803f-ff821d67ef09"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f5fa8472-4a89-45d0-a5fd-571d8a5795a6"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f65f3d48-8ce3-41af-8bf1-41377cd00f94"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f65f8473-aa53-4ef5-9287-8c974b93df43"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f6ed6565-603e-4b9c-ba35-875e9ca7f230"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f74a3954-5326-4795-846e-264f102dffe9"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f7b76885-0518-4900-ab2f-5770d07cd15f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f8823a8f-0fc5-44d5-bb7e-507fa25c162e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("fa3acf5a-f5d6-4ed3-bf68-74da3efc7ca6"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("fa42cbdc-e6fd-428b-9a9b-0146d27ad32a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("fbed012b-fe23-40e0-957f-75807a7b9073"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("fc108f84-0dbf-4700-a351-f7169016028a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("fc3a1c76-091b-44a4-ab1b-2a877cdd6285"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("fc96f124-e809-4992-9987-48f1a29da246"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("fe39f2bf-1837-46fe-b996-fe721afb9812"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("25c0e5be-95a2-4569-9c43-e44e1b3e8ce6"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("5c7d6607-83dd-4195-87bb-49189ff0f5fe"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("06e68c47-2908-48fb-bf0a-d577ed1fb737"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("2bd4e8e5-f655-4967-af56-0f289907f4fb"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("4f2457d8-73e3-4e44-81aa-2cc1c33b975c"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("6ed9a22b-43b3-44aa-acd5-1afde26c3886"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("79e350e7-a868-4361-8c1c-9c553fd8e805"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("a696d93f-c9f9-4cda-ac14-1159c1c8fd8c"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("baf1a844-c5ee-48c0-86e7-be46490fc54d"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("cab93e0a-478b-47cc-83cc-4033f19d1cb6"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("ef2ac790-932e-4046-baf4-7455988ba402"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("0096365a-4330-4ba1-90cc-882ec5fd2983"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("070ce240-1ffe-40c6-9e33-f583aa6996ef"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("07f5584c-6ff3-4720-939e-7f6077381eea"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("082bc7b3-5ea9-4e9c-8426-e079479d13cc"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("08b80e81-7a41-4d17-adbd-b2743dbf32c9"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("0c187efc-747b-42c6-8335-5c92d5babcb3"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("0d042a50-bcb2-4780-ab3e-adf232e3e7cf"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("0daed55c-208b-4c81-9b27-0b422763f629"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("0e60231b-8bf2-47b7-9119-262bfec4a1fe"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("109684b8-4a63-44c6-a669-a84ce1636701"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("11819aa5-5e78-4ca5-9ce3-d968769fdc62"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("11cb8fb1-b388-4f48-ad8a-101ccfd652ca"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("1219825a-1bf7-4b22-b096-32f72011e207"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("1348d155-aaca-4cf0-a7f7-bc20023cf6fe"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("1786885f-22a9-49dc-911e-64e2c9259b39"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("1c40e4ee-4a7e-448e-93bf-9af5917bbabe"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("1c65186e-2ac9-407c-9ecc-5c19adf14971"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("1fcab780-7679-4d4c-bcd1-7e1d0f378ed5"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("22b386a2-71f5-4e91-9b55-879449b93fa3"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("27b9f3bf-9a47-4c12-b743-4d9d95bfca40"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("2a62e954-cdf9-4460-9b53-9e85591b3912"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("2eb17d89-cc1b-4e15-856b-aa611d7d7561"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("2fbeccd8-5105-4153-b7a5-f1e92128e9a8"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("3118878f-3520-4c39-af9f-e22246946d1b"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("36be2138-3096-4e06-9e21-6c75238e1a1d"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("38d16719-d19c-4945-8d09-a9165c19d568"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("38e4e090-4918-42d4-9341-f5b6e540a4ec"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("3ddce316-dc79-4a01-af69-ee9d11e460b0"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("3ff43ae2-ffd9-4b24-acdd-471ebb5101be"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("42bb3c76-fdc7-4764-b425-eded5c7ec7a5"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("43446cbb-25eb-4369-a206-1164474484d9"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("44610089-2493-4587-a13d-b10e6db6ac91"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("47facc0d-5935-4749-81a4-79b1961f6de9"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("4cd32d47-f0e3-4510-a9a9-02be7d63a663"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("4d30f7f2-6ab0-45de-8d02-38654ef1b2af"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("51b09774-5c33-419b-ab50-eb348502b5b5"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("53d7a21f-05f4-4bda-8058-693923dca93c"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("543bf592-149d-4f0d-abd1-35fcfc25e18b"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("550ab457-54d2-44a4-8978-af3f9e97b906"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("5981392d-cdf1-42d5-be5a-6b129e53efed"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("5b8e4ee6-644b-4405-baf2-7228c014bfbd"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("62d512f3-dc02-4ec5-b48f-6d0da7d736f9"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("667b77c4-6299-4d6a-8038-03c8a1d88d49"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("6691a6c5-9e60-4aaa-9185-3bb1d2ecf762"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("6c95a987-a5b0-4743-a7aa-e09e5f3aefa8"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("6d669948-f5b5-4892-a0b8-a680591ddf4c"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("70556cfa-8f85-444c-b14d-6d3d0560f9f1"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("724838c7-91ba-4944-93fe-736a6694a34d"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("74af42fd-5c4c-496f-8579-d08c65bfb595"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("796140a3-84b7-45f7-96b0-049a78996f52"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("7ac1e919-3d07-4223-8a95-8826bd5b7396"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("7d87dded-e930-4d38-86f2-e85d07854116"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("81a1f67d-362e-4498-af82-511fae47f397"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("81a80af5-a1df-4d3a-9973-161446038bb2"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("88be7be6-91e9-44e0-9df7-153265e68630"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("8cf7ac57-23e1-4f40-83a0-99bf90c6ea87"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("8f36b6ca-e302-41ac-acdf-1ee00eee9bd7"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("926c8cb3-e594-4a8a-b2f2-7af1de3e98d9"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("95db66ed-a0fd-4648-867c-9b72fa10ece4"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("980eb01d-472c-4525-8331-2936823ddd42"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("9b4a6ced-4884-479f-b2b4-e1894ffaf243"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("9e0d176c-2fa4-4691-a910-431d9dc35a2f"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("a11030bb-5f6f-4728-8399-61bee3c112b1"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("a476f5eb-91af-48df-8337-180435e42e79"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("a49382d9-e348-46a4-9771-3a0ee5dba823"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("a590fe7d-6ff7-4541-b8c9-9fbe0d31735a"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("aa2acc11-63ba-49d9-ad9a-f07657b3a038"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("aabfacee-23f9-4810-b714-a0f76ab50c41"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("ab5262ae-973c-4850-9213-c56363b2fcfb"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("ac0e964e-6ed9-48c0-ab1b-0b3ca159f79c"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("ada561f0-a5de-4ee5-a15f-aec4cf5abbbf"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("ae5080fa-7392-4c23-bdf3-3b0a085ca0cb"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("b2fc4f55-9987-4f53-b4ac-8dbb95273098"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("b4d3f58d-3a3c-4f99-88e1-03c7b7f07364"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("b9301777-7afc-4f5a-824c-e5dbf2a1a063"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("bd363546-2c17-455c-ba96-58c661341529"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("bf45df62-3235-430b-9da6-9127f6392f38"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("bf6de7a9-4bd5-48ff-9267-f9d043c8c691"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("d2d84f02-65c0-4876-92a8-6391467bfc9b"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("d365c33c-03df-4a45-ae6a-34d00d59708d"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("d8137db2-aba4-4992-84aa-ad97e419acc1"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("d8f006e2-4190-45d3-88e3-807af1c70892"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("d9054efa-4a3e-448b-b44c-dd47ca2a1868"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("dae7bc3e-ef46-4ddf-a082-a22bda4093df"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("de2275b3-75e1-4ac2-8dd9-517d03036f36"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("de9bd874-d6b6-4af5-8dcb-bb697da278e0"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("df06aedf-6280-4aac-b9f8-db77fd0b5912"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("df299f5a-b161-4d03-9226-5c3a4a433ca9"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("e7fafe10-a996-49a4-9ea1-31603948882f"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("e887a287-85ca-4985-8217-c6785011a181"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("e8d3d68a-4c06-4eee-9c5e-fe04575db022"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("edc2a38c-a04f-4359-87b6-0a8d0e3c5945"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("ede53097-91d2-437e-9059-4e2df88aa044"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("f25a412f-fdf8-4b5d-9381-64f2452e39b9"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("f928e406-0d48-445f-afb7-44613d593491"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("f982354a-64b8-4627-b7b4-6248b76bd00c"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("fba2d8ac-f067-49c5-b80a-4c4c3baf659f"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("fdf74e3d-c810-4daa-a199-05aebbe8783b"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("fe9e0ddc-c142-42c1-833d-bbb0808ae00c"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("ff9d8505-010a-477e-96d8-6163b607f361"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("004b50af-cfbc-486f-a030-46bf36d4e62d"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("19011554-1b19-4f83-a76a-b2355790e78b"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("1e877278-d960-441b-a948-f5daf2eef49b"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("1f642298-3c46-4f91-9e19-5bb32ba4daae"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("3c29a377-0a27-48f5-8c24-8e38b12d62a6"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("6fdda566-38d3-472f-ad74-f4f72a6c9bf8"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("87d93f4b-3ff8-4ae2-a46e-e382b96241bc"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("91a38df8-4a4e-4c95-9881-bb303756b6f7"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("9f496fc8-f0a3-4fbc-ba3c-4b5ad6b1f5f9"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("bacb50bd-f61b-4508-a550-783c6fd927ab"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("ca85fb70-39f2-4cba-b321-1413fd2f365f"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("d089f6ba-dd18-4243-93b5-186a3f9159ed"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("e3668814-9cad-43d6-9b01-68c3fd7d4f6e"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("e4d8ef07-7c3c-4806-aed1-64cbe940b603"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("e9ce39fd-fbbe-478b-97f4-c9226b3abf44"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("ec621f95-910e-4586-9303-0c73ef593ad9"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("fcea3830-4848-4bfa-a262-40e31f72f4f9"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("0f540469-bae4-4631-98ea-71a5588dffb6"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("172645b5-42b9-4e09-8389-47fb6554c609"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("1d4c7423-bea7-4dc9-bb7f-54c662d8f264"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("224eb59e-272a-4585-a664-02c09fbc30c7"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("271353d9-7fed-42c4-8112-12638f7932a7"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("333da5b9-dbc7-403f-86e7-389868bc2a57"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("37472e61-1113-405f-a380-dc3ce041e71a"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("3c5ded76-1b8c-4a08-87d3-9e9704b0fb4b"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("40ccfd95-ca26-4908-805c-27c31995ead7"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("5a5b5d0a-bd5c-45ea-8173-c9c4645eb77c"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("5cdf3890-7422-4c7e-aba6-9a729038d9e5"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("63e0f957-9491-4fba-9021-433d299d371a"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("6f87b266-78a9-49b4-87b3-a4657e1975cb"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("7de5f8a6-11a7-4e61-8877-0133c99c012c"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("8290dbfd-c402-40f6-9768-8d42108ecce3"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("836375a0-81eb-4c40-b3b1-5e3960cdfe98"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("860b86b6-d9c7-43ea-9b0c-502cf264f6aa"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("8d462759-0ec9-42ea-bfb8-ed9985d32c74"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("8f591412-f075-4143-b5a0-14a74d29ff10"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("9561bf0b-8913-4c21-826b-38dbfb7d0b06"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("c04d44f6-7f68-499e-9d16-c802a7241374"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("c186dfd8-8518-418b-9291-7b4839e64ee6"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("c242bb15-83f6-4320-95f1-4b8d8df06e16"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("c388d447-ae5e-4a9d-8af7-7130829f4e6a"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("c98319ae-1264-4d91-a2a6-80df6f0ccf65"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("cfaf4f24-4dd0-407e-9dbe-d2edbcd678d9"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("d0538a29-4480-4a49-8ae9-ae702851af56"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("d16faf31-4569-4193-989f-8620266ebf15"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("dc8e1994-a4b3-440b-80e5-544385a4de86"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("dc96388f-474d-4b07-ada6-571ab51cb1ad"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("e0af56ce-4435-4dd6-9768-19888f0d3089"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("e1e88552-80ea-490f-9fa3-d2126e702d92"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("e3608426-7318-48f3-9b76-3876d685a77e"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("e7931cdc-005c-4788-8286-ffe776b56e9e"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("e7d6bac8-737d-4612-9851-384e010d308b"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("ed45e958-9bd1-402e-8ace-9765cbc310f4"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("ed46dfad-4785-4421-ae34-a7da86620b68"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("eea8313f-0781-46e7-b259-3606a6980029"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("f7206678-9038-464e-982e-52853d8ae1c1"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("fc0c907a-78b4-4738-a34c-e7779923eb69"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("fd35871d-6417-4c3b-8d59-b64295462b6f"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("0d374c06-008e-4cbe-bbe4-6f385b7725e5"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("2dd3fc9a-0424-46e5-b795-e707313d08a7"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("34af1337-fc8b-4e29-8415-2606fbeda0f8"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077"));

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Owners",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "DateOfBirth", "DateOfRegistration", "Email", "Name", "Password", "Surname", "UserId" },
                values: new object[,]
                {
                    { new Guid("04459cfb-692e-4475-afb1-33d400cae41f"), new DateTime(2023, 4, 19, 0, 4, 29, 424, DateTimeKind.Unspecified).AddTicks(6454), new DateTime(2023, 12, 29, 14, 40, 8, 425, DateTimeKind.Utc).AddTicks(7546), "b049fdaf-e101-416d-abfe-8c36d40b4204", "Micah", "d3420dde-6551-4cda-8bd7-eb2371604117", "Hope", "" },
                    { new Guid("0696f671-ccd6-4125-8bcf-c62f384587e9"), new DateTime(2025, 9, 7, 10, 17, 24, 38, DateTimeKind.Unspecified).AddTicks(3660), new DateTime(2023, 12, 29, 14, 40, 8, 426, DateTimeKind.Utc).AddTicks(6056), "589a531e-474e-494b-84f2-c47edf10ed0f", "Dane", "35c40535-3b85-4d73-8dee-ad22e0f6bf7c", "Paula", "" },
                    { new Guid("07fd045d-9b6f-4525-8c88-13367a62696e"), new DateTime(2025, 12, 14, 6, 19, 37, 587, DateTimeKind.Unspecified).AddTicks(8623), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(9936), "99d8e4fc-53c9-454e-b190-2f7561485c5c", "Coen", "893c30f0-bf45-4f64-b444-3f0cd20fc883", "Foster", "" },
                    { new Guid("1487a601-2e3f-4925-a441-f11771ca9331"), new DateTime(2025, 2, 9, 2, 8, 4, 427, DateTimeKind.Unspecified).AddTicks(3161), new DateTime(2023, 12, 29, 14, 40, 8, 425, DateTimeKind.Utc).AddTicks(9512), "4046fd55-05b6-4d94-836e-3d99a4117778", "Chana", "38a9f44d-d087-44fa-8ae5-71a7c4f806ec", "Paula", "" },
                    { new Guid("16c0ad3f-f23b-47cb-8388-77cdac0176a5"), new DateTime(2024, 5, 4, 18, 46, 55, 425, DateTimeKind.Unspecified).AddTicks(9322), new DateTime(2023, 12, 29, 14, 40, 8, 426, DateTimeKind.Utc).AddTicks(7297), "c3be1538-0953-4a74-8535-1867cd486de2", "Foster", "05e995dc-4052-4021-8915-657cb12eb901", "Clark", "" },
                    { new Guid("1eb863c0-c465-4e47-930e-2f34bf15df45"), new DateTime(2023, 9, 22, 20, 29, 37, 257, DateTimeKind.Unspecified).AddTicks(7065), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(6839), "6c66ab08-3f27-4871-bcbf-7e767fe586b2", "Lu", "f6b1556f-d7c8-418e-96df-eef4823383c4", "Foster", "" },
                    { new Guid("269b8217-e2ae-4d4e-9e34-ebead7462008"), new DateTime(2024, 6, 23, 23, 3, 49, 28, DateTimeKind.Unspecified).AddTicks(8993), new DateTime(2023, 12, 29, 14, 40, 8, 426, DateTimeKind.Utc).AddTicks(2985), "0d76d2de-26cc-4eea-a3e6-eeaf5df2d29a", "Dane", "2a29ae51-2801-46dd-b769-fe8ab645ab0e", "Micah", "" },
                    { new Guid("276c1f3a-df96-4365-a817-2ac7f8dc3e82"), new DateTime(2023, 12, 14, 18, 30, 56, 94, DateTimeKind.Unspecified).AddTicks(5409), new DateTime(2023, 12, 29, 14, 40, 8, 426, DateTimeKind.Utc).AddTicks(7816), "c7cccd9c-92e8-4a6c-9a57-5157532e4c2d", "Clark", "67f1ce2e-9272-4cde-94ae-d3a60560d0d2", "Crosby", "" },
                    { new Guid("2c1d4616-73ca-4da3-866f-96b825633238"), new DateTime(2025, 5, 3, 7, 26, 30, 395, DateTimeKind.Unspecified).AddTicks(4885), new DateTime(2023, 12, 29, 14, 40, 8, 425, DateTimeKind.Utc).AddTicks(3104), "e5ab5733-f280-4f9f-b04f-9bb3148a7277", "Paula", "3a5d91e1-660d-4582-88c4-f36b972cdbc1", "Beckett", "" },
                    { new Guid("474db7bb-8245-41f5-8692-529d4b233c8e"), new DateTime(2023, 8, 12, 9, 3, 46, 330, DateTimeKind.Unspecified).AddTicks(7591), new DateTime(2023, 12, 29, 14, 40, 8, 426, DateTimeKind.Utc).AddTicks(5540), "6407b6e2-d548-4c73-a3dc-65ceebabe832", "Demi", "85dc3f1e-abce-4cf3-bca6-51607b1f00da", "Dane", "" },
                    { new Guid("4c7c9bb0-0893-4367-b528-72e8f057446a"), new DateTime(2022, 1, 22, 13, 37, 56, 618, DateTimeKind.Unspecified).AddTicks(7976), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(3869), "6f95d772-f952-4ac3-a6dc-f79dd0d7c4b3", "Micah", "4fcc7d67-4c40-4a63-b922-caaa182fb0df", "Amber", "" },
                    { new Guid("51199e7e-a2f7-45cc-b35b-949da76938d7"), new DateTime(2025, 8, 6, 5, 52, 24, 762, DateTimeKind.Unspecified).AddTicks(4786), new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(1018), "50f646d8-8925-412f-ba67-27444c7bbe95", "Lu", "028a40df-ca6b-4a1f-8bfc-f49e4fb1d672", "Khalani", "" },
                    { new Guid("56f9da6d-3e7d-41a3-8f62-f356caf90972"), new DateTime(2024, 12, 26, 6, 13, 10, 181, DateTimeKind.Unspecified).AddTicks(4886), new DateTime(2023, 12, 29, 14, 40, 8, 425, DateTimeKind.Utc).AddTicks(9021), "cbe337d5-c1e8-4573-bf58-b909e96de0d9", "Chana", "a17a4f42-8a3a-40eb-ac5e-ef4b2bf8177d", "Khalani", "" },
                    { new Guid("5d5ec955-5c89-4184-aad1-60a490b45d26"), new DateTime(2022, 8, 19, 3, 40, 23, 468, DateTimeKind.Unspecified).AddTicks(4744), new DateTime(2023, 12, 29, 14, 40, 8, 426, DateTimeKind.Utc).AddTicks(859), "126547dd-ad44-49b2-a88f-df858648145e", "Micah", "9e7b3004-615e-4746-aa63-0f1462ad59b5", "Coen", "" },
                    { new Guid("5eeec4d0-8dea-4f52-97dc-a0bc4da80c8b"), new DateTime(2022, 5, 6, 10, 1, 0, 267, DateTimeKind.Unspecified).AddTicks(1353), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(7945), "ec266c6f-af88-4753-8c99-76081170fd34", "Hope", "e6d953aa-cd88-4226-82a2-5b20ac1f45e7", "Amber", "" },
                    { new Guid("5f301ca8-cb94-4d44-999e-d375a7520097"), new DateTime(2024, 7, 25, 19, 26, 52, 471, DateTimeKind.Unspecified).AddTicks(7329), new DateTime(2023, 12, 29, 14, 40, 8, 425, DateTimeKind.Utc).AddTicks(9925), "a000f2d0-9d5f-47b2-b8af-e7a37361f10c", "Avayah", "3cf7213e-5493-4579-a70f-7115308fb902", "Chana", "" },
                    { new Guid("6298b950-aa92-45d3-b7f3-2c3b603f54d7"), new DateTime(2024, 8, 12, 14, 26, 46, 215, DateTimeKind.Unspecified).AddTicks(6414), new DateTime(2023, 12, 29, 14, 40, 8, 426, DateTimeKind.Utc).AddTicks(336), "856ef465-8050-4ee3-8f2f-90c933ad1a49", "Paula", "c101e16a-9e25-446a-8114-426335482a8b", "Crosby", "" },
                    { new Guid("6330f354-5991-4fe6-b0da-aa167cbf96b9"), new DateTime(2022, 4, 5, 15, 26, 59, 134, DateTimeKind.Unspecified).AddTicks(5106), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(8379), "e5f5b16a-dc60-4018-9009-488cb1579d2c", "Leonard", "e6e38a1e-038e-4c10-be96-b938e8f80a60", "Crosby", "" },
                    { new Guid("633626e7-c38f-4921-a6f2-a8992a01695f"), new DateTime(2025, 8, 23, 7, 5, 48, 712, DateTimeKind.Unspecified).AddTicks(5059), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(9287), "c87f2486-2a8b-4cdd-a89a-af9d9ee12837", "Paula", "98664854-d48e-4123-81b2-94a5ef52d447", "Clark", "" },
                    { new Guid("6b63a1b6-8e6d-4dea-94ae-972351fcfa7f"), new DateTime(2023, 3, 6, 5, 35, 21, 383, DateTimeKind.Unspecified).AddTicks(3103), new DateTime(2023, 12, 29, 14, 40, 8, 426, DateTimeKind.Utc).AddTicks(4309), "a8f3861d-b76d-4cc7-a952-1c1ebf9b5bda", "Avayah", "453e25df-126d-41ec-bccb-9788b2644741", "Foster", "" },
                    { new Guid("71eceed5-dc8c-4740-97ae-bf2ef39448f5"), new DateTime(2023, 10, 27, 18, 26, 41, 309, DateTimeKind.Unspecified).AddTicks(7584), new DateTime(2023, 12, 29, 14, 40, 8, 426, DateTimeKind.Utc).AddTicks(5132), "44f8f2ab-54ae-486a-8630-bbd5771ce1fd", "Coen", "a67a6aee-3cc9-4fe6-935a-82a8fec81087", "Foster", "" },
                    { new Guid("7bf31e3d-4c24-49fb-aa95-5d6664f5cf93"), new DateTime(2022, 6, 17, 19, 10, 54, 228, DateTimeKind.Unspecified).AddTicks(3896), new DateTime(2023, 12, 29, 14, 40, 8, 425, DateTimeKind.Utc).AddTicks(5291), "e9e061e8-46dd-49e3-86be-f9f9b3f4c0d3", "Clark", "f98f4155-80e6-4939-83ef-8358026b1087", "Demi", "" },
                    { new Guid("7fac973b-5274-4642-ac85-69ebaff1d6db"), new DateTime(2024, 11, 23, 11, 44, 48, 281, DateTimeKind.Unspecified).AddTicks(7390), new DateTime(2023, 12, 29, 14, 40, 8, 426, DateTimeKind.Utc).AddTicks(9242), "cc0a1312-3454-454d-82e7-9c7e11a43ffc", "Beckett", "6c4131ae-ae0a-4e3a-98aa-c694cd77218f", "Coen", "" },
                    { new Guid("836556f8-ef67-4154-b77e-085146e347fc"), new DateTime(2024, 8, 9, 10, 23, 30, 328, DateTimeKind.Unspecified).AddTicks(7902), new DateTime(2023, 12, 29, 14, 40, 8, 426, DateTimeKind.Utc).AddTicks(3421), "3d2a8ad6-3205-4406-84f9-ac429f7f5636", "Amber", "f0b2af95-feee-43b7-8c52-22c5635684cb", "Khalani", "" },
                    { new Guid("8c1f9909-dd55-4ee4-9231-2dbcb2de862f"), new DateTime(2025, 1, 29, 0, 20, 10, 210, DateTimeKind.Unspecified).AddTicks(5126), new DateTime(2023, 12, 29, 14, 40, 8, 426, DateTimeKind.Utc).AddTicks(2583), "c285d225-1f31-4abf-b7be-723ce8d5fab8", "Briar", "629e8980-f021-4945-9083-57de3d731c5a", "Lu", "" },
                    { new Guid("8f093f73-97e5-40b2-a2d6-021c3dafd195"), new DateTime(2023, 5, 5, 14, 14, 38, 335, DateTimeKind.Unspecified).AddTicks(8696), new DateTime(2023, 12, 29, 14, 40, 8, 426, DateTimeKind.Utc).AddTicks(4725), "a2666c37-bf70-427c-9642-b8781edbf355", "Milena", "a84a6c4f-08d3-4248-ad35-d05e01b8a7fd", "Hope", "" },
                    { new Guid("96ee043d-08f7-41e0-9c7e-fe08b9044ebc"), new DateTime(2022, 3, 30, 21, 51, 30, 703, DateTimeKind.Unspecified).AddTicks(3516), new DateTime(2023, 12, 29, 14, 40, 8, 426, DateTimeKind.Utc).AddTicks(2095), "055c93f4-4302-4b30-ac9e-3631c863d79e", "Crosby", "83c1ac5e-72bb-4ff2-a165-234986a7e884", "Clark", "" },
                    { new Guid("9e6402ea-8608-4fd9-acb1-87ac38e54b00"), new DateTime(2025, 12, 15, 21, 8, 59, 314, DateTimeKind.Unspecified).AddTicks(3149), new DateTime(2023, 12, 29, 14, 40, 8, 426, DateTimeKind.Utc).AddTicks(1282), "ddef5d8f-787e-4f4b-8dcc-7640f6398b6a", "Crosby", "a600b46b-0035-453e-8daf-ad521fae03d9", "Milena", "" },
                    { new Guid("a4bcdb88-61fa-4bbc-968c-0639294c8906"), new DateTime(2024, 9, 28, 11, 50, 0, 851, DateTimeKind.Unspecified).AddTicks(3535), new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(192), "183ddda8-d989-44a1-ab16-59753c2babf2", "Dane", "0d2a9b17-3413-4d98-8a73-8e64db6417c5", "Paula", "" },
                    { new Guid("b2bcb3be-fb0e-48d3-b637-2238d1a81742"), new DateTime(2025, 9, 15, 3, 5, 46, 391, DateTimeKind.Unspecified).AddTicks(3116), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(7460), "c582f3c2-f9e0-4147-b914-e626dfd94d4c", "Coen", "50870453-57d2-44c3-bea1-9ce978ab9fbb", "Amber", "" },
                    { new Guid("b5e8071a-d25f-4735-888a-e9a258bb8e4d"), new DateTime(2025, 11, 10, 13, 31, 48, 508, DateTimeKind.Unspecified).AddTicks(6143), new DateTime(2023, 12, 29, 14, 40, 8, 426, DateTimeKind.Utc).AddTicks(8795), "4d127f4f-ed0b-4673-a464-ce6992f1c279", "Coen", "53700de5-1d59-4ef6-a28e-95f15c0a837d", "Hope", "" },
                    { new Guid("b8254eb2-c72c-4f0f-92d2-dd611b51fb27"), new DateTime(2022, 4, 19, 14, 22, 7, 25, DateTimeKind.Unspecified).AddTicks(8948), new DateTime(2023, 12, 29, 14, 40, 8, 426, DateTimeKind.Utc).AddTicks(6476), "fe7ed83b-7b50-4844-9c16-66ee118b159c", "Leonard", "af6e7c44-f2f3-4ec2-9f3f-e4342b22e9d3", "Briar", "" },
                    { new Guid("ba69c9e8-7aef-433e-bee5-21b65e8e7924"), new DateTime(2025, 4, 17, 16, 50, 46, 329, DateTimeKind.Unspecified).AddTicks(6274), new DateTime(2023, 12, 29, 14, 40, 8, 425, DateTimeKind.Utc).AddTicks(1392), "898e7052-1a59-47ff-9e81-3e35350c1a11", "Leonard", "c3ee1cbc-e3e3-4d22-aca6-99dc4307a312", "Beckett", "" },
                    { new Guid("be988db3-87d2-4bd8-86f1-54c81e135ebe"), new DateTime(2023, 5, 9, 16, 25, 30, 401, DateTimeKind.Unspecified).AddTicks(453), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(6301), "fd47e361-0cdd-4a8f-b873-5b7687dc7540", "Helen", "d6a19f20-1bec-46ca-9d57-28dd86f46d4f", "Micah", "" },
                    { new Guid("c371d1cc-00aa-4db5-bfaf-7c93ae0fc281"), new DateTime(2024, 7, 4, 13, 4, 25, 0, DateTimeKind.Unspecified).AddTicks(7412), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(4885), "f5ab81f3-93d9-4b63-8995-5ab002123826", "Clark", "f8d62dd4-6e60-41ea-ba5c-056e9756aacd", "Crosby", "" },
                    { new Guid("c3770496-c4fb-44e0-89c7-0ccfb10e6422"), new DateTime(2025, 5, 10, 16, 48, 58, 264, DateTimeKind.Unspecified).AddTicks(662), new DateTime(2023, 12, 29, 14, 40, 8, 425, DateTimeKind.Utc).AddTicks(626), "d752b0f7-bbb0-4752-b875-b0c4f19b8a1f", "Avayah", "174e5c00-9187-481d-b8a0-bb64146265dc", "Chana", "" },
                    { new Guid("cbf27b34-90a5-4ef5-8c88-629f2f11deb5"), new DateTime(2023, 7, 19, 20, 10, 43, 130, DateTimeKind.Unspecified).AddTicks(9604), new DateTime(2023, 12, 29, 14, 40, 8, 425, DateTimeKind.Utc).AddTicks(4511), "75892771-c5e8-480f-8455-fa8a0f7d5399", "Khalani", "86aebabe-8ae2-4a37-a39f-7ea24dfc1e2d", "Demi", "" },
                    { new Guid("cc5fd2e3-c957-4226-a5fb-426ffabf5a10"), new DateTime(2024, 6, 3, 22, 27, 28, 39, DateTimeKind.Unspecified).AddTicks(5706), new DateTime(2023, 12, 29, 14, 40, 8, 426, DateTimeKind.Utc).AddTicks(8278), "cfdbd21b-c89d-4ce0-b73a-a83e7971e221", "Crosby", "2112d635-573a-41d9-bcb4-399b587a69c1", "Avayah", "" },
                    { new Guid("cea216c1-f435-4c81-9ae3-c74b89fd9ddf"), new DateTime(2022, 7, 9, 13, 19, 8, 879, DateTimeKind.Unspecified).AddTicks(953), new DateTime(2023, 12, 29, 14, 40, 8, 425, DateTimeKind.Utc).AddTicks(6729), "7cd99ee4-ca77-4585-a612-7c9de8114749", "Lu", "03b775be-61c7-489b-858e-00f15eebb4db", "Khalani", "" },
                    { new Guid("d52884fc-7218-4f65-a467-de9a9253b7ac"), new DateTime(2024, 11, 1, 14, 29, 54, 410, DateTimeKind.Unspecified).AddTicks(1238), new DateTime(2023, 12, 29, 14, 40, 8, 425, DateTimeKind.Utc).AddTicks(3809), "1423df1f-9cee-41ad-9bb3-e06f8261d6e9", "Khalani", "1f52bf87-b9cb-41db-ba71-6f6943cb9704", "Briar", "" },
                    { new Guid("d7cdf4b9-8655-4912-9f57-e1734cca3433"), new DateTime(2022, 7, 25, 11, 41, 18, 97, DateTimeKind.Unspecified).AddTicks(6591), new DateTime(2023, 12, 29, 14, 40, 8, 426, DateTimeKind.Utc).AddTicks(6889), "b3980f67-a5c0-4bc8-b1e0-912d5b5a58ca", "Lu", "3eb56781-1eee-41f2-8ab1-f7d621d1ad1f", "Justice", "" },
                    { new Guid("dbca6e1c-82c7-4737-89ea-a07538584caa"), new DateTime(2025, 12, 12, 12, 51, 11, 956, DateTimeKind.Unspecified).AddTicks(1803), new DateTime(2023, 12, 29, 14, 40, 8, 426, DateTimeKind.Utc).AddTicks(9716), "2ed70e59-30ce-4057-9b4c-517c9d11033e", "Crosby", "7ff2887c-00a1-497d-9f1c-e951c29e8137", "Micah", "" },
                    { new Guid("e8422ef2-f848-44d9-b654-19fa3d64a0c9"), new DateTime(2024, 3, 20, 18, 28, 53, 39, DateTimeKind.Unspecified).AddTicks(8781), new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(603), "014ab275-bab8-4eb9-8598-3e8e7f8324c5", "Micah", "ec1bcb30-32e2-4d53-8dbe-5cb8dc46ca92", "Micah", "" },
                    { new Guid("ea7ba43f-4c05-4a3e-9c85-fcaae49ead38"), new DateTime(2023, 4, 28, 13, 16, 54, 951, DateTimeKind.Unspecified).AddTicks(7546), new DateTime(2023, 12, 29, 14, 40, 8, 426, DateTimeKind.Utc).AddTicks(3829), "267554dd-7eec-4459-a860-a5fd0b9998bc", "Lu", "4ad3ebd5-c4bb-4a96-a93f-09ae7abfc382", "Coen", "" },
                    { new Guid("f0c71657-d493-451b-87e8-23ec3c10ea1d"), new DateTime(2024, 11, 27, 21, 57, 10, 976, DateTimeKind.Unspecified).AddTicks(3924), new DateTime(2023, 12, 29, 14, 40, 8, 425, DateTimeKind.Utc).AddTicks(5993), "076115dd-1620-4fef-8ca7-8096e51c421d", "Avayah", "9515266b-95b5-4732-9698-73b762fbfa73", "Crosby", "" },
                    { new Guid("f0d909f2-8333-4c06-b2e5-bd7d8e8aab14"), new DateTime(2024, 8, 8, 16, 24, 1, 940, DateTimeKind.Unspecified).AddTicks(9382), new DateTime(2023, 12, 29, 14, 40, 8, 426, DateTimeKind.Utc).AddTicks(1695), "cf53d39f-d97e-4ea7-a95a-01662507770c", "Clark", "8d63ac20-716b-4a07-bd00-f9ad0119b8a7", "Demi", "" },
                    { new Guid("f2ffc96b-952a-4734-b202-0715e0736247"), new DateTime(2025, 9, 29, 9, 17, 14, 417, DateTimeKind.Unspecified).AddTicks(793), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(5313), "5662eb23-2720-442d-8147-dcc705bdad78", "Beckett", "75bc8c9f-0eea-4b0f-9e85-6124366c290d", "Amber", "" },
                    { new Guid("f3445268-2294-4e35-b6a0-67e81ef32629"), new DateTime(2022, 7, 20, 5, 2, 52, 897, DateTimeKind.Unspecified).AddTicks(2684), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(5727), "0bb9b166-02b3-42ff-91f3-a8613a7febd6", "Foster", "54fd4954-e48b-4667-9f21-e760bffcfe30", "Avayah", "" },
                    { new Guid("fca2afc6-7d2a-427c-82b4-1dc3f257c013"), new DateTime(2023, 1, 12, 3, 18, 35, 516, DateTimeKind.Unspecified).AddTicks(9757), new DateTime(2023, 12, 29, 14, 40, 8, 425, DateTimeKind.Utc).AddTicks(8361), "d38b57df-e3e1-4d72-a490-483eaef203aa", "Coen", "2ae4d5b9-3988-4c41-88f7-c8f08b8f716b", "Amber", "" },
                    { new Guid("ff09805c-1069-4e10-8f74-42a86c3eb034"), new DateTime(2022, 6, 21, 0, 53, 16, 37, DateTimeKind.Unspecified).AddTicks(4964), new DateTime(2023, 12, 29, 14, 40, 8, 425, DateTimeKind.Utc).AddTicks(2379), "45a01901-3c50-4350-ba74-8acd21d463b9", "Crosby", "ce96fbf4-4ba1-43f7-acda-7fe281949520", "Milena", "" }
                });

            migrationBuilder.InsertData(
                table: "PetTypes",
                columns: new[] { "Id", "DateOfRegistration", "Type" },
                values: new object[,]
                {
                    { new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2804), "Snake" },
                    { new Guid("32b1da23-2345-4fff-af31-f2c6ddca00e2"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2782), "Cat" },
                    { new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2771), "Dog" },
                    { new Guid("717009cf-c0cd-440a-b9e7-77f92ba7736f"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2808), "Rat" },
                    { new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2800), "Hamster" },
                    { new Guid("c9dda37a-9284-4681-b063-959feceeb3a8"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2778), "Snake" },
                    { new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2792), "Dog" },
                    { new Guid("d49c3583-5f26-42d7-b37d-b7962b4f8087"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2817), "Rabbit" },
                    { new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2788), "Rat" },
                    { new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2814), "Horse" }
                });

            migrationBuilder.InsertData(
                table: "Traits",
                columns: new[] { "Id", "DateOfRegistration", "Name" },
                values: new object[,]
                {
                    { new Guid("0ae3667d-8f40-412e-82b3-aae6cf496440"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2457), "loving" },
                    { new Guid("1199807b-46a7-4610-8df2-c7df16a2f8f8"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2449), "loud" },
                    { new Guid("1b9c8d1a-1dcb-4651-96b9-a28206738e0c"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2434), "active" },
                    { new Guid("20a451ec-b864-4e51-b4b1-8bb720f5fd9f"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2503), "silly" },
                    { new Guid("351cdd42-dec1-40ff-9fa5-02bcf0093f48"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2460), "loyal" },
                    { new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2443), "lazy" },
                    { new Guid("39d5a768-3ea4-4379-af70-d9145b4ba9bd"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2508), "trustworthy" },
                    { new Guid("52223944-550b-4b2a-8153-7c52341506ae"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2472), "friendly" },
                    { new Guid("71949e9b-637a-438b-8694-d9e440ec5df3"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2480), "clumsy" },
                    { new Guid("78b624a4-9528-4c48-b6fd-29b7308ae44f"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2488), "nervous" },
                    { new Guid("81070cd0-8b4a-4300-bb57-655c4298460c"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2491), "gentle" },
                    { new Guid("83ccd7f1-1c9e-4d31-96c4-7c4fd5b66b04"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2467), "shy" },
                    { new Guid("8a60b900-510a-489f-af33-6ca3e36003ce"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2495), "smart" },
                    { new Guid("92ca8c89-1934-4e91-b501-7ba45719a744"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2475), "quiet" },
                    { new Guid("a332d831-d29f-4d11-ba6d-a45fd19b7f8a"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2463), "brave" },
                    { new Guid("a6e7cba0-c2e2-4989-beb1-b9109543bdfe"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2505), "intelligent" },
                    { new Guid("af8c05c2-4018-4859-af40-d1380e520f8d"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2478), "calm" },
                    { new Guid("ca979c56-0d86-44ec-9e66-9f1d1b2901cf"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2446), "afraid" },
                    { new Guid("d2d2e4da-7eae-4f44-8078-594e60f967e1"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2500), "spoiled" },
                    { new Guid("ec0827e0-83c5-4d96-b445-30bfb4eff9e0"), new DateTime(2023, 12, 29, 14, 40, 8, 424, DateTimeKind.Utc).AddTicks(2485), "cheerful" }
                });

            migrationBuilder.InsertData(
                table: "OwnerAddress",
                columns: new[] { "Id", "City", "Country", "DateOfRegistration", "District", "OwnerId", "PostalCode", "Street" },
                values: new object[,]
                {
                    { new Guid("0a5d5057-49b2-4668-aac7-2a76676dc106"), "Gdansk", "Italy", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(3765), "Oliwa", new Guid("6330f354-5991-4fe6-b0da-aa167cbf96b9"), "80-398", "955b6018-a68c-4bf7-a6b8-35d8b988ab15" },
                    { new Guid("0bd3a0d6-e509-4df3-939c-1d03a40d8c82"), "Madrid", "UK", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(4975), "Brooklyn", new Guid("d52884fc-7218-4f65-a467-de9a9253b7ac"), "65-154", "78dc8c60-d223-444d-82f6-9d450b3d57d1" },
                    { new Guid("11b31559-5ab0-4503-87d9-dc1f40ac7ea2"), "London", "Czech Republic", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(9675), "Starówka", new Guid("71eceed5-dc8c-4740-97ae-bf2ef39448f5"), "80-21", "1a6b2abb-99c8-4a33-a940-c9135f11fb63" },
                    { new Guid("12c37c4e-4041-4c32-a09e-9251ddba3528"), "Madrid", "Poland", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(4304), "Starówka", new Guid("ba69c9e8-7aef-433e-bee5-21b65e8e7924"), "80-21", "892f28e3-2a51-4168-8a76-f6a5cd00bed9" },
                    { new Guid("1406c249-5e16-4729-926c-047a3027ea22"), "Rome", "Poland", new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(1402), "Oliwa", new Guid("b5e8071a-d25f-4735-888a-e9a258bb8e4d"), "80-398", "171b7edd-9358-48c7-a45a-5d9ab9628203" },
                    { new Guid("17a1ca8e-43c9-4fce-a420-3f76eea42743"), "Krakow", "Czech Republic", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(6189), "Oliwa", new Guid("04459cfb-692e-4475-afb1-33d400cae41f"), "80-398", "fafb8666-c754-4d81-8292-a2c0a0da4c22" },
                    { new Guid("19de3737-1160-43de-996d-65e0a59e0b66"), "Madrid", "UK", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(7025), "Brooklyn", new Guid("5f301ca8-cb94-4d44-999e-d375a7520097"), "65-154", "bdf9ef6f-eb0b-4749-8f1f-575f598d77e9" },
                    { new Guid("1b2c99f0-8216-4574-a4b6-93da66d479e4"), "Slupsk", "Italy", new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(1844), "Brooklyn", new Guid("dbca6e1c-82c7-4737-89ea-a07538584caa"), "65-154", "24e7fa70-18c8-45b3-9e87-6b2b56a86220" },
                    { new Guid("1cb0ade2-3e1d-4b38-ae30-308cfb5ca98a"), "Brno", "Czech Republic", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(2326), "Orunia", new Guid("4c7c9bb0-0893-4367-b528-72e8f057446a"), "80-59", "1130a225-62ad-4eb3-a089-563302aff42a" },
                    { new Guid("26b98a32-9586-43f1-a9f8-abd447baf467"), "London", "UK", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(3472), "Brooklyn", new Guid("b2bcb3be-fb0e-48d3-b637-2238d1a81742"), "65-154", "ec85ed29-a4c8-4c97-ad13-84a936cbe58e" },
                    { new Guid("33fb8f31-5df8-4fc9-b0da-63323b7c0ef7"), "Krakow", "Czech Republic", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(8413), "Starówka", new Guid("8c1f9909-dd55-4ee4-9231-2dbcb2de862f"), "80-21", "30e57ecf-e273-4e63-b6bd-17b7407997a9" },
                    { new Guid("3d4d5ad6-c22b-44e3-9dcd-c8a50245faad"), "Brno", "UK", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(3886), "Brooklyn", new Guid("633626e7-c38f-4921-a6f2-a8992a01695f"), "65-154", "48a439ba-b5f1-4739-b5ef-29cd181cedd5" },
                    { new Guid("4b4e02e6-cea1-4b42-a777-550ab7d9a42b"), "Warsaw", "Italy", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(7284), "Oliwa", new Guid("6298b950-aa92-45d3-b7f3-2c3b603f54d7"), "80-398", "7f37891e-2684-4bfd-9244-5b4995d8695a" },
                    { new Guid("4c84f831-f5e0-47d8-afdc-f4007c360497"), "Gdansk", "Italy", new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(2302), "Oliwa", new Guid("e8422ef2-f848-44d9-b654-19fa3d64a0c9"), "80-398", "57b7073b-cf49-4ca6-8c76-4208fc654ca5" },
                    { new Guid("4e3fe722-a33f-474c-b7b1-af1aabae21aa"), "Gdansk", "UK", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(8607), "Oliwa", new Guid("269b8217-e2ae-4d4e-9e34-ebead7462008"), "80-398", "46293647-85bf-4492-b95c-c7df290ff27a" },
                    { new Guid("4f7099f9-2dcf-42a7-a1ab-d62e3ad76632"), "London", "Poland", new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(2108), "Starówka", new Guid("a4bcdb88-61fa-4bbc-968c-0639294c8906"), "80-21", "f937c5b0-1d9e-4937-b134-c95283609661" },
                    { new Guid("56e83c14-84fb-4721-a854-6a3e19f14e30"), "Brno", "Czech Republic", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(9055), "Oliwa", new Guid("ea7ba43f-4c05-4a3e-9c85-fcaae49ead38"), "80-398", "a4acff49-1fc3-495d-ae79-664f74f14096" },
                    { new Guid("57e6f021-bbb1-4ba6-b5e6-38b919911305"), "London", "UK", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(9240), "Oliwa", new Guid("6b63a1b6-8e6d-4dea-94ae-972351fcfa7f"), "80-398", "0f7398d4-4c2e-449c-905b-ec66102c68e1" },
                    { new Guid("6638f4bb-b1d1-4e75-ad8f-3b09a2e5d7c1"), "Gdansk", "Italy", new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(2550), "Orunia", new Guid("51199e7e-a2f7-45cc-b35b-949da76938d7"), "80-59", "99589582-9b61-408e-8b56-99e427a30479" },
                    { new Guid("66b5ad82-7f75-4e04-97c9-c4f49d039dd0"), "Warsaw", "Italy", new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(149), "Brooklyn", new Guid("0696f671-ccd6-4125-8bcf-c62f384587e9"), "65-154", "ef07fafc-b7f5-4739-8c47-78a710b657ea" },
                    { new Guid("66f1f447-a646-4c02-a22e-d37e4951e4d3"), "Slupsk", "Italy", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(5937), "Oliwa", new Guid("cea216c1-f435-4c81-9ae3-c74b89fd9ddf"), "80-398", "7817e068-c97a-490e-9cbe-e88b42f857c2" },
                    { new Guid("6b007d0d-8c69-4299-9710-dc562b2801ae"), "Slupsk", "UK", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(6380), "Starówka", new Guid("fca2afc6-7d2a-427c-82b4-1dc3f257c013"), "80-21", "6d27b54d-648c-4942-935f-646cfbec3433" },
                    { new Guid("721b3720-5b57-4c2b-90fc-5f6c1694f268"), "London", "Poland", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(8865), "Orunia", new Guid("836556f8-ef67-4154-b77e-085146e347fc"), "80-59", "ef2ad886-e405-4dbb-9be8-c7ecf29f45f6" },
                    { new Guid("7bfc7bc8-9534-49bc-ac4b-6e7cfc98ad9e"), "London", "Czech Republic", new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(589), "Wrzeszcz", new Guid("d7cdf4b9-8655-4912-9f57-e1734cca3433"), "80-251", "429d684f-363d-40f2-b387-d643c23ffd7c" },
                    { new Guid("81f1fa37-da25-4f87-87b1-968cdfbbb9ef"), "Krakow", "Poland", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(3049), "Starówka", new Guid("f3445268-2294-4e35-b6a0-67e81ef32629"), "80-21", "702b0fbf-9948-412a-b9f0-16d051bdbcf4" },
                    { new Guid("8cd89352-210f-429f-9321-25a30d0c1fd5"), "Madrid", "UK", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(4554), "Brooklyn", new Guid("ff09805c-1069-4e10-8f74-42a86c3eb034"), "65-154", "cb5cb8b0-9ad0-4b38-9f56-742180212c8a" },
                    { new Guid("94b18b17-dd33-4401-b181-7a1a32f1956a"), "Madrid", "Poland", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(5462), "Wrzeszcz", new Guid("7bf31e3d-4c24-49fb-aa95-5d6664f5cf93"), "80-251", "bf2b2b4a-56f7-4f76-b730-a0dde251b5fd" },
                    { new Guid("a292c65e-c917-4742-ac79-6e9c73629b1c"), "Warsaw", "Poland", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(2858), "Orunia", new Guid("f2ffc96b-952a-4734-b202-0715e0736247"), "80-59", "3f7f649f-0f83-4f1a-b9dd-e3a00d54ef9c" },
                    { new Guid("a61860be-bf72-4356-870e-1057bd3d31e0"), "London", "Italy", new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(1032), "Brooklyn", new Guid("276c1f3a-df96-4365-a817-2ac7f8dc3e82"), "65-154", "5fe5a0ea-db10-482a-9b6e-94599646f932" },
                    { new Guid("ae8feef8-9e42-4e2d-973a-0b097760da6f"), "Slupsk", "Czech Republic", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(9488), "Oliwa", new Guid("8f093f73-97e5-40b2-a2d6-021c3dafd195"), "80-398", "593835f4-3731-4280-bd2c-2998bf8e8dd6" },
                    { new Guid("b003d20f-57f9-43b3-9396-e799e0f6692c"), "Brno", "Czech Republic", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(6566), "Orunia", new Guid("56f9da6d-3e7d-41a3-8f62-f356caf90972"), "80-59", "a5efd509-17b0-4f02-8c2f-40cd3f2d36b1" },
                    { new Guid("ba36b8d2-898a-4509-be0d-37d6c7215ad9"), "Rome", "UK", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(3295), "Oliwa", new Guid("1eb863c0-c465-4e47-930e-2f34bf15df45"), "80-398", "f835cc1c-ae2e-4b22-ab7a-92b69c462010" },
                    { new Guid("bae76900-56b5-4ceb-8dcf-5c75f438997b"), "Warsaw", "Czech Republic", new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(333), "Orunia", new Guid("b8254eb2-c72c-4f0f-92d2-dd611b51fb27"), "80-59", "7b5343e6-bc86-462e-a7ab-fb696f3fedc1" },
                    { new Guid("bb7e67c3-035a-4063-931c-a11e907a578e"), "Krakow", "Italy", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(6832), "Oliwa", new Guid("1487a601-2e3f-4925-a441-f11771ca9331"), "80-398", "962aa446-db93-490c-8175-6a3dc4c0528f" },
                    { new Guid("bcb2a7a8-0662-4abd-9aa0-deab341a42bf"), "Rome", "Italy", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(3593), "Wrzeszcz", new Guid("5eeec4d0-8dea-4f52-97dc-a0bc4da80c8b"), "80-251", "6f8ca696-3ec1-4667-af12-c91c83a48fdf" },
                    { new Guid("c029c637-c8de-4f44-a30e-6b8ec7cff2db"), "Brno", "Czech Republic", new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(776), "Wrzeszcz", new Guid("16c0ad3f-f23b-47cb-8388-77cdac0176a5"), "80-251", "297c8b1a-43af-40e0-a7d8-ca704ea06eda" },
                    { new Guid("caba21a3-b5dc-4fe0-8c0d-e64e1c88695b"), "Warsaw", "Czech Republic", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(8164), "Wrzeszcz", new Guid("96ee043d-08f7-41e0-9c7e-fe08b9044ebc"), "80-251", "24633944-2275-4ddd-a2e3-a59577a61c48" },
                    { new Guid("cee7e3f8-83f3-433b-8245-5698a7142c0a"), "London", "Czech Republic", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(5277), "Brooklyn", new Guid("cbf27b34-90a5-4ef5-8c88-629f2f11deb5"), "65-154", "9096630b-df39-49a6-ad4c-ea698626673b" },
                    { new Guid("d8275f46-dd74-4722-90c5-cafaa9d28059"), "Madrid", "Italy", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(4184), "Starówka", new Guid("c3770496-c4fb-44e0-89c7-0ccfb10e6422"), "80-21", "cca8e834-c81c-4047-bbba-f992c547c10d" },
                    { new Guid("d8b90517-9485-4927-9ec2-ef14716aeff0"), "Madrid", "Czech Republic", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(9961), "Starówka", new Guid("474db7bb-8245-41f5-8692-529d4b233c8e"), "80-21", "8d72cd93-185b-4b34-8e09-7ca84478b3f7" },
                    { new Guid("d97474e4-b264-49df-bee4-4ef0c34bc6c0"), "Slupsk", "UK", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(5749), "Oliwa", new Guid("f0c71657-d493-451b-87e8-23ec3c10ea1d"), "80-398", "485ece5a-20dc-44f4-93d3-20b79007df7d" },
                    { new Guid("dbbf059f-dfd3-4a9e-8880-e6a6030d282e"), "Warsaw", "UK", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(4777), "Orunia", new Guid("2c1d4616-73ca-4da3-866f-96b825633238"), "80-59", "a7f85081-8c21-4749-93f0-27a10f615316" },
                    { new Guid("dc3e5f03-7f69-4574-a114-6a4c40ac4a6a"), "Warsaw", "Italy", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(7725), "Brooklyn", new Guid("9e6402ea-8608-4fd9-acb1-87ac38e54b00"), "65-154", "c54ef037-f170-4689-8f70-1e80797d344b" },
                    { new Guid("e3a272c6-3859-445b-9854-421c0c92ea0e"), "Slupsk", "Italy", new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(1647), "Orunia", new Guid("7fac973b-5274-4642-ac85-69ebaff1d6db"), "80-59", "11c7bfda-4cd4-4e61-a36d-941c2d7f7efa" },
                    { new Guid("e3b6ab55-982b-458f-aa79-20c4de0cef8c"), "Rome", "Poland", new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(1218), "Wrzeszcz", new Guid("cc5fd2e3-c957-4226-a5fb-426ffabf5a10"), "80-251", "479c2e0f-9656-4095-8e44-3959fa82fd2a" },
                    { new Guid("e47bcaf2-c2a7-4e2f-9573-f0a9b49971a9"), "Slupsk", "UK", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(7978), "Orunia", new Guid("f0d909f2-8333-4c06-b2e5-bd7d8e8aab14"), "80-59", "91ff72f7-a414-4460-9b44-75c7c3ac6071" },
                    { new Guid("f7e1eca6-e5c1-456d-ae88-8b3dbee1ef3b"), "Krakow", "UK", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(4005), "Orunia", new Guid("07fd045d-9b6f-4525-8c88-13367a62696e"), "80-59", "bf704c3d-36b7-4d30-baeb-4ed24c61f28d" },
                    { new Guid("f9a0c5e2-2709-4bf4-8353-2fe72354bea3"), "Prague", "UK", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(3174), "Starówka", new Guid("be988db3-87d2-4bd8-86f1-54c81e135ebe"), "80-21", "c6be3c5f-dedb-4dd7-94b0-e71f73fc35ab" },
                    { new Guid("fd72b9bf-1607-46cf-939c-9494a9c697dc"), "Prague", "UK", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(2726), "Orunia", new Guid("c371d1cc-00aa-4db5-bfaf-7c93ae0fc281"), "80-59", "a8124ca2-9133-480d-81e0-ccf7e4e62606" },
                    { new Guid("fe6e8d8e-41e6-40df-ac7d-495ff7bb15f9"), "Prague", "Czech Republic", new DateTime(2023, 12, 29, 14, 40, 8, 427, DateTimeKind.Utc).AddTicks(7523), "Orunia", new Guid("5d5ec955-5c89-4184-aad1-60a490b45d26"), "80-59", "c085e26b-57ad-45f6-8f74-034ed2ac4986" }
                });

            migrationBuilder.InsertData(
                table: "OwnerBlackLists",
                columns: new[] { "Id", "OwnerId", "PetTypeId" },
                values: new object[,]
                {
                    { new Guid("0cd10a72-cbcb-46df-9bfd-4dfc5b34adee"), new Guid("633626e7-c38f-4921-a6f2-a8992a01695f"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("0eea7f87-7ada-4e6f-980d-c582ee76d774"), new Guid("5eeec4d0-8dea-4f52-97dc-a0bc4da80c8b"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("29028db4-8143-4a39-a5f1-2c85b5304935"), new Guid("ba69c9e8-7aef-433e-bee5-21b65e8e7924"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("2a1c47c5-cb4e-4a2a-8452-ae7d9032d302"), new Guid("f0c71657-d493-451b-87e8-23ec3c10ea1d"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("309d7350-c4a5-4034-97f9-d50f46e05968"), new Guid("07fd045d-9b6f-4525-8c88-13367a62696e"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("3384d822-d817-4ba6-bde1-ef4b1c39f813"), new Guid("cea216c1-f435-4c81-9ae3-c74b89fd9ddf"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("3bfe643c-834e-4457-892d-acfc3f7ffe25"), new Guid("c371d1cc-00aa-4db5-bfaf-7c93ae0fc281"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("470ad011-ccfc-4dfd-b246-099d2b1464bc"), new Guid("4c7c9bb0-0893-4367-b528-72e8f057446a"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("4741571b-5830-446f-96ef-e929bb92485f"), new Guid("fca2afc6-7d2a-427c-82b4-1dc3f257c013"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("610f685d-2101-4313-9ec1-b12625d5cec5"), new Guid("d52884fc-7218-4f65-a467-de9a9253b7ac"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("7a192262-6bfc-4e4d-b1f4-cd4cab0fda68"), new Guid("7bf31e3d-4c24-49fb-aa95-5d6664f5cf93"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("7cab6583-0027-436c-a12c-14461226f13f"), new Guid("ff09805c-1069-4e10-8f74-42a86c3eb034"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("7ff06343-83fc-4910-aa60-216d50c50d58"), new Guid("c3770496-c4fb-44e0-89c7-0ccfb10e6422"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("89fcf3d9-55ca-4a65-bd77-0f4f2b1db36e"), new Guid("f2ffc96b-952a-4734-b202-0715e0736247"), new Guid("717009cf-c0cd-440a-b9e7-77f92ba7736f") },
                    { new Guid("97509f94-c424-4dc4-bab4-600e35dc0927"), new Guid("b2bcb3be-fb0e-48d3-b637-2238d1a81742"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("9af26cfd-2370-4fe4-965c-48808ad06c57"), new Guid("56f9da6d-3e7d-41a3-8f62-f356caf90972"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("a7544dea-9d03-4b9a-8fa2-76485990c10c"), new Guid("cbf27b34-90a5-4ef5-8c88-629f2f11deb5"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("b2ab3ec9-f11c-4dd8-b92a-c71f6e063021"), new Guid("2c1d4616-73ca-4da3-866f-96b825633238"), new Guid("32b1da23-2345-4fff-af31-f2c6ddca00e2") },
                    { new Guid("b4f8be60-38b4-470b-8ba8-0b64013602ad"), new Guid("5f301ca8-cb94-4d44-999e-d375a7520097"), new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56") },
                    { new Guid("c567aabd-8043-4548-8645-27039b9c4fb3"), new Guid("6330f354-5991-4fe6-b0da-aa167cbf96b9"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("d80c34ad-f264-4145-aad2-63dc6ac5844a"), new Guid("f3445268-2294-4e35-b6a0-67e81ef32629"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("de3de5ec-d80d-4257-bcf5-4b7a61b3924f"), new Guid("1487a601-2e3f-4925-a441-f11771ca9331"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("e5883654-9acd-415c-8ec1-35ae4acdcc3d"), new Guid("1eb863c0-c465-4e47-930e-2f34bf15df45"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("eb6b8d50-5dba-48d8-b4c2-f3df27ab8aff"), new Guid("04459cfb-692e-4475-afb1-33d400cae41f"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("fd68e3bb-eceb-4739-8450-dae958c0a8ff"), new Guid("be988db3-87d2-4bd8-86f1-54c81e135ebe"), new Guid("c9dda37a-9284-4681-b063-959feceeb3a8") }
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "DateOfBirth", "DateOfRegistration", "Gender", "Name", "OwnerId", "PetTypeId" },
                values: new object[,]
                {
                    { new Guid("00d77d77-a4d8-4990-9bb0-d6481338cb39"), new DateTime(2014, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3579), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3578), 0, "FREEDOOM", new Guid("fca2afc6-7d2a-427c-82b4-1dc3f257c013"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("05d9780d-2c4b-4846-8048-6c5afdeca6ac"), new DateTime(2022, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3195), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3193), 0, "ALACA", new Guid("f0c71657-d493-451b-87e8-23ec3c10ea1d"), new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56") },
                    { new Guid("07f6069e-6fd6-4459-b912-af05eb4949b6"), new DateTime(2021, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3912), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3910), 0, "FLOKEY", new Guid("f2ffc96b-952a-4734-b202-0715e0736247"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("12d13f50-09f0-4607-b210-36aab22eeff7"), new DateTime(2022, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4554), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4553), 0, "BOOM", new Guid("d7cdf4b9-8655-4912-9f57-e1734cca3433"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("1388efbe-339a-4228-a1ba-7934614223ef"), new DateTime(2019, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3003), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3001), 1, "TWIGA", new Guid("5d5ec955-5c89-4184-aad1-60a490b45d26"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("14315ec2-4158-48cf-ba1c-a61d9b88d74e"), new DateTime(2020, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3279), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3277), 0, "TAIFA", new Guid("d7cdf4b9-8655-4912-9f57-e1734cca3433"), new Guid("717009cf-c0cd-440a-b9e7-77f92ba7736f") },
                    { new Guid("169f06b1-d649-496d-9f05-f59232e5b7cc"), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3728), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3727), 0, "CASABA", new Guid("6b63a1b6-8e6d-4dea-94ae-972351fcfa7f"), new Guid("32b1da23-2345-4fff-af31-f2c6ddca00e2") },
                    { new Guid("19290742-adb0-4a90-a40a-d3dcecd7722f"), new DateTime(2020, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3381), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3380), 0, "FLOKEY", new Guid("5d5ec955-5c89-4184-aad1-60a490b45d26"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("1b730010-57dc-40f8-b6f6-9eaa18ce3d2b"), new DateTime(2014, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3880), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3878), 0, "BOOZER", new Guid("f2ffc96b-952a-4734-b202-0715e0736247"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("1baee819-2ebb-4c48-9571-def68afbaae7"), new DateTime(2016, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3662), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3660), 0, "ALACA", new Guid("16c0ad3f-f23b-47cb-8388-77cdac0176a5"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("1e64c681-4c58-486d-91d4-34130ae1ca9d"), new DateTime(2019, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3977), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3975), 0, "KLUSIA", new Guid("cbf27b34-90a5-4ef5-8c88-629f2f11deb5"), new Guid("717009cf-c0cd-440a-b9e7-77f92ba7736f") },
                    { new Guid("22e84bce-a188-46bb-9d13-420b5057bdfe"), new DateTime(2020, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4946), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4945), 0, "SABASTEIN", new Guid("f0d909f2-8333-4c06-b2e5-bd7d8e8aab14"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("277434e2-f920-4b30-b27d-df630fc311cd"), new DateTime(2022, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3863), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3861), 0, "CASABA", new Guid("8f093f73-97e5-40b2-a2d6-021c3dafd195"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("2873d706-906f-4404-9e02-e06f9d3ddf1e"), new DateTime(2016, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4809), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4808), 0, "SABASTEIN", new Guid("cbf27b34-90a5-4ef5-8c88-629f2f11deb5"), new Guid("c9dda37a-9284-4681-b063-959feceeb3a8") },
                    { new Guid("28918e3a-a7a7-46b1-b997-bb4abc377ef5"), new DateTime(2016, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4702), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4700), 0, "KLUSIA", new Guid("f0d909f2-8333-4c06-b2e5-bd7d8e8aab14"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("2f1266da-9bb2-47ef-b7e4-60c30403424b"), new DateTime(2015, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4013), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4011), 0, "CASABA", new Guid("04459cfb-692e-4475-afb1-33d400cae41f"), new Guid("717009cf-c0cd-440a-b9e7-77f92ba7736f") },
                    { new Guid("30bc9e9b-3d76-46e1-b591-f2f8df5754b3"), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4365), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4363), 0, "CASABA", new Guid("276c1f3a-df96-4365-a817-2ac7f8dc3e82"), new Guid("c9dda37a-9284-4681-b063-959feceeb3a8") },
                    { new Guid("325e6ff8-e3dc-4b6a-865d-91e151fd71b2"), new DateTime(2018, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3347), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3345), 0, "CHUEY", new Guid("2c1d4616-73ca-4da3-866f-96b825633238"), new Guid("717009cf-c0cd-440a-b9e7-77f92ba7736f") },
                    { new Guid("332ad470-6a1d-4935-9d12-9fad8e1386a2"), new DateTime(2018, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3529), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3527), 0, "FLOKEY", new Guid("e8422ef2-f848-44d9-b654-19fa3d64a0c9"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("340926b7-72f7-47b7-8bd4-62f3b75dcaa5"), new DateTime(2022, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3628), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3626), 0, "LUPO", new Guid("b5e8071a-d25f-4735-888a-e9a258bb8e4d"), new Guid("32b1da23-2345-4fff-af31-f2c6ddca00e2") },
                    { new Guid("34753a3f-73bc-4e30-9549-d743512a798e"), new DateTime(2017, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3844), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3842), 0, "CHUEY", new Guid("b8254eb2-c72c-4f0f-92d2-dd611b51fb27"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("355bf34d-704b-467c-99bb-6353cc513b97"), new DateTime(2014, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4507), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4505), 0, "CASABA", new Guid("dbca6e1c-82c7-4737-89ea-a07538584caa"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("36a7bc32-75f6-4e9b-9c7c-d32b4c8c6360"), new DateTime(2022, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4298), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4296), 0, "JUANBOBO", new Guid("4c7c9bb0-0893-4367-b528-72e8f057446a"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("37ad2dc3-3edf-4de9-a10c-c2617e9f16c3"), new DateTime(2020, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4652), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4651), 0, "UFEK", new Guid("96ee043d-08f7-41e0-9c7e-fe08b9044ebc"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("3824cdba-52fe-486f-95f5-f1e6a82b6c3b"), new DateTime(2020, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4638), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4636), 0, "LUCKIE", new Guid("b8254eb2-c72c-4f0f-92d2-dd611b51fb27"), new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56") },
                    { new Guid("3b1fa282-6d4e-492e-82aa-6ffdb000e4c4"), new DateTime(2018, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4896), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4894), 0, "BOOM", new Guid("f3445268-2294-4e35-b6a0-67e81ef32629"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("3c70b30b-cfb0-4c9f-8630-7c350801283e"), new DateTime(2021, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4915), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4914), 0, "MANDO", new Guid("474db7bb-8245-41f5-8692-529d4b233c8e"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("42aa226a-7ab8-4984-a2e7-f05ee1263d5f"), new DateTime(2016, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3678), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3676), 0, "TWIGA", new Guid("a4bcdb88-61fa-4bbc-968c-0639294c8906"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("4755b654-c427-4096-9e42-1345cc9ebb23"), new DateTime(2015, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3694), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3692), 0, "BOOM", new Guid("e8422ef2-f848-44d9-b654-19fa3d64a0c9"), new Guid("717009cf-c0cd-440a-b9e7-77f92ba7736f") },
                    { new Guid("49ed827a-830e-4c0a-95ad-77991a0f9e58"), new DateTime(2022, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4620), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4618), 0, "UFEK", new Guid("1eb863c0-c465-4e47-930e-2f34bf15df45"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("4a83a64a-0bab-4f6c-be30-6cc980104bc8"), new DateTime(2014, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4847), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4845), 0, "JUANBOBO", new Guid("836556f8-ef67-4154-b77e-085146e347fc"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("4c288215-ecd1-4ecf-937d-4910c61641cb"), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4605), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4603), 0, "FLOKEY", new Guid("fca2afc6-7d2a-427c-82b4-1dc3f257c013"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("4de49bf7-8e49-4816-8aed-2053c0bb33df"), new DateTime(2021, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3066), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3065), 0, "FREEDOOM", new Guid("836556f8-ef67-4154-b77e-085146e347fc"), new Guid("32b1da23-2345-4fff-af31-f2c6ddca00e2") },
                    { new Guid("4e285e9b-0294-4821-823a-c6709706d678"), new DateTime(2018, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4399), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4398), 0, "MANDO", new Guid("4c7c9bb0-0893-4367-b528-72e8f057446a"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("4ec0ed94-e432-474e-b2ad-7b79b0397575"), new DateTime(2022, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4667), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4665), 0, "BOOM", new Guid("f0c71657-d493-451b-87e8-23ec3c10ea1d"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("58f3044a-729f-4f7d-96e7-25444c360b6d"), new DateTime(2014, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4282), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4280), 0, "CHUEY", new Guid("cc5fd2e3-c957-4226-a5fb-426ffabf5a10"), new Guid("32b1da23-2345-4fff-af31-f2c6ddca00e2") },
                    { new Guid("5a61275f-6307-48f1-9214-7bb16a4effc8"), new DateTime(2018, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4201), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4200), 0, "ALACA", new Guid("07fd045d-9b6f-4525-8c88-13367a62696e"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("5b7cda18-7ea3-4504-a0fb-6da861aaf676"), new DateTime(2022, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4065), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4063), 0, "BROWNEY", new Guid("a4bcdb88-61fa-4bbc-968c-0639294c8906"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("5f478889-2e75-41b9-b838-a110d78cb1a2"), new DateTime(2016, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4185), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4184), 0, "UFEK", new Guid("836556f8-ef67-4154-b77e-085146e347fc"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("6477dd91-70bb-4b9c-9082-7585d9cebef9"), new DateTime(2017, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4046), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4044), 0, "LUCKIE", new Guid("9e6402ea-8608-4fd9-acb1-87ac38e54b00"), new Guid("c9dda37a-9284-4681-b063-959feceeb3a8") },
                    { new Guid("67fd082f-3f53-46b3-8af5-a6e8191a04a9"), new DateTime(2019, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3178), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3176), 0, "BOOM", new Guid("d7cdf4b9-8655-4912-9f57-e1734cca3433"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("6825b413-3463-4c74-8662-ef72368ef8f6"), new DateTime(2014, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3713), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3711), 0, "CHUEY", new Guid("c3770496-c4fb-44e0-89c7-0ccfb10e6422"), new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56") },
                    { new Guid("6b3d7881-1d5d-4625-b2bc-8c18f6a9f57b"), new DateTime(2014, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4487), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4486), 0, "FLOKEY", new Guid("b8254eb2-c72c-4f0f-92d2-dd611b51fb27"), new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56") },
                    { new Guid("6b9dda79-08fb-4990-b286-abd276e3742f"), new DateTime(2021, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4317), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4315), 0, "TAIFA", new Guid("96ee043d-08f7-41e0-9c7e-fe08b9044ebc"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("6d34ef94-4aa9-49bf-8751-6f91df5d192a"), new DateTime(2018, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3494), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3492), 0, "RUBY", new Guid("8f093f73-97e5-40b2-a2d6-021c3dafd195"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("6fe52d0d-a4dd-45e2-86f3-6d3491e41546"), new DateTime(2022, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4827), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4825), 0, "MANDO", new Guid("ba69c9e8-7aef-433e-bee5-21b65e8e7924"), new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56") },
                    { new Guid("71f0812b-c6f1-4c11-bd62-d7fb683f2be2"), new DateTime(2020, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3611), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3609), 0, "TWIGA", new Guid("fca2afc6-7d2a-427c-82b4-1dc3f257c013"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("74640b5e-89a1-4dfa-883c-d63f71201420"), new DateTime(2020, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3896), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3894), 0, "RUBY", new Guid("7fac973b-5274-4642-ac85-69ebaff1d6db"), new Guid("32b1da23-2345-4fff-af31-f2c6ddca00e2") },
                    { new Guid("77be8399-ba67-4232-aad1-298a885de944"), new DateTime(2020, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3962), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3960), 0, "JUANBOBO", new Guid("b2bcb3be-fb0e-48d3-b637-2238d1a81742"), new Guid("c9dda37a-9284-4681-b063-959feceeb3a8") },
                    { new Guid("7b05d27a-6567-4ee9-9f58-134bae6cdd1a"), new DateTime(2020, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(5029), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(5028), 0, "BOOM", new Guid("dbca6e1c-82c7-4737-89ea-a07538584caa"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("7e071e9d-a0e9-4a0d-bbf4-360a332dc5c1"), new DateTime(2014, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4717), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4715), 0, "BROWNEY", new Guid("7fac973b-5274-4642-ac85-69ebaff1d6db"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("7f1064dd-a82f-453c-9367-3fb1f9444a60"), new DateTime(2014, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3226), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3224), 0, "CASABA", new Guid("c371d1cc-00aa-4db5-bfaf-7c93ae0fc281"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("82a90717-1623-4b1a-b124-5dbb6b1fd0f4"), new DateTime(2015, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4029), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4028), 0, "KLUSIA", new Guid("d52884fc-7218-4f65-a467-de9a9253b7ac"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("839aeecb-f79c-4e55-9cad-2ccf309fd504"), new DateTime(2014, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4332), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4331), 0, "MIKE", new Guid("1487a601-2e3f-4925-a441-f11771ca9331"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("86f61e72-7a14-4da5-aab6-2732bb04c9d7"), new DateTime(2019, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4523), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4521), 0, "JUANBOBO", new Guid("f0d909f2-8333-4c06-b2e5-bd7d8e8aab14"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("87b72fdf-0162-4e82-ba5f-b1b44e69d923"), new DateTime(2017, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3545), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3543), 0, "BOOZER", new Guid("474db7bb-8245-41f5-8692-529d4b233c8e"), new Guid("717009cf-c0cd-440a-b9e7-77f92ba7736f") },
                    { new Guid("883c758e-8408-4cb5-ad66-acea4b7e1628"), new DateTime(2016, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4348), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4346), 0, "LUCKIE", new Guid("ea7ba43f-4c05-4a3e-9c85-fcaae49ead38"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("8a7a35fd-ac06-455d-afb6-eb5bfff1eb87"), new DateTime(2020, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4167), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4165), 0, "UFEK", new Guid("8c1f9909-dd55-4ee4-9231-2dbcb2de862f"), new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56") },
                    { new Guid("908226ec-d2a1-45d7-886b-b85550fde710"), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3997), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3995), 0, "RUBY", new Guid("b5e8071a-d25f-4735-888a-e9a258bb8e4d"), new Guid("c9dda37a-9284-4681-b063-959feceeb3a8") },
                    { new Guid("927e59a5-9638-4e28-b16e-41a829d7226d"), new DateTime(2018, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3330), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3329), 0, "MAYA", new Guid("e8422ef2-f848-44d9-b654-19fa3d64a0c9"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("9366dfdf-965d-4b6f-872f-c9efce53fe0a"), new DateTime(2022, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(5049), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(5048), 0, "BLAZ", new Guid("d52884fc-7218-4f65-a467-de9a9253b7ac"), new Guid("32b1da23-2345-4fff-af31-f2c6ddca00e2") },
                    { new Guid("96f53566-5908-405f-a256-422d6bb50a23"), new DateTime(2022, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4879), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4877), 0, "MAYA", new Guid("633626e7-c38f-4921-a6f2-a8992a01695f"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("981e76d6-32da-4c0f-bd8b-21bb8cc5cd0b"), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4267), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4265), 0, "LUCKIE", new Guid("474db7bb-8245-41f5-8692-529d4b233c8e"), new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56") },
                    { new Guid("9b9b8fcf-6680-46c9-bdd5-6f55ff1ed1c4"), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3397), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3395), 0, "BOOZER", new Guid("07fd045d-9b6f-4525-8c88-13367a62696e"), new Guid("32b1da23-2345-4fff-af31-f2c6ddca00e2") },
                    { new Guid("9ba3565e-2756-444f-bdb5-9468d4fd9dd8"), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4587), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4586), 0, "KLUSIA", new Guid("f3445268-2294-4e35-b6a0-67e81ef32629"), new Guid("32b1da23-2345-4fff-af31-f2c6ddca00e2") },
                    { new Guid("9c03735f-f0d9-46d7-ad19-0e5591ec9c71"), new DateTime(2015, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4682), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4680), 0, "CASABA", new Guid("474db7bb-8245-41f5-8692-529d4b233c8e"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("9f52579f-62e8-4253-9421-9e0d5529f485"), new DateTime(2021, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4963), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4962), 0, "LUPO", new Guid("2c1d4616-73ca-4da3-866f-96b825633238"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("a14e2275-e4eb-4d48-98df-dbffc119b755"), new DateTime(2019, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3744), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3742), 0, "FLOKEY", new Guid("276c1f3a-df96-4365-a817-2ac7f8dc3e82"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("a1bdaa2e-96a6-4fbb-ac8e-e8026a060467"), new DateTime(2014, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3211), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3209), 0, "BROWNEY", new Guid("6330f354-5991-4fe6-b0da-aa167cbf96b9"), new Guid("717009cf-c0cd-440a-b9e7-77f92ba7736f") },
                    { new Guid("a1e98442-2aa8-499c-8830-babfba1fcce3"), new DateTime(2022, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4216), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4215), 0, "CASABA", new Guid("836556f8-ef67-4154-b77e-085146e347fc"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("ab936883-9909-4bca-a868-3f18040a470c"), new DateTime(2017, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3561), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3559), 0, "MIKE", new Guid("cc5fd2e3-c957-4226-a5fb-426ffabf5a10"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("ad568c6d-ac6c-4484-a10f-60fbc3c2a9aa"), new DateTime(2020, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4415), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4413), 0, "MAYA", new Guid("f0d909f2-8333-4c06-b2e5-bd7d8e8aab14"), new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56") },
                    { new Guid("afed533d-905e-45d8-8d3f-d2957c6385e6"), new DateTime(2014, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3646), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3645), 0, "MIKE", new Guid("ba69c9e8-7aef-433e-bee5-21b65e8e7924"), new Guid("32b1da23-2345-4fff-af31-f2c6ddca00e2") },
                    { new Guid("b7d32ace-fa4e-4be4-92aa-459c443db207"), new DateTime(2021, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3295), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3293), 0, "TAIFA", new Guid("96ee043d-08f7-41e0-9c7e-fe08b9044ebc"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("bf17cca9-b5b8-45b5-94f1-830bbd62fbbc"), new DateTime(2015, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(5014), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(5012), 0, "BROWNEY", new Guid("16c0ad3f-f23b-47cb-8388-77cdac0176a5"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("c186d1d2-24a2-494f-a813-a418dcfa0895"), new DateTime(2018, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3083), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3081), 0, "BOOM", new Guid("d7cdf4b9-8655-4912-9f57-e1734cca3433"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("c45e5201-fce3-4da1-97c1-638f6fa06537"), new DateTime(2017, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4232), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4230), 0, "BROWNEY", new Guid("ea7ba43f-4c05-4a3e-9c85-fcaae49ead38"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("c5576d2b-d5b2-43cc-9fd9-5c16b3c89ce4"), new DateTime(2017, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3931), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3929), 0, "JUANBOBO", new Guid("cea216c1-f435-4c81-9ae3-c74b89fd9ddf"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("c7747564-15f5-4833-bf7f-088ec520f58d"), new DateTime(2015, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4932), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4930), 0, "MANDO", new Guid("c371d1cc-00aa-4db5-bfaf-7c93ae0fc281"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("c7811669-b5dc-4d8e-9899-44a8357e3b47"), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3946), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3944), 0, "BROWNEY", new Guid("269b8217-e2ae-4d4e-9e34-ebead7462008"), new Guid("717009cf-c0cd-440a-b9e7-77f92ba7736f") },
                    { new Guid("c8078436-1ecf-496f-a86e-8fd1f391bc28"), new DateTime(2015, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3314), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3313), 0, "UFEK", new Guid("f2ffc96b-952a-4734-b202-0715e0736247"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("c93356e0-c5df-4012-b02b-63bc4f96db8c"), new DateTime(2019, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3048), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3046), 0, "ALACA", new Guid("6b63a1b6-8e6d-4dea-94ae-972351fcfa7f"), new Guid("717009cf-c0cd-440a-b9e7-77f92ba7736f") },
                    { new Guid("cf16cea8-228e-46ce-832a-c081596b9c1c"), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4997), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4996), 0, "SABASTEIN", new Guid("16c0ad3f-f23b-47cb-8388-77cdac0176a5"), new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56") },
                    { new Guid("d2d35f35-1cc4-4617-855c-c79d4217d573"), new DateTime(2015, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(5167), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(5165), 0, "SABASTEIN", new Guid("ea7ba43f-4c05-4a3e-9c85-fcaae49ead38"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("d2d6e165-cfa6-42ce-a987-11db81476696"), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4098), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4096), 0, "BROWNEY", new Guid("6b63a1b6-8e6d-4dea-94ae-972351fcfa7f"), new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56") },
                    { new Guid("d7bf55ba-f054-4f28-80b7-9ab67de6e124"), new DateTime(2018, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4081), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4080), 0, "TAIFA", new Guid("6298b950-aa92-45d3-b7f3-2c3b603f54d7"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("dc7161a5-2823-4ba1-9b5f-cf2eb5b7671c"), new DateTime(2015, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4572), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4570), 0, "CHUEY", new Guid("f2ffc96b-952a-4734-b202-0715e0736247"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("dd2a356c-ec21-4362-9ce8-48b2635be906"), new DateTime(2016, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3263), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3261), 0, "LUCKIE", new Guid("474db7bb-8245-41f5-8692-529d4b233c8e"), new Guid("32b1da23-2345-4fff-af31-f2c6ddca00e2") },
                    { new Guid("dd41a399-bb80-46ff-97a5-8405a9b69101"), new DateTime(2018, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3595), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3593), 0, "MIKE", new Guid("5eeec4d0-8dea-4f52-97dc-a0bc4da80c8b"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("e5042e97-8606-45fd-9ded-4cc0bd8e2890"), new DateTime(2022, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4251), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4250), 0, "CHUEY", new Guid("1487a601-2e3f-4925-a441-f11771ca9331"), new Guid("c9dda37a-9284-4681-b063-959feceeb3a8") },
                    { new Guid("e678a76b-2b2e-4df0-8507-f442a94e8628"), new DateTime(2016, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3412), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3411), 0, "CASABA", new Guid("6b63a1b6-8e6d-4dea-94ae-972351fcfa7f"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("e6a1186d-4bda-44b3-8c33-f633a99cf5e7"), new DateTime(2021, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3030), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3029), 1, "MIKE", new Guid("474db7bb-8245-41f5-8692-529d4b233c8e"), new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56") },
                    { new Guid("e7ce2366-c49c-43d2-bd1a-bc51d06e07c2"), new DateTime(2014, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3513), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3512), 0, "MANDO", new Guid("633626e7-c38f-4921-a6f2-a8992a01695f"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("ea060651-82ad-44ad-a416-d182a93cd7d7"), new DateTime(2022, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3362), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3361), 0, "BOOZER", new Guid("276c1f3a-df96-4365-a817-2ac7f8dc3e82"), new Guid("c9dda37a-9284-4681-b063-959feceeb3a8") },
                    { new Guid("ea9e33a2-6423-40c7-8458-f231e241a48d"), new DateTime(2015, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4863), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4861), 0, "BOOZER", new Guid("1487a601-2e3f-4925-a441-f11771ca9331"), new Guid("c9dda37a-9284-4681-b063-959feceeb3a8") },
                    { new Guid("f1406458-eb5b-4b12-9a3a-44e0af77fefb"), new DateTime(2016, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3247), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(3245), 0, "WALTER", new Guid("16c0ad3f-f23b-47cb-8388-77cdac0176a5"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("f42cd749-8586-436e-bc85-704764629fa9"), new DateTime(2022, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4982), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4980), 0, "FLOKEY", new Guid("ff09805c-1069-4e10-8f74-42a86c3eb034"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("f4e64e7d-896d-40d9-bf35-eb24540d49a7"), new DateTime(2016, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(5065), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(5063), 0, "TAIFA", new Guid("b5e8071a-d25f-4735-888a-e9a258bb8e4d"), new Guid("32b1da23-2345-4fff-af31-f2c6ddca00e2") },
                    { new Guid("fa31ccd2-97ac-473b-ad32-4580cb1200c1"), new DateTime(2022, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4539), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4537), 0, "RUBY", new Guid("2c1d4616-73ca-4da3-866f-96b825633238"), new Guid("32b1da23-2345-4fff-af31-f2c6ddca00e2") },
                    { new Guid("fdd870dd-a2b8-4e4b-b1aa-9f2650ff8a93"), new DateTime(2022, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4383), new DateTime(2023, 12, 29, 14, 40, 8, 428, DateTimeKind.Utc).AddTicks(4382), 0, "RUBY", new Guid("0696f671-ccd6-4125-8bcf-c62f384587e9"), new Guid("c9dda37a-9284-4681-b063-959feceeb3a8") }
                });

            migrationBuilder.InsertData(
                table: "PetBlackList",
                columns: new[] { "Id", "PetId", "PetTypeId" },
                values: new object[,]
                {
                    { new Guid("0269621a-e624-4daf-b646-3846c3003828"), new Guid("2f1266da-9bb2-47ef-b7e4-60c30403424b"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("045ac0f4-6758-4d64-8881-a0cea5306bdf"), new Guid("927e59a5-9638-4e28-b16e-41a829d7226d"), new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56") },
                    { new Guid("0677174c-9e4f-42c4-86e2-65ebfb0bb8c9"), new Guid("74640b5e-89a1-4dfa-883c-d63f71201420"), new Guid("32b1da23-2345-4fff-af31-f2c6ddca00e2") },
                    { new Guid("082c0996-6e9c-4c88-8456-9e8c851be2dc"), new Guid("74640b5e-89a1-4dfa-883c-d63f71201420"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("0bcbaa26-09b3-43e3-9274-f85e36d1221c"), new Guid("c93356e0-c5df-4012-b02b-63bc4f96db8c"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("0eb9c959-b66e-42be-b49a-a303ba94ad8a"), new Guid("1baee819-2ebb-4c48-9571-def68afbaae7"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("0ec7ac08-2897-4b78-b419-151c2743700d"), new Guid("05d9780d-2c4b-4846-8048-6c5afdeca6ac"), new Guid("c9dda37a-9284-4681-b063-959feceeb3a8") },
                    { new Guid("13a124fd-0e4f-4db1-ac91-14d735db5468"), new Guid("dd41a399-bb80-46ff-97a5-8405a9b69101"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("16a5446f-0b5f-4ebf-868e-cef90963b564"), new Guid("9b9b8fcf-6680-46c9-bdd5-6f55ff1ed1c4"), new Guid("717009cf-c0cd-440a-b9e7-77f92ba7736f") },
                    { new Guid("1ac5c3d8-c8fc-4581-adf9-cbb133ecc817"), new Guid("ea060651-82ad-44ad-a416-d182a93cd7d7"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("1f5fe1f4-7914-4588-94ad-6e3625a53d3a"), new Guid("e678a76b-2b2e-4df0-8507-f442a94e8628"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("2068f256-0780-452b-b495-ff6c6870f31f"), new Guid("4de49bf7-8e49-4816-8aed-2053c0bb33df"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("20b70bb3-dc43-4f68-818b-5f5039f9211d"), new Guid("34753a3f-73bc-4e30-9549-d743512a798e"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("20baba0d-b86c-4990-8f89-81c7422b78d8"), new Guid("19290742-adb0-4a90-a40a-d3dcecd7722f"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("2125dc0d-f4f7-4c2e-b0c2-2edde49e8c1a"), new Guid("67fd082f-3f53-46b3-8af5-a6e8191a04a9"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("2207f7ea-067a-4421-9fb6-3f7439f7531d"), new Guid("c5576d2b-d5b2-43cc-9fd9-5c16b3c89ce4"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("24541bb9-6e91-477d-bf29-24721083f9b7"), new Guid("277434e2-f920-4b30-b27d-df630fc311cd"), new Guid("c9dda37a-9284-4681-b063-959feceeb3a8") },
                    { new Guid("28ab4844-65da-4611-8a5d-b1bc68ad970a"), new Guid("927e59a5-9638-4e28-b16e-41a829d7226d"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("2d37520c-3c4b-41f3-a80a-d71c2dca59cf"), new Guid("f1406458-eb5b-4b12-9a3a-44e0af77fefb"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("30873a98-d33b-4b4c-9205-aed9550609ad"), new Guid("1e64c681-4c58-486d-91d4-34130ae1ca9d"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("312ec8ef-0880-4e7d-a5cf-1cfd7ab12c8b"), new Guid("1b730010-57dc-40f8-b6f6-9eaa18ce3d2b"), new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56") },
                    { new Guid("35cafe12-53f3-499f-948e-17b1eac158fc"), new Guid("71f0812b-c6f1-4c11-bd62-d7fb683f2be2"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("3717289f-6cca-4e93-8de1-f475f3c4b5a0"), new Guid("34753a3f-73bc-4e30-9549-d743512a798e"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("384fcdcb-375f-48a9-b78b-834e987635a6"), new Guid("1e64c681-4c58-486d-91d4-34130ae1ca9d"), new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56") },
                    { new Guid("3a5201fd-c170-4441-8d3b-fb2f58bb4584"), new Guid("340926b7-72f7-47b7-8bd4-62f3b75dcaa5"), new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56") },
                    { new Guid("3b84c8ae-7bbe-480e-ad64-31ed87aa1949"), new Guid("67fd082f-3f53-46b3-8af5-a6e8191a04a9"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("3c5e6941-b7eb-481c-be35-279f11bff2b1"), new Guid("c186d1d2-24a2-494f-a813-a418dcfa0895"), new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56") },
                    { new Guid("3f8bfaa2-57c8-4f18-8087-eaaa3e1297b3"), new Guid("a1bdaa2e-96a6-4fbb-ac8e-e8026a060467"), new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56") },
                    { new Guid("41fe7b26-ee91-490e-b8de-0ccd7981e596"), new Guid("340926b7-72f7-47b7-8bd4-62f3b75dcaa5"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("42b13f61-6d31-4889-a23c-306b15cfb359"), new Guid("dd41a399-bb80-46ff-97a5-8405a9b69101"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("43681466-b149-4cae-be8f-e06a87fe070f"), new Guid("7f1064dd-a82f-453c-9367-3fb1f9444a60"), new Guid("c9dda37a-9284-4681-b063-959feceeb3a8") },
                    { new Guid("44ddd232-53db-4ff1-a0d1-9a7e11a3e1c2"), new Guid("169f06b1-d649-496d-9f05-f59232e5b7cc"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("4ac4c842-9cd5-4665-9622-c1b575589871"), new Guid("1baee819-2ebb-4c48-9571-def68afbaae7"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("4b810e10-ed32-45d9-afc4-d33eb6bebc05"), new Guid("14315ec2-4158-48cf-ba1c-a61d9b88d74e"), new Guid("32b1da23-2345-4fff-af31-f2c6ddca00e2") },
                    { new Guid("4b922fa1-a78c-4f19-b3c9-fd0c763fdad2"), new Guid("325e6ff8-e3dc-4b6a-865d-91e151fd71b2"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("4cf9654c-c32e-4a62-ba20-c25d81a52e34"), new Guid("6d34ef94-4aa9-49bf-8751-6f91df5d192a"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("4e8ba9ba-5337-4719-9c55-ffdc9ceb7fb0"), new Guid("afed533d-905e-45d8-8d3f-d2957c6385e6"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("571b19e9-b092-491f-af60-e81329026b17"), new Guid("6825b413-3463-4c74-8662-ef72368ef8f6"), new Guid("c9dda37a-9284-4681-b063-959feceeb3a8") },
                    { new Guid("577feffa-dcfc-4d03-a8a2-4de569012577"), new Guid("77be8399-ba67-4232-aad1-298a885de944"), new Guid("c9dda37a-9284-4681-b063-959feceeb3a8") },
                    { new Guid("5da7a9fb-ec2d-46f0-8833-1e8125c7025f"), new Guid("82a90717-1623-4b1a-b124-5dbb6b1fd0f4"), new Guid("32b1da23-2345-4fff-af31-f2c6ddca00e2") },
                    { new Guid("606fc267-8945-43c8-a8a9-9b9ffc368980"), new Guid("dd2a356c-ec21-4362-9ce8-48b2635be906"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("6157f82a-2149-4b6f-99d3-74cac96e8c4b"), new Guid("4de49bf7-8e49-4816-8aed-2053c0bb33df"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("6343d2c9-aad4-4976-a56a-33e08bf0abfc"), new Guid("e6a1186d-4bda-44b3-8c33-f633a99cf5e7"), new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56") },
                    { new Guid("635761d1-6c1c-4e75-9daf-4e51cb6a5cec"), new Guid("e6a1186d-4bda-44b3-8c33-f633a99cf5e7"), new Guid("717009cf-c0cd-440a-b9e7-77f92ba7736f") },
                    { new Guid("66b6d18b-4d14-4bd1-8f8d-d722f3982148"), new Guid("07f6069e-6fd6-4459-b912-af05eb4949b6"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("676abb4e-95b8-4206-a79e-7e1b74ede9c3"), new Guid("2f1266da-9bb2-47ef-b7e4-60c30403424b"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("6834c5fb-3b44-416d-a5ad-49f91752f16d"), new Guid("a14e2275-e4eb-4d48-98df-dbffc119b755"), new Guid("c9dda37a-9284-4681-b063-959feceeb3a8") },
                    { new Guid("69ad259f-b7eb-4130-9301-c2e9b429b5df"), new Guid("dd2a356c-ec21-4362-9ce8-48b2635be906"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("6d87a221-8a1d-4d41-8e7a-3c3d4faa2d41"), new Guid("afed533d-905e-45d8-8d3f-d2957c6385e6"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("6f7c04bd-8a17-49e5-9629-c6fadf8a1e45"), new Guid("5b7cda18-7ea3-4504-a0fb-6da861aaf676"), new Guid("c9dda37a-9284-4681-b063-959feceeb3a8") },
                    { new Guid("70098187-901e-4df3-857a-0b314d541451"), new Guid("e678a76b-2b2e-4df0-8507-f442a94e8628"), new Guid("717009cf-c0cd-440a-b9e7-77f92ba7736f") },
                    { new Guid("702cce1f-bcc5-40fb-8f27-64f1974dbd42"), new Guid("e7ce2366-c49c-43d2-bd1a-bc51d06e07c2"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("74cf69b5-dd0d-41fb-8e9f-bcc5e07fa257"), new Guid("ea060651-82ad-44ad-a416-d182a93cd7d7"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("78272d49-9fe3-4a53-ae7e-3c0b223f8377"), new Guid("c8078436-1ecf-496f-a86e-8fd1f391bc28"), new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56") },
                    { new Guid("783bc583-dd79-4da6-a152-628d280c5ef0"), new Guid("4755b654-c427-4096-9e42-1345cc9ebb23"), new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56") },
                    { new Guid("793d5d63-b090-4e01-82ba-6ed95ae8415a"), new Guid("b7d32ace-fa4e-4be4-92aa-459c443db207"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("7e49835f-8d87-4f92-8339-7707383f15dc"), new Guid("14315ec2-4158-48cf-ba1c-a61d9b88d74e"), new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56") },
                    { new Guid("7ea48afc-488b-45c0-9d60-172c085f58fd"), new Guid("6d34ef94-4aa9-49bf-8751-6f91df5d192a"), new Guid("717009cf-c0cd-440a-b9e7-77f92ba7736f") },
                    { new Guid("7fe9b482-35bd-47d4-83f1-6ee577a48a23"), new Guid("908226ec-d2a1-45d7-886b-b85550fde710"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("80c6e03a-a575-4f9e-8889-c413a248150c"), new Guid("c93356e0-c5df-4012-b02b-63bc4f96db8c"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("811385c2-2126-4e9b-8411-fb84d9bebe63"), new Guid("1388efbe-339a-4228-a1ba-7934614223ef"), new Guid("32b1da23-2345-4fff-af31-f2c6ddca00e2") },
                    { new Guid("8404dfc3-2582-43cc-817f-bc98a4842afd"), new Guid("c186d1d2-24a2-494f-a813-a418dcfa0895"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("8506a7d4-46e6-4316-a06c-aa622d49cb36"), new Guid("332ad470-6a1d-4935-9d12-9fad8e1386a2"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("8689b1fe-d6bf-4e2f-9ff9-59bc8c54ed84"), new Guid("42aa226a-7ab8-4984-a2e7-f05ee1263d5f"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("8c334e7a-dfb9-4bb2-a483-ea958a848e5f"), new Guid("1b730010-57dc-40f8-b6f6-9eaa18ce3d2b"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("8c7efcd0-f76e-4db3-b5f8-b39bd423f420"), new Guid("42aa226a-7ab8-4984-a2e7-f05ee1263d5f"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("91e55a42-5217-4ac0-97e8-bb4f059b5738"), new Guid("d7bf55ba-f054-4f28-80b7-9ab67de6e124"), new Guid("717009cf-c0cd-440a-b9e7-77f92ba7736f") },
                    { new Guid("938fa80a-b420-4004-a10c-698f27901d3a"), new Guid("6477dd91-70bb-4b9c-9082-7585d9cebef9"), new Guid("c9dda37a-9284-4681-b063-959feceeb3a8") },
                    { new Guid("94e18a87-2a16-4e5b-acd0-4f687a33402c"), new Guid("87b72fdf-0162-4e82-ba5f-b1b44e69d923"), new Guid("c9dda37a-9284-4681-b063-959feceeb3a8") },
                    { new Guid("94f09ced-a245-454b-be34-f52d13d5ad98"), new Guid("169f06b1-d649-496d-9f05-f59232e5b7cc"), new Guid("717009cf-c0cd-440a-b9e7-77f92ba7736f") },
                    { new Guid("9c446c8f-806f-47e9-b9e5-a000fef51200"), new Guid("07f6069e-6fd6-4459-b912-af05eb4949b6"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("a01ad797-5145-41a5-a875-306700b05c47"), new Guid("19290742-adb0-4a90-a40a-d3dcecd7722f"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("a0efbceb-8188-4dbe-864d-17e9ac6b3660"), new Guid("e7ce2366-c49c-43d2-bd1a-bc51d06e07c2"), new Guid("32b1da23-2345-4fff-af31-f2c6ddca00e2") },
                    { new Guid("a1766420-f21e-4121-ad96-2d833fb866c6"), new Guid("c5576d2b-d5b2-43cc-9fd9-5c16b3c89ce4"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("a31f5197-51d1-4364-bdcc-2679c0828c1a"), new Guid("5b7cda18-7ea3-4504-a0fb-6da861aaf676"), new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56") },
                    { new Guid("ab1b4c36-9a22-449e-9881-75dca0ea5e36"), new Guid("f1406458-eb5b-4b12-9a3a-44e0af77fefb"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("ab276b67-3b46-4c07-b921-5c90123848ae"), new Guid("05d9780d-2c4b-4846-8048-6c5afdeca6ac"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("ad37ca03-12ac-4704-bc0e-b5f1ff2f21df"), new Guid("ab936883-9909-4bca-a868-3f18040a470c"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("b14cfcf1-d37e-40d3-9513-b4b5c13c2601"), new Guid("c8078436-1ecf-496f-a86e-8fd1f391bc28"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("b1bdaa2d-a099-4f9d-8392-b209944e443f"), new Guid("71f0812b-c6f1-4c11-bd62-d7fb683f2be2"), new Guid("717009cf-c0cd-440a-b9e7-77f92ba7736f") },
                    { new Guid("b2b995a3-77dd-466b-b408-02882fa5337e"), new Guid("908226ec-d2a1-45d7-886b-b85550fde710"), new Guid("c9dda37a-9284-4681-b063-959feceeb3a8") },
                    { new Guid("b442a119-9847-490e-b6bc-43e8ef9b9325"), new Guid("b7d32ace-fa4e-4be4-92aa-459c443db207"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("b9a82a74-5342-432d-9633-e9d20e155830"), new Guid("1388efbe-339a-4228-a1ba-7934614223ef"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("bc461aea-8dd3-469c-a4b0-3713fcb81fe1"), new Guid("4755b654-c427-4096-9e42-1345cc9ebb23"), new Guid("32b1da23-2345-4fff-af31-f2c6ddca00e2") },
                    { new Guid("bdced783-0458-4c7a-98a3-67e0034069b4"), new Guid("c7811669-b5dc-4d8e-9899-44a8357e3b47"), new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56") },
                    { new Guid("bf29f3fa-4d4b-4079-a3d8-18d7f7081643"), new Guid("a14e2275-e4eb-4d48-98df-dbffc119b755"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("bfb8da60-9a46-4186-a1a6-18719eecce02"), new Guid("87b72fdf-0162-4e82-ba5f-b1b44e69d923"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("c247540a-bd8d-487f-ab35-32f944857cab"), new Guid("c7811669-b5dc-4d8e-9899-44a8357e3b47"), new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d") },
                    { new Guid("c39d77a5-0010-48f5-944e-c933066b4bd7"), new Guid("6477dd91-70bb-4b9c-9082-7585d9cebef9"), new Guid("32b1da23-2345-4fff-af31-f2c6ddca00e2") },
                    { new Guid("c5b90544-0554-4907-b662-ae60f3da6dbf"), new Guid("00d77d77-a4d8-4990-9bb0-d6481338cb39"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("c830d9ee-7b81-49c9-9668-3cf4a9875177"), new Guid("7f1064dd-a82f-453c-9367-3fb1f9444a60"), new Guid("32b1da23-2345-4fff-af31-f2c6ddca00e2") },
                    { new Guid("cdc54be0-f890-4b59-afef-3a78e5e1d5a9"), new Guid("332ad470-6a1d-4935-9d12-9fad8e1386a2"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("cec3bf4f-fd5f-4fa6-893d-96038fb8f1cc"), new Guid("00d77d77-a4d8-4990-9bb0-d6481338cb39"), new Guid("32b1da23-2345-4fff-af31-f2c6ddca00e2") },
                    { new Guid("ced07cad-f4c7-40f9-93af-8c4788e226b6"), new Guid("325e6ff8-e3dc-4b6a-865d-91e151fd71b2"), new Guid("c9dda37a-9284-4681-b063-959feceeb3a8") },
                    { new Guid("d15348d1-1675-441e-84c0-6cd946096161"), new Guid("ab936883-9909-4bca-a868-3f18040a470c"), new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56") },
                    { new Guid("d16289d4-4820-4480-aa22-004b9569a751"), new Guid("9b9b8fcf-6680-46c9-bdd5-6f55ff1ed1c4"), new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303") },
                    { new Guid("d58ac7ff-bd38-4bef-8645-92ecda81d086"), new Guid("d7bf55ba-f054-4f28-80b7-9ab67de6e124"), new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8") },
                    { new Guid("dfd04e25-ad91-41a0-abc0-744ee7bde3f0"), new Guid("82a90717-1623-4b1a-b124-5dbb6b1fd0f4"), new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5") },
                    { new Guid("eac51c2e-8d7f-4081-badf-b88ee576ccd6"), new Guid("277434e2-f920-4b30-b27d-df630fc311cd"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("f2bd207a-3087-400f-a9bb-216fd6b4109d"), new Guid("6825b413-3463-4c74-8662-ef72368ef8f6"), new Guid("32b1da23-2345-4fff-af31-f2c6ddca00e2") },
                    { new Guid("f89f47ca-28d7-4254-a016-274df754ea40"), new Guid("77be8399-ba67-4232-aad1-298a885de944"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") },
                    { new Guid("fd57b349-9ec7-4129-8c45-4cb7997470f8"), new Guid("a1bdaa2e-96a6-4fbb-ac8e-e8026a060467"), new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70") }
                });

            migrationBuilder.InsertData(
                table: "PetTraits",
                columns: new[] { "Id", "PetId", "TraitId" },
                values: new object[,]
                {
                    { new Guid("00002f68-1514-4a7e-b25e-302a2e6f7e70"), new Guid("12d13f50-09f0-4607-b210-36aab22eeff7"), new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024") },
                    { new Guid("0360e8d7-e282-4ca9-8011-1a1f55b84233"), new Guid("42aa226a-7ab8-4984-a2e7-f05ee1263d5f"), new Guid("83ccd7f1-1c9e-4d31-96c4-7c4fd5b66b04") },
                    { new Guid("053e0c43-cb67-438d-b3d5-90c1c5359d99"), new Guid("f42cd749-8586-436e-bc85-704764629fa9"), new Guid("0ae3667d-8f40-412e-82b3-aae6cf496440") },
                    { new Guid("0590f601-55c3-4bc5-80a2-fa673f2fac18"), new Guid("9c03735f-f0d9-46d7-ad19-0e5591ec9c71"), new Guid("1b9c8d1a-1dcb-4651-96b9-a28206738e0c") },
                    { new Guid("0622d60a-f7e8-404b-a83a-bb4c848735a1"), new Guid("96f53566-5908-405f-a256-422d6bb50a23"), new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024") },
                    { new Guid("06a09e97-58af-4e34-a185-109841723990"), new Guid("2873d706-906f-4404-9e02-e06f9d3ddf1e"), new Guid("71949e9b-637a-438b-8694-d9e440ec5df3") },
                    { new Guid("07c38b7f-fe41-4ee7-8352-ebafd2fadc6a"), new Guid("9366dfdf-965d-4b6f-872f-c9efce53fe0a"), new Guid("92ca8c89-1934-4e91-b501-7ba45719a744") },
                    { new Guid("07f43227-6d50-46e0-b702-0ce74df6a683"), new Guid("87b72fdf-0162-4e82-ba5f-b1b44e69d923"), new Guid("ca979c56-0d86-44ec-9e66-9f1d1b2901cf") },
                    { new Guid("08da310b-1515-4c08-b9d2-e7811a0339fd"), new Guid("927e59a5-9638-4e28-b16e-41a829d7226d"), new Guid("a6e7cba0-c2e2-4989-beb1-b9109543bdfe") },
                    { new Guid("08f5d742-9a56-4828-ad06-c57434ea0315"), new Guid("c7747564-15f5-4833-bf7f-088ec520f58d"), new Guid("52223944-550b-4b2a-8153-7c52341506ae") },
                    { new Guid("090a483c-81c0-4dcd-967e-6aa3f60f4d0b"), new Guid("fa31ccd2-97ac-473b-ad32-4580cb1200c1"), new Guid("8a60b900-510a-489f-af33-6ca3e36003ce") },
                    { new Guid("0969ffcd-c40f-44a5-beeb-788d63bd6db8"), new Guid("bf17cca9-b5b8-45b5-94f1-830bbd62fbbc"), new Guid("81070cd0-8b4a-4300-bb57-655c4298460c") },
                    { new Guid("0a2291cf-cc9a-4fc3-9892-5cc83956ef26"), new Guid("9ba3565e-2756-444f-bdb5-9468d4fd9dd8"), new Guid("d2d2e4da-7eae-4f44-8078-594e60f967e1") },
                    { new Guid("0a8f2b78-a97a-4aef-8b92-2862fa49c3e1"), new Guid("f1406458-eb5b-4b12-9a3a-44e0af77fefb"), new Guid("20a451ec-b864-4e51-b4b1-8bb720f5fd9f") },
                    { new Guid("0aa00fdd-98b3-47e5-8526-d973fe1b84ed"), new Guid("e7ce2366-c49c-43d2-bd1a-bc51d06e07c2"), new Guid("78b624a4-9528-4c48-b6fd-29b7308ae44f") },
                    { new Guid("0c7c28cd-eb40-4400-ab1a-c3cb6e0c6c69"), new Guid("dc7161a5-2823-4ba1-9b5f-cf2eb5b7671c"), new Guid("0ae3667d-8f40-412e-82b3-aae6cf496440") },
                    { new Guid("0c9731bd-bb2d-401e-bf0c-22bd8a4ba2b5"), new Guid("afed533d-905e-45d8-8d3f-d2957c6385e6"), new Guid("ec0827e0-83c5-4d96-b445-30bfb4eff9e0") },
                    { new Guid("0cc29f82-6e6f-4ac6-81ee-da3a32943c49"), new Guid("1e64c681-4c58-486d-91d4-34130ae1ca9d"), new Guid("0ae3667d-8f40-412e-82b3-aae6cf496440") },
                    { new Guid("0ef22201-9c6c-4ac9-9e5d-a78e2338e536"), new Guid("e5042e97-8606-45fd-9ded-4cc0bd8e2890"), new Guid("a6e7cba0-c2e2-4989-beb1-b9109543bdfe") },
                    { new Guid("102e9919-4c35-47a3-a8f8-049a8f459652"), new Guid("36a7bc32-75f6-4e9b-9c7c-d32b4c8c6360"), new Guid("ca979c56-0d86-44ec-9e66-9f1d1b2901cf") },
                    { new Guid("10b4a370-963a-4394-809d-7aa1ee435c85"), new Guid("c93356e0-c5df-4012-b02b-63bc4f96db8c"), new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024") },
                    { new Guid("115924c5-21f9-40e4-8b7b-eea2d55d8936"), new Guid("325e6ff8-e3dc-4b6a-865d-91e151fd71b2"), new Guid("351cdd42-dec1-40ff-9fa5-02bcf0093f48") },
                    { new Guid("1356b093-d6c0-4cc4-bf5b-98f9f4c63cd9"), new Guid("fdd870dd-a2b8-4e4b-b1aa-9f2650ff8a93"), new Guid("83ccd7f1-1c9e-4d31-96c4-7c4fd5b66b04") },
                    { new Guid("1398b9a1-b7ca-42cd-bc84-65fdf6c29e1e"), new Guid("e678a76b-2b2e-4df0-8507-f442a94e8628"), new Guid("1199807b-46a7-4610-8df2-c7df16a2f8f8") },
                    { new Guid("1794fa02-64cd-4218-b062-503037ace657"), new Guid("9f52579f-62e8-4253-9421-9e0d5529f485"), new Guid("ca979c56-0d86-44ec-9e66-9f1d1b2901cf") },
                    { new Guid("17e1a18e-1db3-42b1-945d-3e4924c69acc"), new Guid("c5576d2b-d5b2-43cc-9fd9-5c16b3c89ce4"), new Guid("1b9c8d1a-1dcb-4651-96b9-a28206738e0c") },
                    { new Guid("18ccb4cf-a73d-4476-96e8-8bcccbd287bc"), new Guid("5a61275f-6307-48f1-9214-7bb16a4effc8"), new Guid("d2d2e4da-7eae-4f44-8078-594e60f967e1") },
                    { new Guid("192f9dae-ecc3-49a4-a741-66d4e63ff122"), new Guid("4755b654-c427-4096-9e42-1345cc9ebb23"), new Guid("52223944-550b-4b2a-8153-7c52341506ae") },
                    { new Guid("1a7e2e07-a03b-4ec8-8bea-f2d2ffca312f"), new Guid("6b3d7881-1d5d-4625-b2bc-8c18f6a9f57b"), new Guid("ca979c56-0d86-44ec-9e66-9f1d1b2901cf") },
                    { new Guid("1b4c8474-f4d3-4bb2-8c6a-aa2b667749d8"), new Guid("82a90717-1623-4b1a-b124-5dbb6b1fd0f4"), new Guid("52223944-550b-4b2a-8153-7c52341506ae") },
                    { new Guid("1ba3b3d3-bd63-49b0-97c7-3f2ca95c6203"), new Guid("6477dd91-70bb-4b9c-9082-7585d9cebef9"), new Guid("52223944-550b-4b2a-8153-7c52341506ae") },
                    { new Guid("1c65f4da-b2ef-4dd2-b638-dda2f8604ab0"), new Guid("7e071e9d-a0e9-4a0d-bbf4-360a332dc5c1"), new Guid("8a60b900-510a-489f-af33-6ca3e36003ce") },
                    { new Guid("1cfa4132-ebe7-4158-8b4f-050aa645a881"), new Guid("4c288215-ecd1-4ecf-937d-4910c61641cb"), new Guid("351cdd42-dec1-40ff-9fa5-02bcf0093f48") },
                    { new Guid("1d32d79a-93a6-4700-9a11-297f511cc166"), new Guid("5f478889-2e75-41b9-b838-a110d78cb1a2"), new Guid("0ae3667d-8f40-412e-82b3-aae6cf496440") },
                    { new Guid("1f0d70ee-ad38-436c-a3fa-41654641c882"), new Guid("169f06b1-d649-496d-9f05-f59232e5b7cc"), new Guid("92ca8c89-1934-4e91-b501-7ba45719a744") },
                    { new Guid("21a620f7-b553-40e9-9ee2-8916cfc7c869"), new Guid("e6a1186d-4bda-44b3-8c33-f633a99cf5e7"), new Guid("81070cd0-8b4a-4300-bb57-655c4298460c") },
                    { new Guid("22fcbdb3-3e3d-4a95-a551-cae1fdde049d"), new Guid("4a83a64a-0bab-4f6c-be30-6cc980104bc8"), new Guid("8a60b900-510a-489f-af33-6ca3e36003ce") },
                    { new Guid("235f1af8-0378-48e3-ae14-ffe0d658857c"), new Guid("277434e2-f920-4b30-b27d-df630fc311cd"), new Guid("20a451ec-b864-4e51-b4b1-8bb720f5fd9f") },
                    { new Guid("24f68ae7-ef0c-45f7-a011-59c57c944bad"), new Guid("ab936883-9909-4bca-a868-3f18040a470c"), new Guid("83ccd7f1-1c9e-4d31-96c4-7c4fd5b66b04") },
                    { new Guid("25739e79-2b80-451c-985c-5519c63cbb71"), new Guid("2873d706-906f-4404-9e02-e06f9d3ddf1e"), new Guid("1199807b-46a7-4610-8df2-c7df16a2f8f8") },
                    { new Guid("25901e37-5442-42dc-a7f4-9a443169a066"), new Guid("86f61e72-7a14-4da5-aab6-2732bb04c9d7"), new Guid("d2d2e4da-7eae-4f44-8078-594e60f967e1") },
                    { new Guid("25952684-771c-43a9-9699-cc35f5135ac9"), new Guid("7b05d27a-6567-4ee9-9f58-134bae6cdd1a"), new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024") },
                    { new Guid("26db3c81-df26-43a3-9bc4-5aa255482230"), new Guid("325e6ff8-e3dc-4b6a-865d-91e151fd71b2"), new Guid("a332d831-d29f-4d11-ba6d-a45fd19b7f8a") },
                    { new Guid("27562d7f-7615-4979-948b-460011d38efd"), new Guid("5b7cda18-7ea3-4504-a0fb-6da861aaf676"), new Guid("d2d2e4da-7eae-4f44-8078-594e60f967e1") },
                    { new Guid("27d91ecc-4e56-4e9e-a401-96295a56b36e"), new Guid("3824cdba-52fe-486f-95f5-f1e6a82b6c3b"), new Guid("92ca8c89-1934-4e91-b501-7ba45719a744") },
                    { new Guid("28084fa3-5e6a-4596-a066-5545f052b8f8"), new Guid("22e84bce-a188-46bb-9d13-420b5057bdfe"), new Guid("a6e7cba0-c2e2-4989-beb1-b9109543bdfe") },
                    { new Guid("284a690a-464a-4a29-81ed-2975686e58dd"), new Guid("9f52579f-62e8-4253-9421-9e0d5529f485"), new Guid("a332d831-d29f-4d11-ba6d-a45fd19b7f8a") },
                    { new Guid("29c53722-de32-4e44-a64f-ec41648bda51"), new Guid("6b3d7881-1d5d-4625-b2bc-8c18f6a9f57b"), new Guid("d2d2e4da-7eae-4f44-8078-594e60f967e1") },
                    { new Guid("29ca0f6e-149a-4cda-845d-693f5902d698"), new Guid("3824cdba-52fe-486f-95f5-f1e6a82b6c3b"), new Guid("a332d831-d29f-4d11-ba6d-a45fd19b7f8a") },
                    { new Guid("29d9c972-a382-40a2-8ba4-e0e727434bd3"), new Guid("981e76d6-32da-4c0f-bd8b-21bb8cc5cd0b"), new Guid("d2d2e4da-7eae-4f44-8078-594e60f967e1") },
                    { new Guid("2a11b407-f048-4eac-b26b-1f3bc13a2a21"), new Guid("f4e64e7d-896d-40d9-bf35-eb24540d49a7"), new Guid("8a60b900-510a-489f-af33-6ca3e36003ce") },
                    { new Guid("2c69ab50-d0b1-430e-8223-7feb3d9073ca"), new Guid("30bc9e9b-3d76-46e1-b591-f2f8df5754b3"), new Guid("20a451ec-b864-4e51-b4b1-8bb720f5fd9f") },
                    { new Guid("2d32a960-4fae-4a95-9d3b-997e731266b7"), new Guid("6b9dda79-08fb-4990-b286-abd276e3742f"), new Guid("ec0827e0-83c5-4d96-b445-30bfb4eff9e0") },
                    { new Guid("2df3fde3-d708-4b41-a7e2-601b0d94a2de"), new Guid("9366dfdf-965d-4b6f-872f-c9efce53fe0a"), new Guid("a332d831-d29f-4d11-ba6d-a45fd19b7f8a") },
                    { new Guid("2fd9184f-8a35-490a-8b60-1d06fd740c04"), new Guid("927e59a5-9638-4e28-b16e-41a829d7226d"), new Guid("78b624a4-9528-4c48-b6fd-29b7308ae44f") },
                    { new Guid("31291840-e01a-4177-b7c9-160152211dbb"), new Guid("e6a1186d-4bda-44b3-8c33-f633a99cf5e7"), new Guid("71949e9b-637a-438b-8694-d9e440ec5df3") },
                    { new Guid("34690086-3545-48bc-9d0f-d8be495389d0"), new Guid("a1bdaa2e-96a6-4fbb-ac8e-e8026a060467"), new Guid("81070cd0-8b4a-4300-bb57-655c4298460c") },
                    { new Guid("34c389b2-b584-4b56-8a7e-446ad533d6b0"), new Guid("fa31ccd2-97ac-473b-ad32-4580cb1200c1"), new Guid("ca979c56-0d86-44ec-9e66-9f1d1b2901cf") },
                    { new Guid("36842194-1280-4a43-9fd9-312e418882b9"), new Guid("1baee819-2ebb-4c48-9571-def68afbaae7"), new Guid("52223944-550b-4b2a-8153-7c52341506ae") },
                    { new Guid("36e65554-ba25-4928-9401-bec719787c39"), new Guid("34753a3f-73bc-4e30-9549-d743512a798e"), new Guid("83ccd7f1-1c9e-4d31-96c4-7c4fd5b66b04") },
                    { new Guid("36ef7a52-a431-48b0-b0f4-f6709bd64204"), new Guid("c7811669-b5dc-4d8e-9899-44a8357e3b47"), new Guid("a332d831-d29f-4d11-ba6d-a45fd19b7f8a") },
                    { new Guid("36f48bd7-9da4-466a-ad0f-8990fc4f4aa0"), new Guid("bf17cca9-b5b8-45b5-94f1-830bbd62fbbc"), new Guid("92ca8c89-1934-4e91-b501-7ba45719a744") },
                    { new Guid("37f53d37-23db-4062-85b3-bd3ca24f1626"), new Guid("f1406458-eb5b-4b12-9a3a-44e0af77fefb"), new Guid("81070cd0-8b4a-4300-bb57-655c4298460c") },
                    { new Guid("385d5d0c-a316-4a9f-bfa8-77a04b1c7b82"), new Guid("9366dfdf-965d-4b6f-872f-c9efce53fe0a"), new Guid("81070cd0-8b4a-4300-bb57-655c4298460c") },
                    { new Guid("3d7ed3ab-df3c-45d2-9a22-6267f24ab792"), new Guid("6825b413-3463-4c74-8662-ef72368ef8f6"), new Guid("1b9c8d1a-1dcb-4651-96b9-a28206738e0c") },
                    { new Guid("400ffc0d-57f8-40d5-83fb-2ca73dbefc2d"), new Guid("3c70b30b-cfb0-4c9f-8630-7c350801283e"), new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024") },
                    { new Guid("40365af9-4992-4ae5-8ca5-d403ec852088"), new Guid("d7bf55ba-f054-4f28-80b7-9ab67de6e124"), new Guid("8a60b900-510a-489f-af33-6ca3e36003ce") },
                    { new Guid("4078db80-4cef-452d-91e9-f3fbdc8eba70"), new Guid("6fe52d0d-a4dd-45e2-86f3-6d3491e41546"), new Guid("83ccd7f1-1c9e-4d31-96c4-7c4fd5b66b04") },
                    { new Guid("41ce8b61-a559-4bf3-ad61-9f90232ca1da"), new Guid("883c758e-8408-4cb5-ad66-acea4b7e1628"), new Guid("ca979c56-0d86-44ec-9e66-9f1d1b2901cf") },
                    { new Guid("41d949b0-8d94-43e2-91d5-52d126df1fb4"), new Guid("6b9dda79-08fb-4990-b286-abd276e3742f"), new Guid("a332d831-d29f-4d11-ba6d-a45fd19b7f8a") },
                    { new Guid("42338ea3-a3ba-4399-9830-166356c75513"), new Guid("b7d32ace-fa4e-4be4-92aa-459c443db207"), new Guid("351cdd42-dec1-40ff-9fa5-02bcf0093f48") },
                    { new Guid("4248f4ec-24af-4f2f-b0dc-624700ab0078"), new Guid("1baee819-2ebb-4c48-9571-def68afbaae7"), new Guid("351cdd42-dec1-40ff-9fa5-02bcf0093f48") },
                    { new Guid("427c7be8-2537-492f-b2db-aab42ef3d734"), new Guid("3b1fa282-6d4e-492e-82aa-6ffdb000e4c4"), new Guid("81070cd0-8b4a-4300-bb57-655c4298460c") },
                    { new Guid("43254a85-0e27-4acd-a8d0-9d8218a8c96a"), new Guid("30bc9e9b-3d76-46e1-b591-f2f8df5754b3"), new Guid("351cdd42-dec1-40ff-9fa5-02bcf0093f48") },
                    { new Guid("434e59bd-0e51-4d43-9ca6-7fff3ba886e7"), new Guid("4755b654-c427-4096-9e42-1345cc9ebb23"), new Guid("0ae3667d-8f40-412e-82b3-aae6cf496440") },
                    { new Guid("4454ef74-559a-441a-a61b-aaa191f306c8"), new Guid("c93356e0-c5df-4012-b02b-63bc4f96db8c"), new Guid("78b624a4-9528-4c48-b6fd-29b7308ae44f") },
                    { new Guid("445901d3-1cb8-472e-ab96-52322bd1d4b8"), new Guid("3c70b30b-cfb0-4c9f-8630-7c350801283e"), new Guid("81070cd0-8b4a-4300-bb57-655c4298460c") },
                    { new Guid("44c2e77a-cf5d-48f7-8818-e6f91621f65b"), new Guid("f4e64e7d-896d-40d9-bf35-eb24540d49a7"), new Guid("52223944-550b-4b2a-8153-7c52341506ae") },
                    { new Guid("46d1718d-d4c4-4acb-9c0b-7fc73fda82ba"), new Guid("9c03735f-f0d9-46d7-ad19-0e5591ec9c71"), new Guid("ec0827e0-83c5-4d96-b445-30bfb4eff9e0") },
                    { new Guid("4710bf9f-f3b2-4d7f-9023-f4bee69afdb4"), new Guid("dd2a356c-ec21-4362-9ce8-48b2635be906"), new Guid("92ca8c89-1934-4e91-b501-7ba45719a744") },
                    { new Guid("473797be-81bb-452c-85e0-8629c056a61b"), new Guid("a14e2275-e4eb-4d48-98df-dbffc119b755"), new Guid("d2d2e4da-7eae-4f44-8078-594e60f967e1") },
                    { new Guid("495827f4-654b-4011-8676-26ed8c7617f0"), new Guid("30bc9e9b-3d76-46e1-b591-f2f8df5754b3"), new Guid("ca979c56-0d86-44ec-9e66-9f1d1b2901cf") },
                    { new Guid("4a42228c-d07b-4bab-b4b2-1e02c973b188"), new Guid("340926b7-72f7-47b7-8bd4-62f3b75dcaa5"), new Guid("52223944-550b-4b2a-8153-7c52341506ae") },
                    { new Guid("4bc01906-cab0-4f87-89d9-a656e6bc2253"), new Guid("14315ec2-4158-48cf-ba1c-a61d9b88d74e"), new Guid("ca979c56-0d86-44ec-9e66-9f1d1b2901cf") },
                    { new Guid("4c175d4b-8d1a-4b86-b098-9844a4ca611c"), new Guid("74640b5e-89a1-4dfa-883c-d63f71201420"), new Guid("83ccd7f1-1c9e-4d31-96c4-7c4fd5b66b04") },
                    { new Guid("4cd37d5f-6476-400a-8b73-0eaf581e740e"), new Guid("74640b5e-89a1-4dfa-883c-d63f71201420"), new Guid("ca979c56-0d86-44ec-9e66-9f1d1b2901cf") },
                    { new Guid("4dd8f745-b128-4646-9991-3109b02c1e5d"), new Guid("37ad2dc3-3edf-4de9-a10c-c2617e9f16c3"), new Guid("92ca8c89-1934-4e91-b501-7ba45719a744") },
                    { new Guid("4de146f4-670d-4691-b50f-1b1bea93e29b"), new Guid("6825b413-3463-4c74-8662-ef72368ef8f6"), new Guid("af8c05c2-4018-4859-af40-d1380e520f8d") },
                    { new Guid("4e4f7a91-6152-491f-b876-49e3a57e631c"), new Guid("c7811669-b5dc-4d8e-9899-44a8357e3b47"), new Guid("83ccd7f1-1c9e-4d31-96c4-7c4fd5b66b04") },
                    { new Guid("4e59774a-12e6-4f26-a0a6-e0b05c33d5b8"), new Guid("3824cdba-52fe-486f-95f5-f1e6a82b6c3b"), new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024") },
                    { new Guid("4ede06ce-2a8b-4c4c-9798-c9aae6d465eb"), new Guid("dc7161a5-2823-4ba1-9b5f-cf2eb5b7671c"), new Guid("a6e7cba0-c2e2-4989-beb1-b9109543bdfe") },
                    { new Guid("4f7a015a-de14-46a9-9699-ef46c19a5a6d"), new Guid("37ad2dc3-3edf-4de9-a10c-c2617e9f16c3"), new Guid("a332d831-d29f-4d11-ba6d-a45fd19b7f8a") },
                    { new Guid("4fc07f7a-708d-4e33-ae19-a2592c24c93b"), new Guid("2f1266da-9bb2-47ef-b7e4-60c30403424b"), new Guid("a332d831-d29f-4d11-ba6d-a45fd19b7f8a") },
                    { new Guid("4fd1c1b6-e41e-4843-a7d1-b2817786aca5"), new Guid("9f52579f-62e8-4253-9421-9e0d5529f485"), new Guid("a332d831-d29f-4d11-ba6d-a45fd19b7f8a") },
                    { new Guid("502d6667-f6cb-4c38-906d-3a0b63a3c332"), new Guid("dd2a356c-ec21-4362-9ce8-48b2635be906"), new Guid("351cdd42-dec1-40ff-9fa5-02bcf0093f48") },
                    { new Guid("505a560d-1265-453f-a3d4-26546b2e6120"), new Guid("8a7a35fd-ac06-455d-afb6-eb5bfff1eb87"), new Guid("78b624a4-9528-4c48-b6fd-29b7308ae44f") },
                    { new Guid("505c3c98-27f2-45b8-b209-a040e4cc6a74"), new Guid("9ba3565e-2756-444f-bdb5-9468d4fd9dd8"), new Guid("a332d831-d29f-4d11-ba6d-a45fd19b7f8a") },
                    { new Guid("50dbfedc-a23a-4910-8b09-d88b6a606657"), new Guid("1e64c681-4c58-486d-91d4-34130ae1ca9d"), new Guid("81070cd0-8b4a-4300-bb57-655c4298460c") },
                    { new Guid("523c9f22-cac9-4d8c-93cb-55474ccb8b5c"), new Guid("6fe52d0d-a4dd-45e2-86f3-6d3491e41546"), new Guid("351cdd42-dec1-40ff-9fa5-02bcf0093f48") },
                    { new Guid("523f001a-dacd-4406-9e95-43311165df8b"), new Guid("7f1064dd-a82f-453c-9367-3fb1f9444a60"), new Guid("81070cd0-8b4a-4300-bb57-655c4298460c") },
                    { new Guid("52aa61ab-d488-4c03-bf51-57e0bdb6158d"), new Guid("1b730010-57dc-40f8-b6f6-9eaa18ce3d2b"), new Guid("ca979c56-0d86-44ec-9e66-9f1d1b2901cf") },
                    { new Guid("537812c1-6dbd-4469-9cbe-03a3c9adc611"), new Guid("6825b413-3463-4c74-8662-ef72368ef8f6"), new Guid("ca979c56-0d86-44ec-9e66-9f1d1b2901cf") },
                    { new Guid("53e61d41-7f0a-4f31-92c8-872268b6de50"), new Guid("a1bdaa2e-96a6-4fbb-ac8e-e8026a060467"), new Guid("20a451ec-b864-4e51-b4b1-8bb720f5fd9f") },
                    { new Guid("54982699-fb73-4c5c-8aee-f6c8010c8130"), new Guid("96f53566-5908-405f-a256-422d6bb50a23"), new Guid("83ccd7f1-1c9e-4d31-96c4-7c4fd5b66b04") },
                    { new Guid("555fcafc-d50e-4ab3-8366-43ce56273e76"), new Guid("6d34ef94-4aa9-49bf-8751-6f91df5d192a"), new Guid("8a60b900-510a-489f-af33-6ca3e36003ce") },
                    { new Guid("55db20ab-1210-44ef-bcdc-beaccc89d163"), new Guid("1baee819-2ebb-4c48-9571-def68afbaae7"), new Guid("a332d831-d29f-4d11-ba6d-a45fd19b7f8a") },
                    { new Guid("576df029-a6f1-4915-8d06-792a5952784f"), new Guid("42aa226a-7ab8-4984-a2e7-f05ee1263d5f"), new Guid("af8c05c2-4018-4859-af40-d1380e520f8d") },
                    { new Guid("58e5dd4c-f7f3-4545-98c4-0516e47924c9"), new Guid("e678a76b-2b2e-4df0-8507-f442a94e8628"), new Guid("71949e9b-637a-438b-8694-d9e440ec5df3") },
                    { new Guid("5a8ceaa1-62cf-4c2a-80c7-279ccab74ba2"), new Guid("a1bdaa2e-96a6-4fbb-ac8e-e8026a060467"), new Guid("92ca8c89-1934-4e91-b501-7ba45719a744") },
                    { new Guid("5b3f465b-f003-4b75-a728-7fe2446d32a0"), new Guid("28918e3a-a7a7-46b1-b997-bb4abc377ef5"), new Guid("351cdd42-dec1-40ff-9fa5-02bcf0093f48") },
                    { new Guid("5bf044dd-9e74-4806-a1b7-2df4ed687a68"), new Guid("4de49bf7-8e49-4816-8aed-2053c0bb33df"), new Guid("20a451ec-b864-4e51-b4b1-8bb720f5fd9f") },
                    { new Guid("5eed6e99-d3d4-4a48-ad02-edf6f2788f78"), new Guid("c45e5201-fce3-4da1-97c1-638f6fa06537"), new Guid("ec0827e0-83c5-4d96-b445-30bfb4eff9e0") },
                    { new Guid("5fb6960b-cf1c-4832-8a17-24021802777a"), new Guid("981e76d6-32da-4c0f-bd8b-21bb8cc5cd0b"), new Guid("71949e9b-637a-438b-8694-d9e440ec5df3") },
                    { new Guid("6031ae92-d87a-401b-b91d-ba3734084f16"), new Guid("883c758e-8408-4cb5-ad66-acea4b7e1628"), new Guid("ca979c56-0d86-44ec-9e66-9f1d1b2901cf") },
                    { new Guid("6064b9ab-37c6-4e82-94cc-b7e56cd47fd7"), new Guid("d2d35f35-1cc4-4617-855c-c79d4217d573"), new Guid("ca979c56-0d86-44ec-9e66-9f1d1b2901cf") },
                    { new Guid("6137f143-fb4a-412b-8721-522fc63501bb"), new Guid("2873d706-906f-4404-9e02-e06f9d3ddf1e"), new Guid("83ccd7f1-1c9e-4d31-96c4-7c4fd5b66b04") },
                    { new Guid("624c4fac-ec78-4367-b923-e47ca524c26a"), new Guid("4a83a64a-0bab-4f6c-be30-6cc980104bc8"), new Guid("8a60b900-510a-489f-af33-6ca3e36003ce") },
                    { new Guid("63634aa0-0d23-413a-a7fe-a2a8a0d90660"), new Guid("dd2a356c-ec21-4362-9ce8-48b2635be906"), new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024") },
                    { new Guid("64207bf8-b609-4c61-b9fb-5c8bdaea5c20"), new Guid("2f1266da-9bb2-47ef-b7e4-60c30403424b"), new Guid("78b624a4-9528-4c48-b6fd-29b7308ae44f") },
                    { new Guid("64472576-9819-473b-85f7-6022567f7c25"), new Guid("dd41a399-bb80-46ff-97a5-8405a9b69101"), new Guid("1b9c8d1a-1dcb-4651-96b9-a28206738e0c") },
                    { new Guid("646a5bba-ea47-41c8-b25d-f6984ab82908"), new Guid("c7747564-15f5-4833-bf7f-088ec520f58d"), new Guid("83ccd7f1-1c9e-4d31-96c4-7c4fd5b66b04") },
                    { new Guid("65525ce3-d941-4a18-93a6-b712268de186"), new Guid("8a7a35fd-ac06-455d-afb6-eb5bfff1eb87"), new Guid("a332d831-d29f-4d11-ba6d-a45fd19b7f8a") },
                    { new Guid("664a6449-b3e9-46cc-8df1-82a782327c16"), new Guid("c5576d2b-d5b2-43cc-9fd9-5c16b3c89ce4"), new Guid("0ae3667d-8f40-412e-82b3-aae6cf496440") },
                    { new Guid("66c23bdb-8f97-4348-8849-41bd75d90bce"), new Guid("c45e5201-fce3-4da1-97c1-638f6fa06537"), new Guid("1b9c8d1a-1dcb-4651-96b9-a28206738e0c") },
                    { new Guid("69efd6bb-b04d-43dc-9d8b-b883f39a59bf"), new Guid("ea9e33a2-6423-40c7-8458-f231e241a48d"), new Guid("d2d2e4da-7eae-4f44-8078-594e60f967e1") },
                    { new Guid("69f89e99-e40b-4da2-a31b-710b8b04dda4"), new Guid("d2d6e165-cfa6-42ce-a987-11db81476696"), new Guid("78b624a4-9528-4c48-b6fd-29b7308ae44f") },
                    { new Guid("6ba57c42-d572-4caf-ad8c-80ab3b1efb1f"), new Guid("325e6ff8-e3dc-4b6a-865d-91e151fd71b2"), new Guid("92ca8c89-1934-4e91-b501-7ba45719a744") },
                    { new Guid("6bcd0a5f-7c7c-40fb-9065-87f6cd83a6cb"), new Guid("6477dd91-70bb-4b9c-9082-7585d9cebef9"), new Guid("92ca8c89-1934-4e91-b501-7ba45719a744") },
                    { new Guid("6c298e96-b378-4515-b6e0-e1b39ed6c2b6"), new Guid("c8078436-1ecf-496f-a86e-8fd1f391bc28"), new Guid("1b9c8d1a-1dcb-4651-96b9-a28206738e0c") },
                    { new Guid("6c63cf12-1a7c-421e-b9ca-dc12d43fcf88"), new Guid("a1e98442-2aa8-499c-8830-babfba1fcce3"), new Guid("81070cd0-8b4a-4300-bb57-655c4298460c") },
                    { new Guid("6cbb86b8-f0a0-4ba3-882a-38d2c69d25f1"), new Guid("3c70b30b-cfb0-4c9f-8630-7c350801283e"), new Guid("83ccd7f1-1c9e-4d31-96c4-7c4fd5b66b04") },
                    { new Guid("6e5fad25-7eef-4a1c-8f74-3d4836986baf"), new Guid("ad568c6d-ac6c-4484-a10f-60fbc3c2a9aa"), new Guid("a6e7cba0-c2e2-4989-beb1-b9109543bdfe") },
                    { new Guid("70b4ff58-bd05-4fdc-8b4d-e1e39d1b7385"), new Guid("355bf34d-704b-467c-99bb-6353cc513b97"), new Guid("ec0827e0-83c5-4d96-b445-30bfb4eff9e0") },
                    { new Guid("7122fb9c-9beb-4cd8-aa39-7d49e7992774"), new Guid("332ad470-6a1d-4935-9d12-9fad8e1386a2"), new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024") },
                    { new Guid("71314c32-c4f8-4a5b-8371-78863a12e401"), new Guid("ea9e33a2-6423-40c7-8458-f231e241a48d"), new Guid("1b9c8d1a-1dcb-4651-96b9-a28206738e0c") },
                    { new Guid("733995c9-a71b-4d92-8fc6-48f7333e4033"), new Guid("7e071e9d-a0e9-4a0d-bbf4-360a332dc5c1"), new Guid("20a451ec-b864-4e51-b4b1-8bb720f5fd9f") },
                    { new Guid("74789d9b-ebb0-4ea9-92a9-7a51e41506d6"), new Guid("c45e5201-fce3-4da1-97c1-638f6fa06537"), new Guid("351cdd42-dec1-40ff-9fa5-02bcf0093f48") },
                    { new Guid("755a5fd9-0a2b-424d-9eac-a0d2c9ba79ca"), new Guid("00d77d77-a4d8-4990-9bb0-d6481338cb39"), new Guid("52223944-550b-4b2a-8153-7c52341506ae") },
                    { new Guid("76277e44-baa6-4e41-b22b-44f9f5f6c698"), new Guid("fdd870dd-a2b8-4e4b-b1aa-9f2650ff8a93"), new Guid("52223944-550b-4b2a-8153-7c52341506ae") },
                    { new Guid("77a48fcb-2efe-48f6-b7d4-c9cc2a8c8feb"), new Guid("71f0812b-c6f1-4c11-bd62-d7fb683f2be2"), new Guid("af8c05c2-4018-4859-af40-d1380e520f8d") },
                    { new Guid("77e8a31a-1e50-4570-b7a2-716824f060a7"), new Guid("5b7cda18-7ea3-4504-a0fb-6da861aaf676"), new Guid("83ccd7f1-1c9e-4d31-96c4-7c4fd5b66b04") },
                    { new Guid("78494ca8-cd36-4e79-a37f-4fff3540c882"), new Guid("ea9e33a2-6423-40c7-8458-f231e241a48d"), new Guid("78b624a4-9528-4c48-b6fd-29b7308ae44f") },
                    { new Guid("7894e087-2f93-4339-89a4-bbb7f12c8b9a"), new Guid("4ec0ed94-e432-474e-b2ad-7b79b0397575"), new Guid("92ca8c89-1934-4e91-b501-7ba45719a744") },
                    { new Guid("7ac25c58-4df4-432b-b615-d6f7c4ce0201"), new Guid("d2d35f35-1cc4-4617-855c-c79d4217d573"), new Guid("78b624a4-9528-4c48-b6fd-29b7308ae44f") },
                    { new Guid("7b8e4d35-8ee1-4d83-abef-b8f473d40a35"), new Guid("a1e98442-2aa8-499c-8830-babfba1fcce3"), new Guid("a332d831-d29f-4d11-ba6d-a45fd19b7f8a") },
                    { new Guid("7ce49d25-d804-4431-a461-c0a9d5243ad9"), new Guid("cf16cea8-228e-46ce-832a-c081596b9c1c"), new Guid("78b624a4-9528-4c48-b6fd-29b7308ae44f") },
                    { new Guid("7d1a35fe-ab34-4d15-9ee5-d357bc3f371c"), new Guid("7f1064dd-a82f-453c-9367-3fb1f9444a60"), new Guid("83ccd7f1-1c9e-4d31-96c4-7c4fd5b66b04") },
                    { new Guid("7d751c6e-b999-4c09-8db3-56c3f1db5ea8"), new Guid("340926b7-72f7-47b7-8bd4-62f3b75dcaa5"), new Guid("ec0827e0-83c5-4d96-b445-30bfb4eff9e0") },
                    { new Guid("83c2c68d-488c-40d2-b870-f24ebc8d1002"), new Guid("9b9b8fcf-6680-46c9-bdd5-6f55ff1ed1c4"), new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024") },
                    { new Guid("844dba1f-2d10-42e9-bd08-9e56e3ca5f7f"), new Guid("49ed827a-830e-4c0a-95ad-77991a0f9e58"), new Guid("8a60b900-510a-489f-af33-6ca3e36003ce") },
                    { new Guid("84884831-35c7-4537-92bc-a3270c9b2258"), new Guid("6d34ef94-4aa9-49bf-8751-6f91df5d192a"), new Guid("20a451ec-b864-4e51-b4b1-8bb720f5fd9f") },
                    { new Guid("84ff9761-80ce-43f9-a9ea-a8b1a8edfe36"), new Guid("cf16cea8-228e-46ce-832a-c081596b9c1c"), new Guid("92ca8c89-1934-4e91-b501-7ba45719a744") },
                    { new Guid("85047a13-3906-4631-a099-9242fba2bf8c"), new Guid("9ba3565e-2756-444f-bdb5-9468d4fd9dd8"), new Guid("20a451ec-b864-4e51-b4b1-8bb720f5fd9f") },
                    { new Guid("85379e47-f68e-41bc-af3f-052fc2ccb85c"), new Guid("34753a3f-73bc-4e30-9549-d743512a798e"), new Guid("71949e9b-637a-438b-8694-d9e440ec5df3") },
                    { new Guid("858e3998-9661-4cbc-8801-9ba21a40a3e5"), new Guid("332ad470-6a1d-4935-9d12-9fad8e1386a2"), new Guid("af8c05c2-4018-4859-af40-d1380e520f8d") },
                    { new Guid("86e4aa20-8703-498a-a0b5-e0d483ae3017"), new Guid("87b72fdf-0162-4e82-ba5f-b1b44e69d923"), new Guid("71949e9b-637a-438b-8694-d9e440ec5df3") },
                    { new Guid("87bb855a-fa61-493c-b381-0b534b8f16d2"), new Guid("d2d35f35-1cc4-4617-855c-c79d4217d573"), new Guid("351cdd42-dec1-40ff-9fa5-02bcf0093f48") },
                    { new Guid("88077948-42d4-4f79-a01a-fac87cbe4f7e"), new Guid("37ad2dc3-3edf-4de9-a10c-c2617e9f16c3"), new Guid("52223944-550b-4b2a-8153-7c52341506ae") },
                    { new Guid("88e729fa-e6a6-4b76-bdc1-1f9203ed7eed"), new Guid("332ad470-6a1d-4935-9d12-9fad8e1386a2"), new Guid("a332d831-d29f-4d11-ba6d-a45fd19b7f8a") },
                    { new Guid("89f308ea-cb6a-44d1-9203-58e1358d96bc"), new Guid("8a7a35fd-ac06-455d-afb6-eb5bfff1eb87"), new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024") },
                    { new Guid("8b31c1e8-25c6-43f5-8676-673ea82739db"), new Guid("87b72fdf-0162-4e82-ba5f-b1b44e69d923"), new Guid("0ae3667d-8f40-412e-82b3-aae6cf496440") },
                    { new Guid("8b73b155-8108-4078-83e8-675d1cc52afd"), new Guid("e7ce2366-c49c-43d2-bd1a-bc51d06e07c2"), new Guid("52223944-550b-4b2a-8153-7c52341506ae") },
                    { new Guid("8c1467ce-c278-46cc-895c-d7b95f125ac0"), new Guid("839aeecb-f79c-4e55-9cad-2ccf309fd504"), new Guid("52223944-550b-4b2a-8153-7c52341506ae") },
                    { new Guid("8c5e7966-e79e-4614-a702-aef6725a0004"), new Guid("2f1266da-9bb2-47ef-b7e4-60c30403424b"), new Guid("a6e7cba0-c2e2-4989-beb1-b9109543bdfe") },
                    { new Guid("8ccbe034-605e-4215-ad7d-a4e8a08e0a66"), new Guid("ea060651-82ad-44ad-a416-d182a93cd7d7"), new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024") },
                    { new Guid("8d1ea971-8a48-48e9-a548-41a34b7ba2c8"), new Guid("c5576d2b-d5b2-43cc-9fd9-5c16b3c89ce4"), new Guid("ca979c56-0d86-44ec-9e66-9f1d1b2901cf") },
                    { new Guid("8dad107b-ead5-40c7-a0e9-c6aca6090763"), new Guid("4a83a64a-0bab-4f6c-be30-6cc980104bc8"), new Guid("0ae3667d-8f40-412e-82b3-aae6cf496440") },
                    { new Guid("8e98d1ed-e7ab-461f-8d88-ffad469a1d1c"), new Guid("4755b654-c427-4096-9e42-1345cc9ebb23"), new Guid("0ae3667d-8f40-412e-82b3-aae6cf496440") },
                    { new Guid("8e9c4ff9-7c57-44cb-91f5-947e2b8ed685"), new Guid("d2d6e165-cfa6-42ce-a987-11db81476696"), new Guid("ec0827e0-83c5-4d96-b445-30bfb4eff9e0") },
                    { new Guid("8eb5ef5e-5a9c-4f67-99ce-968d47c9466f"), new Guid("ad568c6d-ac6c-4484-a10f-60fbc3c2a9aa"), new Guid("52223944-550b-4b2a-8153-7c52341506ae") },
                    { new Guid("8eedb2d7-037b-41d6-8e65-5d4da0cca97e"), new Guid("7f1064dd-a82f-453c-9367-3fb1f9444a60"), new Guid("52223944-550b-4b2a-8153-7c52341506ae") },
                    { new Guid("901a4e97-cbe7-47a9-bfd0-291ad9496cf4"), new Guid("a1e98442-2aa8-499c-8830-babfba1fcce3"), new Guid("ec0827e0-83c5-4d96-b445-30bfb4eff9e0") },
                    { new Guid("90e51043-e7f1-4b26-995c-abff08082c0d"), new Guid("12d13f50-09f0-4607-b210-36aab22eeff7"), new Guid("0ae3667d-8f40-412e-82b3-aae6cf496440") },
                    { new Guid("917a2389-6bef-4453-ad8f-e08cf46f3640"), new Guid("277434e2-f920-4b30-b27d-df630fc311cd"), new Guid("81070cd0-8b4a-4300-bb57-655c4298460c") },
                    { new Guid("9227e434-d91e-44bc-9e46-8a228a46f8f6"), new Guid("d7bf55ba-f054-4f28-80b7-9ab67de6e124"), new Guid("83ccd7f1-1c9e-4d31-96c4-7c4fd5b66b04") },
                    { new Guid("930973d0-3a48-4859-a17f-9d896a8ac374"), new Guid("c7747564-15f5-4833-bf7f-088ec520f58d"), new Guid("0ae3667d-8f40-412e-82b3-aae6cf496440") },
                    { new Guid("95f40b54-e900-4ee5-83c7-5d70437caeb3"), new Guid("d2d6e165-cfa6-42ce-a987-11db81476696"), new Guid("ec0827e0-83c5-4d96-b445-30bfb4eff9e0") },
                    { new Guid("95fb892c-45d8-4926-9c00-c01119d7bc43"), new Guid("58f3044a-729f-4f7d-96e7-25444c360b6d"), new Guid("351cdd42-dec1-40ff-9fa5-02bcf0093f48") },
                    { new Guid("96a1d604-13eb-449d-ab61-ae45b45df86a"), new Guid("ab936883-9909-4bca-a868-3f18040a470c"), new Guid("a332d831-d29f-4d11-ba6d-a45fd19b7f8a") },
                    { new Guid("99c11099-9a05-4519-b3a4-28be6786d7cc"), new Guid("ad568c6d-ac6c-4484-a10f-60fbc3c2a9aa"), new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024") },
                    { new Guid("99e838e6-d978-49fc-b162-3c3b5efac7b1"), new Guid("afed533d-905e-45d8-8d3f-d2957c6385e6"), new Guid("351cdd42-dec1-40ff-9fa5-02bcf0093f48") },
                    { new Guid("99f7a6f2-2117-4e2a-bcab-942fad42594c"), new Guid("5f478889-2e75-41b9-b838-a110d78cb1a2"), new Guid("a6e7cba0-c2e2-4989-beb1-b9109543bdfe") },
                    { new Guid("9a0418b1-a6b2-46da-94dd-653600a6b468"), new Guid("1b730010-57dc-40f8-b6f6-9eaa18ce3d2b"), new Guid("1b9c8d1a-1dcb-4651-96b9-a28206738e0c") },
                    { new Guid("9b54d2f7-eefc-47eb-80f8-059ca232717c"), new Guid("908226ec-d2a1-45d7-886b-b85550fde710"), new Guid("1199807b-46a7-4610-8df2-c7df16a2f8f8") },
                    { new Guid("9bfdb0b0-c07c-45bf-9cd3-589a1a9d8e56"), new Guid("4de49bf7-8e49-4816-8aed-2053c0bb33df"), new Guid("a6e7cba0-c2e2-4989-beb1-b9109543bdfe") },
                    { new Guid("9cfe2260-f9af-4d35-b7fe-e72fa818219e"), new Guid("3b1fa282-6d4e-492e-82aa-6ffdb000e4c4"), new Guid("1199807b-46a7-4610-8df2-c7df16a2f8f8") },
                    { new Guid("9d021ee2-d43a-4694-a61a-9a309c285bf4"), new Guid("c8078436-1ecf-496f-a86e-8fd1f391bc28"), new Guid("78b624a4-9528-4c48-b6fd-29b7308ae44f") },
                    { new Guid("9da5ae42-e7bb-4234-8956-ab053de47d9c"), new Guid("340926b7-72f7-47b7-8bd4-62f3b75dcaa5"), new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024") },
                    { new Guid("9e576cce-30a3-43bd-bc9e-cbef4f2e69c8"), new Guid("9c03735f-f0d9-46d7-ad19-0e5591ec9c71"), new Guid("8a60b900-510a-489f-af33-6ca3e36003ce") },
                    { new Guid("a0b94b4a-705e-463c-9b37-e6bdd434ebcc"), new Guid("4e285e9b-0294-4821-823a-c6709706d678"), new Guid("351cdd42-dec1-40ff-9fa5-02bcf0093f48") },
                    { new Guid("a0d2b3a7-886c-4209-8a1f-b286230c0a51"), new Guid("67fd082f-3f53-46b3-8af5-a6e8191a04a9"), new Guid("52223944-550b-4b2a-8153-7c52341506ae") },
                    { new Guid("a0fa08b7-3dc3-4cbd-9217-23fc716141ce"), new Guid("f42cd749-8586-436e-bc85-704764629fa9"), new Guid("ec0827e0-83c5-4d96-b445-30bfb4eff9e0") },
                    { new Guid("a0fc3ffa-351c-479d-90dc-d606311a861a"), new Guid("6b9dda79-08fb-4990-b286-abd276e3742f"), new Guid("0ae3667d-8f40-412e-82b3-aae6cf496440") },
                    { new Guid("a19d2730-6520-4b20-8030-e72d403497a1"), new Guid("86f61e72-7a14-4da5-aab6-2732bb04c9d7"), new Guid("1199807b-46a7-4610-8df2-c7df16a2f8f8") },
                    { new Guid("a29b0a71-d768-4449-bcc0-5a6e6182feb4"), new Guid("42aa226a-7ab8-4984-a2e7-f05ee1263d5f"), new Guid("a6e7cba0-c2e2-4989-beb1-b9109543bdfe") },
                    { new Guid("a2e1f357-a029-4434-8e1d-326f8fb30dda"), new Guid("49ed827a-830e-4c0a-95ad-77991a0f9e58"), new Guid("a6e7cba0-c2e2-4989-beb1-b9109543bdfe") },
                    { new Guid("a4ab3b85-7c0b-4d37-88bc-1452ed1db1e1"), new Guid("883c758e-8408-4cb5-ad66-acea4b7e1628"), new Guid("351cdd42-dec1-40ff-9fa5-02bcf0093f48") },
                    { new Guid("a89aa9fa-c672-40fa-b85f-cbdd90162182"), new Guid("05d9780d-2c4b-4846-8048-6c5afdeca6ac"), new Guid("0ae3667d-8f40-412e-82b3-aae6cf496440") },
                    { new Guid("a98bb563-7e06-4eed-b9f0-971fa553c593"), new Guid("9b9b8fcf-6680-46c9-bdd5-6f55ff1ed1c4"), new Guid("351cdd42-dec1-40ff-9fa5-02bcf0093f48") },
                    { new Guid("a99a92a0-b1c3-46f7-a863-58878ad368d5"), new Guid("58f3044a-729f-4f7d-96e7-25444c360b6d"), new Guid("ca979c56-0d86-44ec-9e66-9f1d1b2901cf") },
                    { new Guid("aa25fa02-0ee9-4c20-a0b2-fd71df01d223"), new Guid("5a61275f-6307-48f1-9214-7bb16a4effc8"), new Guid("92ca8c89-1934-4e91-b501-7ba45719a744") },
                    { new Guid("aa30af39-32ff-4769-a76a-c05277a52e66"), new Guid("ea060651-82ad-44ad-a416-d182a93cd7d7"), new Guid("1b9c8d1a-1dcb-4651-96b9-a28206738e0c") },
                    { new Guid("aaa1bbec-df58-48e0-926c-ab0ae537df62"), new Guid("c93356e0-c5df-4012-b02b-63bc4f96db8c"), new Guid("78b624a4-9528-4c48-b6fd-29b7308ae44f") },
                    { new Guid("ab8a439d-cafb-4ebc-bf06-edb3583ca494"), new Guid("4ec0ed94-e432-474e-b2ad-7b79b0397575"), new Guid("0ae3667d-8f40-412e-82b3-aae6cf496440") },
                    { new Guid("abe08150-457a-4a83-b476-f3d0158ad41e"), new Guid("355bf34d-704b-467c-99bb-6353cc513b97"), new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024") },
                    { new Guid("ac561fb4-4329-49b5-adde-1be2c52c7e20"), new Guid("71f0812b-c6f1-4c11-bd62-d7fb683f2be2"), new Guid("81070cd0-8b4a-4300-bb57-655c4298460c") },
                    { new Guid("acc65b0d-3ca4-4c3d-84dd-930356ab0676"), new Guid("22e84bce-a188-46bb-9d13-420b5057bdfe"), new Guid("1199807b-46a7-4610-8df2-c7df16a2f8f8") },
                    { new Guid("ad55cd19-da6c-4ecd-936b-904caa1d77f7"), new Guid("67fd082f-3f53-46b3-8af5-a6e8191a04a9"), new Guid("1199807b-46a7-4610-8df2-c7df16a2f8f8") },
                    { new Guid("ae161e4d-4f89-44c1-9fd0-da3a6abb64eb"), new Guid("6b3d7881-1d5d-4625-b2bc-8c18f6a9f57b"), new Guid("d2d2e4da-7eae-4f44-8078-594e60f967e1") },
                    { new Guid("ae423baf-daf5-416f-a93f-4a5597057e30"), new Guid("e7ce2366-c49c-43d2-bd1a-bc51d06e07c2"), new Guid("a6e7cba0-c2e2-4989-beb1-b9109543bdfe") },
                    { new Guid("ae8ad6ae-467d-46d2-81ea-0c3fc73cb001"), new Guid("dd41a399-bb80-46ff-97a5-8405a9b69101"), new Guid("d2d2e4da-7eae-4f44-8078-594e60f967e1") },
                    { new Guid("affcc611-cc65-48f5-b70c-6dd7092c4c4a"), new Guid("908226ec-d2a1-45d7-886b-b85550fde710"), new Guid("ec0827e0-83c5-4d96-b445-30bfb4eff9e0") },
                    { new Guid("b0e49ba0-4449-460f-935e-1d486564089f"), new Guid("12d13f50-09f0-4607-b210-36aab22eeff7"), new Guid("d2d2e4da-7eae-4f44-8078-594e60f967e1") },
                    { new Guid("b10da139-8e03-4d9e-a142-7b84fd3b3c29"), new Guid("96f53566-5908-405f-a256-422d6bb50a23"), new Guid("71949e9b-637a-438b-8694-d9e440ec5df3") },
                    { new Guid("b2917940-215b-4c9e-b153-a08cba98f800"), new Guid("1e64c681-4c58-486d-91d4-34130ae1ca9d"), new Guid("52223944-550b-4b2a-8153-7c52341506ae") },
                    { new Guid("b2cfcb9e-1941-439b-832d-a04ff5a7835d"), new Guid("c186d1d2-24a2-494f-a813-a418dcfa0895"), new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024") },
                    { new Guid("b3e88ceb-0263-477f-9054-37e77f9d2d4c"), new Guid("86f61e72-7a14-4da5-aab6-2732bb04c9d7"), new Guid("1b9c8d1a-1dcb-4651-96b9-a28206738e0c") },
                    { new Guid("b3ee3243-5f76-48d1-ab70-cd949efbbe2c"), new Guid("7e071e9d-a0e9-4a0d-bbf4-360a332dc5c1"), new Guid("a332d831-d29f-4d11-ba6d-a45fd19b7f8a") },
                    { new Guid("b505d3f1-cb02-4af7-bd7e-ccb06edbccd8"), new Guid("19290742-adb0-4a90-a40a-d3dcecd7722f"), new Guid("1b9c8d1a-1dcb-4651-96b9-a28206738e0c") },
                    { new Guid("b5224117-21fe-40a1-9227-919184aedb29"), new Guid("22e84bce-a188-46bb-9d13-420b5057bdfe"), new Guid("af8c05c2-4018-4859-af40-d1380e520f8d") },
                    { new Guid("b6be732e-96ab-4656-8f2e-a8bcf0c4327a"), new Guid("cf16cea8-228e-46ce-832a-c081596b9c1c"), new Guid("83ccd7f1-1c9e-4d31-96c4-7c4fd5b66b04") },
                    { new Guid("b75a844e-ef34-40a7-9a10-93295a89de7b"), new Guid("4c288215-ecd1-4ecf-937d-4910c61641cb"), new Guid("83ccd7f1-1c9e-4d31-96c4-7c4fd5b66b04") },
                    { new Guid("b763c7d7-421e-4365-b727-6b641ddd6426"), new Guid("927e59a5-9638-4e28-b16e-41a829d7226d"), new Guid("71949e9b-637a-438b-8694-d9e440ec5df3") },
                    { new Guid("b838dbd1-0465-4541-8ac4-9ed6b19f3bcd"), new Guid("19290742-adb0-4a90-a40a-d3dcecd7722f"), new Guid("0ae3667d-8f40-412e-82b3-aae6cf496440") },
                    { new Guid("b9469e87-b1d3-4eb8-a34f-192a503e6a47"), new Guid("00d77d77-a4d8-4990-9bb0-d6481338cb39"), new Guid("ca979c56-0d86-44ec-9e66-9f1d1b2901cf") },
                    { new Guid("b957393d-dff2-44aa-8c9f-cafec3fc48f0"), new Guid("00d77d77-a4d8-4990-9bb0-d6481338cb39"), new Guid("20a451ec-b864-4e51-b4b1-8bb720f5fd9f") },
                    { new Guid("b95f40ca-6ac8-4faa-a2f3-0ff88ddc2ce4"), new Guid("05d9780d-2c4b-4846-8048-6c5afdeca6ac"), new Guid("d2d2e4da-7eae-4f44-8078-594e60f967e1") },
                    { new Guid("b96a134e-854f-4982-ae5b-d348785287ef"), new Guid("fa31ccd2-97ac-473b-ad32-4580cb1200c1"), new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024") },
                    { new Guid("bb6dd2c0-79ff-4eb2-a306-7ef3c45aed59"), new Guid("1388efbe-339a-4228-a1ba-7934614223ef"), new Guid("1b9c8d1a-1dcb-4651-96b9-a28206738e0c") },
                    { new Guid("bbe6a6ca-6ee8-4edd-be4d-8063806d4477"), new Guid("4e285e9b-0294-4821-823a-c6709706d678"), new Guid("71949e9b-637a-438b-8694-d9e440ec5df3") },
                    { new Guid("bd6b7483-6d65-43e8-9293-ca66e7f94269"), new Guid("14315ec2-4158-48cf-ba1c-a61d9b88d74e"), new Guid("d2d2e4da-7eae-4f44-8078-594e60f967e1") },
                    { new Guid("be8ad6b6-9b39-4176-8005-20ffbbbd1bca"), new Guid("f1406458-eb5b-4b12-9a3a-44e0af77fefb"), new Guid("ca979c56-0d86-44ec-9e66-9f1d1b2901cf") },
                    { new Guid("be9aed93-9454-409f-94a1-b20e45a79d7c"), new Guid("c186d1d2-24a2-494f-a813-a418dcfa0895"), new Guid("8a60b900-510a-489f-af33-6ca3e36003ce") },
                    { new Guid("bf198612-b250-4777-86b6-679fe9f1ed17"), new Guid("e5042e97-8606-45fd-9ded-4cc0bd8e2890"), new Guid("8a60b900-510a-489f-af33-6ca3e36003ce") },
                    { new Guid("c017227a-05bb-441f-9244-5371ba27fcf2"), new Guid("b7d32ace-fa4e-4be4-92aa-459c443db207"), new Guid("a332d831-d29f-4d11-ba6d-a45fd19b7f8a") },
                    { new Guid("c26bf50c-51d7-4c75-be4a-1390146b8dfb"), new Guid("49ed827a-830e-4c0a-95ad-77991a0f9e58"), new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024") },
                    { new Guid("c3172d70-157f-4217-a89b-ddc4e2694da2"), new Guid("6d34ef94-4aa9-49bf-8751-6f91df5d192a"), new Guid("ec0827e0-83c5-4d96-b445-30bfb4eff9e0") },
                    { new Guid("c354ea37-d7d8-473f-b5aa-e7d28c0b84a2"), new Guid("fdd870dd-a2b8-4e4b-b1aa-9f2650ff8a93"), new Guid("1b9c8d1a-1dcb-4651-96b9-a28206738e0c") },
                    { new Guid("c48a4343-7f64-4b78-8a15-7b652468faef"), new Guid("e6a1186d-4bda-44b3-8c33-f633a99cf5e7"), new Guid("a332d831-d29f-4d11-ba6d-a45fd19b7f8a") },
                    { new Guid("c4c88e91-8c7b-4e63-abfb-590b853405e5"), new Guid("6477dd91-70bb-4b9c-9082-7585d9cebef9"), new Guid("a332d831-d29f-4d11-ba6d-a45fd19b7f8a") },
                    { new Guid("c5c59e3f-a20d-4483-b6d8-f6d334d4a05b"), new Guid("6fe52d0d-a4dd-45e2-86f3-6d3491e41546"), new Guid("8a60b900-510a-489f-af33-6ca3e36003ce") },
                    { new Guid("c62fbaba-fdec-44e9-a50e-5215796465d1"), new Guid("1b730010-57dc-40f8-b6f6-9eaa18ce3d2b"), new Guid("a6e7cba0-c2e2-4989-beb1-b9109543bdfe") },
                    { new Guid("c70e103c-b2b7-4761-9322-f9e803c79586"), new Guid("908226ec-d2a1-45d7-886b-b85550fde710"), new Guid("d2d2e4da-7eae-4f44-8078-594e60f967e1") },
                    { new Guid("c7e4030d-db23-48e9-aa8b-63fbca354439"), new Guid("5a61275f-6307-48f1-9214-7bb16a4effc8"), new Guid("a332d831-d29f-4d11-ba6d-a45fd19b7f8a") },
                    { new Guid("c84ca1b0-e49e-4c26-ad6c-06b0aecc8633"), new Guid("b7d32ace-fa4e-4be4-92aa-459c443db207"), new Guid("78b624a4-9528-4c48-b6fd-29b7308ae44f") },
                    { new Guid("cb88db77-d843-4954-9e5e-6846c0882ca2"), new Guid("5b7cda18-7ea3-4504-a0fb-6da861aaf676"), new Guid("81070cd0-8b4a-4300-bb57-655c4298460c") },
                    { new Guid("cd9ff119-f4ed-4cc0-85e9-2974d8836a8e"), new Guid("9b9b8fcf-6680-46c9-bdd5-6f55ff1ed1c4"), new Guid("0ae3667d-8f40-412e-82b3-aae6cf496440") },
                    { new Guid("ce47a9fd-5220-4e41-b88d-c0309f706d3d"), new Guid("7b05d27a-6567-4ee9-9f58-134bae6cdd1a"), new Guid("a332d831-d29f-4d11-ba6d-a45fd19b7f8a") },
                    { new Guid("ce9db49e-23c2-478a-8620-9e6c801ed82c"), new Guid("4e285e9b-0294-4821-823a-c6709706d678"), new Guid("83ccd7f1-1c9e-4d31-96c4-7c4fd5b66b04") },
                    { new Guid("d063fa5b-d233-40f7-9fed-ddfe4eeb3a0d"), new Guid("4c288215-ecd1-4ecf-937d-4910c61641cb"), new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024") },
                    { new Guid("d07d73b0-a752-4b84-a243-9e7be25b83c3"), new Guid("07f6069e-6fd6-4459-b912-af05eb4949b6"), new Guid("ca979c56-0d86-44ec-9e66-9f1d1b2901cf") },
                    { new Guid("d0fa5932-cc09-44ff-83c4-e2b60850a9a9"), new Guid("ab936883-9909-4bca-a868-3f18040a470c"), new Guid("ca979c56-0d86-44ec-9e66-9f1d1b2901cf") },
                    { new Guid("d2aa4807-6dbd-4c30-ac1a-640c07dc1c8b"), new Guid("f42cd749-8586-436e-bc85-704764629fa9"), new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024") },
                    { new Guid("d2ee5ec1-bbb3-46f3-b575-7b30b5689ec4"), new Guid("4ec0ed94-e432-474e-b2ad-7b79b0397575"), new Guid("d2d2e4da-7eae-4f44-8078-594e60f967e1") },
                    { new Guid("d45f8bf8-a6d1-4dcf-8660-bb4e8ee8cd98"), new Guid("c8078436-1ecf-496f-a86e-8fd1f391bc28"), new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024") },
                    { new Guid("d4a097ee-8408-49ca-8b02-b25815c1179c"), new Guid("169f06b1-d649-496d-9f05-f59232e5b7cc"), new Guid("a6e7cba0-c2e2-4989-beb1-b9109543bdfe") },
                    { new Guid("d57519f1-5768-4cf6-8a28-188287f9678a"), new Guid("5f478889-2e75-41b9-b838-a110d78cb1a2"), new Guid("1b9c8d1a-1dcb-4651-96b9-a28206738e0c") },
                    { new Guid("d5a21695-a503-4525-806a-05003126b450"), new Guid("a14e2275-e4eb-4d48-98df-dbffc119b755"), new Guid("78b624a4-9528-4c48-b6fd-29b7308ae44f") },
                    { new Guid("d66fc851-39c6-4e05-a745-d2d48b8e6167"), new Guid("36a7bc32-75f6-4e9b-9c7c-d32b4c8c6360"), new Guid("20a451ec-b864-4e51-b4b1-8bb720f5fd9f") },
                    { new Guid("d6f82b2b-0305-4e95-a8da-cff3750ec050"), new Guid("afed533d-905e-45d8-8d3f-d2957c6385e6"), new Guid("a332d831-d29f-4d11-ba6d-a45fd19b7f8a") },
                    { new Guid("d98a78dd-28f7-4302-b430-df05cde2cc9f"), new Guid("839aeecb-f79c-4e55-9cad-2ccf309fd504"), new Guid("20a451ec-b864-4e51-b4b1-8bb720f5fd9f") },
                    { new Guid("d9e844ba-97d7-4288-a381-3a9548e68955"), new Guid("a14e2275-e4eb-4d48-98df-dbffc119b755"), new Guid("ca979c56-0d86-44ec-9e66-9f1d1b2901cf") },
                    { new Guid("da1c1042-78f1-45c3-9563-162f37a03796"), new Guid("277434e2-f920-4b30-b27d-df630fc311cd"), new Guid("ec0827e0-83c5-4d96-b445-30bfb4eff9e0") },
                    { new Guid("dc18bda6-c488-408e-aab1-70c9313507bd"), new Guid("839aeecb-f79c-4e55-9cad-2ccf309fd504"), new Guid("71949e9b-637a-438b-8694-d9e440ec5df3") },
                    { new Guid("dc54db1c-35f5-4649-bcff-591f7ecc2706"), new Guid("c7811669-b5dc-4d8e-9899-44a8357e3b47"), new Guid("0ae3667d-8f40-412e-82b3-aae6cf496440") },
                    { new Guid("dc684f49-f0e9-418a-aafb-f6ad11fa1aa4"), new Guid("07f6069e-6fd6-4459-b912-af05eb4949b6"), new Guid("92ca8c89-1934-4e91-b501-7ba45719a744") },
                    { new Guid("dc6b6203-269b-46fb-b450-c90ddd0aa609"), new Guid("355bf34d-704b-467c-99bb-6353cc513b97"), new Guid("1199807b-46a7-4610-8df2-c7df16a2f8f8") },
                    { new Guid("dd6e03a2-cd02-4107-b674-1ee2bdce6ef8"), new Guid("3b1fa282-6d4e-492e-82aa-6ffdb000e4c4"), new Guid("d2d2e4da-7eae-4f44-8078-594e60f967e1") },
                    { new Guid("dd750625-0e3d-4c92-b48a-4c9a1e66408f"), new Guid("28918e3a-a7a7-46b1-b997-bb4abc377ef5"), new Guid("af8c05c2-4018-4859-af40-d1380e520f8d") },
                    { new Guid("ddd41a85-e741-4ff8-bc5a-3725885d7885"), new Guid("7b05d27a-6567-4ee9-9f58-134bae6cdd1a"), new Guid("8a60b900-510a-489f-af33-6ca3e36003ce") },
                    { new Guid("dde47aed-9957-4756-bbfe-d2b8ebb7ab13"), new Guid("34753a3f-73bc-4e30-9549-d743512a798e"), new Guid("78b624a4-9528-4c48-b6fd-29b7308ae44f") },
                    { new Guid("de009d5c-fe8d-4ee4-9a75-b47af95f14d3"), new Guid("82a90717-1623-4b1a-b124-5dbb6b1fd0f4"), new Guid("1b9c8d1a-1dcb-4651-96b9-a28206738e0c") },
                    { new Guid("df2b118c-af3f-41c2-97e8-e07a5dfe874b"), new Guid("28918e3a-a7a7-46b1-b997-bb4abc377ef5"), new Guid("351cdd42-dec1-40ff-9fa5-02bcf0093f48") },
                    { new Guid("e2ac43bc-8f1e-4502-95cc-254898db24b1"), new Guid("05d9780d-2c4b-4846-8048-6c5afdeca6ac"), new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024") },
                    { new Guid("e423d640-7c68-44e7-8059-754b8ff55b46"), new Guid("67fd082f-3f53-46b3-8af5-a6e8191a04a9"), new Guid("52223944-550b-4b2a-8153-7c52341506ae") },
                    { new Guid("e44a20ef-55cc-451d-b4d6-56f90fef22a2"), new Guid("77be8399-ba67-4232-aad1-298a885de944"), new Guid("83ccd7f1-1c9e-4d31-96c4-7c4fd5b66b04") },
                    { new Guid("e4838ca8-1e9b-43b5-b20b-56d15ee8e9d2"), new Guid("e678a76b-2b2e-4df0-8507-f442a94e8628"), new Guid("1b9c8d1a-1dcb-4651-96b9-a28206738e0c") },
                    { new Guid("e4b1ff21-4996-4c95-b756-dec8f5e936b2"), new Guid("169f06b1-d649-496d-9f05-f59232e5b7cc"), new Guid("1b9c8d1a-1dcb-4651-96b9-a28206738e0c") },
                    { new Guid("e55d602a-5aef-4f63-a7f8-973129b17fe2"), new Guid("58f3044a-729f-4f7d-96e7-25444c360b6d"), new Guid("1199807b-46a7-4610-8df2-c7df16a2f8f8") },
                    { new Guid("e5a55dea-3ad7-40ae-962e-100eb276b4f8"), new Guid("bf17cca9-b5b8-45b5-94f1-830bbd62fbbc"), new Guid("8a60b900-510a-489f-af33-6ca3e36003ce") },
                    { new Guid("e812fbde-53b9-4a21-a044-95926afdc529"), new Guid("dc7161a5-2823-4ba1-9b5f-cf2eb5b7671c"), new Guid("20a451ec-b864-4e51-b4b1-8bb720f5fd9f") },
                    { new Guid("e9cbc9fb-555e-4b01-b746-3bba65317716"), new Guid("1388efbe-339a-4228-a1ba-7934614223ef"), new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024") },
                    { new Guid("eb615fb0-086a-4f5d-9690-5798751422e1"), new Guid("e5042e97-8606-45fd-9ded-4cc0bd8e2890"), new Guid("78b624a4-9528-4c48-b6fd-29b7308ae44f") },
                    { new Guid("eb7c128c-a099-462e-9d28-911b2c0969fb"), new Guid("981e76d6-32da-4c0f-bd8b-21bb8cc5cd0b"), new Guid("52223944-550b-4b2a-8153-7c52341506ae") },
                    { new Guid("eeb060ca-1fe8-4b8b-8381-f3537bbcae02"), new Guid("c186d1d2-24a2-494f-a813-a418dcfa0895"), new Guid("92ca8c89-1934-4e91-b501-7ba45719a744") },
                    { new Guid("eef5abb8-1d38-4b4b-8aad-65a4c4dba47e"), new Guid("ea060651-82ad-44ad-a416-d182a93cd7d7"), new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024") },
                    { new Guid("ef2b2177-48cc-4fc9-9572-d6f1552e0d30"), new Guid("14315ec2-4158-48cf-ba1c-a61d9b88d74e"), new Guid("71949e9b-637a-438b-8694-d9e440ec5df3") },
                    { new Guid("f0fa9291-eb49-4e33-9501-5fe5285d2ae0"), new Guid("d7bf55ba-f054-4f28-80b7-9ab67de6e124"), new Guid("1199807b-46a7-4610-8df2-c7df16a2f8f8") },
                    { new Guid("f12a0842-8cb7-4fc9-a639-0cd024433435"), new Guid("82a90717-1623-4b1a-b124-5dbb6b1fd0f4"), new Guid("1b9c8d1a-1dcb-4651-96b9-a28206738e0c") },
                    { new Guid("f21c6d84-7559-48d0-a2a2-1317df4455bc"), new Guid("77be8399-ba67-4232-aad1-298a885de944"), new Guid("d2d2e4da-7eae-4f44-8078-594e60f967e1") },
                    { new Guid("f2d1adeb-4915-4732-b5d9-f76f20498955"), new Guid("77be8399-ba67-4232-aad1-298a885de944"), new Guid("a332d831-d29f-4d11-ba6d-a45fd19b7f8a") },
                    { new Guid("f47f9e71-0ebb-44a8-814a-1a9b23fb5709"), new Guid("1388efbe-339a-4228-a1ba-7934614223ef"), new Guid("92ca8c89-1934-4e91-b501-7ba45719a744") },
                    { new Guid("f65d6d29-fbad-48b3-9e57-e88ac124b300"), new Guid("4de49bf7-8e49-4816-8aed-2053c0bb33df"), new Guid("20a451ec-b864-4e51-b4b1-8bb720f5fd9f") },
                    { new Guid("f6617e4f-0275-4fb6-9f0a-387f3e94f0a0"), new Guid("71f0812b-c6f1-4c11-bd62-d7fb683f2be2"), new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024") },
                    { new Guid("f92f979d-c08f-440a-a0a9-83da47fa89a2"), new Guid("36a7bc32-75f6-4e9b-9c7c-d32b4c8c6360"), new Guid("8a60b900-510a-489f-af33-6ca3e36003ce") },
                    { new Guid("f99d13a3-b30c-4562-8a1a-46a7c60d40cb"), new Guid("f4e64e7d-896d-40d9-bf35-eb24540d49a7"), new Guid("af8c05c2-4018-4859-af40-d1380e520f8d") },
                    { new Guid("fb6b461b-9624-493d-9ae2-d86c899c0c4d"), new Guid("19290742-adb0-4a90-a40a-d3dcecd7722f"), new Guid("92ca8c89-1934-4e91-b501-7ba45719a744") },
                    { new Guid("fba6ccab-0af8-4bf7-a274-cefd80c7d484"), new Guid("dd41a399-bb80-46ff-97a5-8405a9b69101"), new Guid("8a60b900-510a-489f-af33-6ca3e36003ce") },
                    { new Guid("fd1961f5-9de0-4c11-a044-895fd20fa186"), new Guid("07f6069e-6fd6-4459-b912-af05eb4949b6"), new Guid("af8c05c2-4018-4859-af40-d1380e520f8d") },
                    { new Guid("fda49f35-92e9-4685-9915-752deafa42ac"), new Guid("74640b5e-89a1-4dfa-883c-d63f71201420"), new Guid("351cdd42-dec1-40ff-9fa5-02bcf0093f48") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("0a5d5057-49b2-4668-aac7-2a76676dc106"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("0bd3a0d6-e509-4df3-939c-1d03a40d8c82"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("11b31559-5ab0-4503-87d9-dc1f40ac7ea2"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("12c37c4e-4041-4c32-a09e-9251ddba3528"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("1406c249-5e16-4729-926c-047a3027ea22"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("17a1ca8e-43c9-4fce-a420-3f76eea42743"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("19de3737-1160-43de-996d-65e0a59e0b66"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("1b2c99f0-8216-4574-a4b6-93da66d479e4"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("1cb0ade2-3e1d-4b38-ae30-308cfb5ca98a"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("26b98a32-9586-43f1-a9f8-abd447baf467"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("33fb8f31-5df8-4fc9-b0da-63323b7c0ef7"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("3d4d5ad6-c22b-44e3-9dcd-c8a50245faad"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("4b4e02e6-cea1-4b42-a777-550ab7d9a42b"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("4c84f831-f5e0-47d8-afdc-f4007c360497"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("4e3fe722-a33f-474c-b7b1-af1aabae21aa"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("4f7099f9-2dcf-42a7-a1ab-d62e3ad76632"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("56e83c14-84fb-4721-a854-6a3e19f14e30"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("57e6f021-bbb1-4ba6-b5e6-38b919911305"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("6638f4bb-b1d1-4e75-ad8f-3b09a2e5d7c1"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("66b5ad82-7f75-4e04-97c9-c4f49d039dd0"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("66f1f447-a646-4c02-a22e-d37e4951e4d3"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("6b007d0d-8c69-4299-9710-dc562b2801ae"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("721b3720-5b57-4c2b-90fc-5f6c1694f268"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("7bfc7bc8-9534-49bc-ac4b-6e7cfc98ad9e"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("81f1fa37-da25-4f87-87b1-968cdfbbb9ef"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("8cd89352-210f-429f-9321-25a30d0c1fd5"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("94b18b17-dd33-4401-b181-7a1a32f1956a"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("a292c65e-c917-4742-ac79-6e9c73629b1c"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("a61860be-bf72-4356-870e-1057bd3d31e0"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("ae8feef8-9e42-4e2d-973a-0b097760da6f"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("b003d20f-57f9-43b3-9396-e799e0f6692c"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("ba36b8d2-898a-4509-be0d-37d6c7215ad9"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("bae76900-56b5-4ceb-8dcf-5c75f438997b"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("bb7e67c3-035a-4063-931c-a11e907a578e"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("bcb2a7a8-0662-4abd-9aa0-deab341a42bf"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("c029c637-c8de-4f44-a30e-6b8ec7cff2db"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("caba21a3-b5dc-4fe0-8c0d-e64e1c88695b"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("cee7e3f8-83f3-433b-8245-5698a7142c0a"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("d8275f46-dd74-4722-90c5-cafaa9d28059"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("d8b90517-9485-4927-9ec2-ef14716aeff0"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("d97474e4-b264-49df-bee4-4ef0c34bc6c0"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("dbbf059f-dfd3-4a9e-8880-e6a6030d282e"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("dc3e5f03-7f69-4574-a114-6a4c40ac4a6a"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("e3a272c6-3859-445b-9854-421c0c92ea0e"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("e3b6ab55-982b-458f-aa79-20c4de0cef8c"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("e47bcaf2-c2a7-4e2f-9573-f0a9b49971a9"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("f7e1eca6-e5c1-456d-ae88-8b3dbee1ef3b"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("f9a0c5e2-2709-4bf4-8353-2fe72354bea3"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("fd72b9bf-1607-46cf-939c-9494a9c697dc"));

            migrationBuilder.DeleteData(
                table: "OwnerAddress",
                keyColumn: "Id",
                keyValue: new Guid("fe6e8d8e-41e6-40df-ac7d-495ff7bb15f9"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("0cd10a72-cbcb-46df-9bfd-4dfc5b34adee"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("0eea7f87-7ada-4e6f-980d-c582ee76d774"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("29028db4-8143-4a39-a5f1-2c85b5304935"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("2a1c47c5-cb4e-4a2a-8452-ae7d9032d302"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("309d7350-c4a5-4034-97f9-d50f46e05968"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("3384d822-d817-4ba6-bde1-ef4b1c39f813"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("3bfe643c-834e-4457-892d-acfc3f7ffe25"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("470ad011-ccfc-4dfd-b246-099d2b1464bc"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("4741571b-5830-446f-96ef-e929bb92485f"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("610f685d-2101-4313-9ec1-b12625d5cec5"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("7a192262-6bfc-4e4d-b1f4-cd4cab0fda68"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("7cab6583-0027-436c-a12c-14461226f13f"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("7ff06343-83fc-4910-aa60-216d50c50d58"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("89fcf3d9-55ca-4a65-bd77-0f4f2b1db36e"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("97509f94-c424-4dc4-bab4-600e35dc0927"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("9af26cfd-2370-4fe4-965c-48808ad06c57"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("a7544dea-9d03-4b9a-8fa2-76485990c10c"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("b2ab3ec9-f11c-4dd8-b92a-c71f6e063021"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("b4f8be60-38b4-470b-8ba8-0b64013602ad"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("c567aabd-8043-4548-8645-27039b9c4fb3"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("d80c34ad-f264-4145-aad2-63dc6ac5844a"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("de3de5ec-d80d-4257-bcf5-4b7a61b3924f"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("e5883654-9acd-415c-8ec1-35ae4acdcc3d"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("eb6b8d50-5dba-48d8-b4c2-f3df27ab8aff"));

            migrationBuilder.DeleteData(
                table: "OwnerBlackLists",
                keyColumn: "Id",
                keyValue: new Guid("fd68e3bb-eceb-4739-8450-dae958c0a8ff"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("0269621a-e624-4daf-b646-3846c3003828"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("045ac0f4-6758-4d64-8881-a0cea5306bdf"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("0677174c-9e4f-42c4-86e2-65ebfb0bb8c9"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("082c0996-6e9c-4c88-8456-9e8c851be2dc"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("0bcbaa26-09b3-43e3-9274-f85e36d1221c"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("0eb9c959-b66e-42be-b49a-a303ba94ad8a"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("0ec7ac08-2897-4b78-b419-151c2743700d"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("13a124fd-0e4f-4db1-ac91-14d735db5468"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("16a5446f-0b5f-4ebf-868e-cef90963b564"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("1ac5c3d8-c8fc-4581-adf9-cbb133ecc817"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("1f5fe1f4-7914-4588-94ad-6e3625a53d3a"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("2068f256-0780-452b-b495-ff6c6870f31f"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("20b70bb3-dc43-4f68-818b-5f5039f9211d"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("20baba0d-b86c-4990-8f89-81c7422b78d8"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("2125dc0d-f4f7-4c2e-b0c2-2edde49e8c1a"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("2207f7ea-067a-4421-9fb6-3f7439f7531d"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("24541bb9-6e91-477d-bf29-24721083f9b7"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("28ab4844-65da-4611-8a5d-b1bc68ad970a"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("2d37520c-3c4b-41f3-a80a-d71c2dca59cf"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("30873a98-d33b-4b4c-9205-aed9550609ad"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("312ec8ef-0880-4e7d-a5cf-1cfd7ab12c8b"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("35cafe12-53f3-499f-948e-17b1eac158fc"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("3717289f-6cca-4e93-8de1-f475f3c4b5a0"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("384fcdcb-375f-48a9-b78b-834e987635a6"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("3a5201fd-c170-4441-8d3b-fb2f58bb4584"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("3b84c8ae-7bbe-480e-ad64-31ed87aa1949"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("3c5e6941-b7eb-481c-be35-279f11bff2b1"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("3f8bfaa2-57c8-4f18-8087-eaaa3e1297b3"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("41fe7b26-ee91-490e-b8de-0ccd7981e596"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("42b13f61-6d31-4889-a23c-306b15cfb359"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("43681466-b149-4cae-be8f-e06a87fe070f"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("44ddd232-53db-4ff1-a0d1-9a7e11a3e1c2"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("4ac4c842-9cd5-4665-9622-c1b575589871"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("4b810e10-ed32-45d9-afc4-d33eb6bebc05"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("4b922fa1-a78c-4f19-b3c9-fd0c763fdad2"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("4cf9654c-c32e-4a62-ba20-c25d81a52e34"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("4e8ba9ba-5337-4719-9c55-ffdc9ceb7fb0"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("571b19e9-b092-491f-af60-e81329026b17"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("577feffa-dcfc-4d03-a8a2-4de569012577"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("5da7a9fb-ec2d-46f0-8833-1e8125c7025f"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("606fc267-8945-43c8-a8a9-9b9ffc368980"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("6157f82a-2149-4b6f-99d3-74cac96e8c4b"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("6343d2c9-aad4-4976-a56a-33e08bf0abfc"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("635761d1-6c1c-4e75-9daf-4e51cb6a5cec"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("66b6d18b-4d14-4bd1-8f8d-d722f3982148"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("676abb4e-95b8-4206-a79e-7e1b74ede9c3"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("6834c5fb-3b44-416d-a5ad-49f91752f16d"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("69ad259f-b7eb-4130-9301-c2e9b429b5df"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("6d87a221-8a1d-4d41-8e7a-3c3d4faa2d41"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("6f7c04bd-8a17-49e5-9629-c6fadf8a1e45"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("70098187-901e-4df3-857a-0b314d541451"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("702cce1f-bcc5-40fb-8f27-64f1974dbd42"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("74cf69b5-dd0d-41fb-8e9f-bcc5e07fa257"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("78272d49-9fe3-4a53-ae7e-3c0b223f8377"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("783bc583-dd79-4da6-a152-628d280c5ef0"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("793d5d63-b090-4e01-82ba-6ed95ae8415a"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("7e49835f-8d87-4f92-8339-7707383f15dc"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("7ea48afc-488b-45c0-9d60-172c085f58fd"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("7fe9b482-35bd-47d4-83f1-6ee577a48a23"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("80c6e03a-a575-4f9e-8889-c413a248150c"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("811385c2-2126-4e9b-8411-fb84d9bebe63"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("8404dfc3-2582-43cc-817f-bc98a4842afd"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("8506a7d4-46e6-4316-a06c-aa622d49cb36"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("8689b1fe-d6bf-4e2f-9ff9-59bc8c54ed84"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("8c334e7a-dfb9-4bb2-a483-ea958a848e5f"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("8c7efcd0-f76e-4db3-b5f8-b39bd423f420"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("91e55a42-5217-4ac0-97e8-bb4f059b5738"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("938fa80a-b420-4004-a10c-698f27901d3a"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("94e18a87-2a16-4e5b-acd0-4f687a33402c"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("94f09ced-a245-454b-be34-f52d13d5ad98"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("9c446c8f-806f-47e9-b9e5-a000fef51200"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("a01ad797-5145-41a5-a875-306700b05c47"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("a0efbceb-8188-4dbe-864d-17e9ac6b3660"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("a1766420-f21e-4121-ad96-2d833fb866c6"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("a31f5197-51d1-4364-bdcc-2679c0828c1a"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("ab1b4c36-9a22-449e-9881-75dca0ea5e36"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("ab276b67-3b46-4c07-b921-5c90123848ae"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("ad37ca03-12ac-4704-bc0e-b5f1ff2f21df"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("b14cfcf1-d37e-40d3-9513-b4b5c13c2601"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("b1bdaa2d-a099-4f9d-8392-b209944e443f"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("b2b995a3-77dd-466b-b408-02882fa5337e"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("b442a119-9847-490e-b6bc-43e8ef9b9325"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("b9a82a74-5342-432d-9633-e9d20e155830"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("bc461aea-8dd3-469c-a4b0-3713fcb81fe1"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("bdced783-0458-4c7a-98a3-67e0034069b4"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("bf29f3fa-4d4b-4079-a3d8-18d7f7081643"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("bfb8da60-9a46-4186-a1a6-18719eecce02"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("c247540a-bd8d-487f-ab35-32f944857cab"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("c39d77a5-0010-48f5-944e-c933066b4bd7"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("c5b90544-0554-4907-b662-ae60f3da6dbf"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("c830d9ee-7b81-49c9-9668-3cf4a9875177"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("cdc54be0-f890-4b59-afef-3a78e5e1d5a9"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("cec3bf4f-fd5f-4fa6-893d-96038fb8f1cc"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("ced07cad-f4c7-40f9-93af-8c4788e226b6"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("d15348d1-1675-441e-84c0-6cd946096161"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("d16289d4-4820-4480-aa22-004b9569a751"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("d58ac7ff-bd38-4bef-8645-92ecda81d086"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("dfd04e25-ad91-41a0-abc0-744ee7bde3f0"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("eac51c2e-8d7f-4081-badf-b88ee576ccd6"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("f2bd207a-3087-400f-a9bb-216fd6b4109d"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("f89f47ca-28d7-4254-a016-274df754ea40"));

            migrationBuilder.DeleteData(
                table: "PetBlackList",
                keyColumn: "Id",
                keyValue: new Guid("fd57b349-9ec7-4129-8c45-4cb7997470f8"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("00002f68-1514-4a7e-b25e-302a2e6f7e70"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0360e8d7-e282-4ca9-8011-1a1f55b84233"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("053e0c43-cb67-438d-b3d5-90c1c5359d99"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0590f601-55c3-4bc5-80a2-fa673f2fac18"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0622d60a-f7e8-404b-a83a-bb4c848735a1"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("06a09e97-58af-4e34-a185-109841723990"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("07c38b7f-fe41-4ee7-8352-ebafd2fadc6a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("07f43227-6d50-46e0-b702-0ce74df6a683"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("08da310b-1515-4c08-b9d2-e7811a0339fd"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("08f5d742-9a56-4828-ad06-c57434ea0315"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("090a483c-81c0-4dcd-967e-6aa3f60f4d0b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0969ffcd-c40f-44a5-beeb-788d63bd6db8"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0a2291cf-cc9a-4fc3-9892-5cc83956ef26"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0a8f2b78-a97a-4aef-8b92-2862fa49c3e1"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0aa00fdd-98b3-47e5-8526-d973fe1b84ed"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0c7c28cd-eb40-4400-ab1a-c3cb6e0c6c69"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0c9731bd-bb2d-401e-bf0c-22bd8a4ba2b5"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0cc29f82-6e6f-4ac6-81ee-da3a32943c49"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("0ef22201-9c6c-4ac9-9e5d-a78e2338e536"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("102e9919-4c35-47a3-a8f8-049a8f459652"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("10b4a370-963a-4394-809d-7aa1ee435c85"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("115924c5-21f9-40e4-8b7b-eea2d55d8936"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1356b093-d6c0-4cc4-bf5b-98f9f4c63cd9"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1398b9a1-b7ca-42cd-bc84-65fdf6c29e1e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1794fa02-64cd-4218-b062-503037ace657"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("17e1a18e-1db3-42b1-945d-3e4924c69acc"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("18ccb4cf-a73d-4476-96e8-8bcccbd287bc"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("192f9dae-ecc3-49a4-a741-66d4e63ff122"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1a7e2e07-a03b-4ec8-8bea-f2d2ffca312f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1b4c8474-f4d3-4bb2-8c6a-aa2b667749d8"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1ba3b3d3-bd63-49b0-97c7-3f2ca95c6203"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1c65f4da-b2ef-4dd2-b638-dda2f8604ab0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1cfa4132-ebe7-4158-8b4f-050aa645a881"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1d32d79a-93a6-4700-9a11-297f511cc166"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("1f0d70ee-ad38-436c-a3fa-41654641c882"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("21a620f7-b553-40e9-9ee2-8916cfc7c869"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("22fcbdb3-3e3d-4a95-a551-cae1fdde049d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("235f1af8-0378-48e3-ae14-ffe0d658857c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("24f68ae7-ef0c-45f7-a011-59c57c944bad"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("25739e79-2b80-451c-985c-5519c63cbb71"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("25901e37-5442-42dc-a7f4-9a443169a066"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("25952684-771c-43a9-9699-cc35f5135ac9"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("26db3c81-df26-43a3-9bc4-5aa255482230"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("27562d7f-7615-4979-948b-460011d38efd"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("27d91ecc-4e56-4e9e-a401-96295a56b36e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("28084fa3-5e6a-4596-a066-5545f052b8f8"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("284a690a-464a-4a29-81ed-2975686e58dd"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("29c53722-de32-4e44-a64f-ec41648bda51"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("29ca0f6e-149a-4cda-845d-693f5902d698"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("29d9c972-a382-40a2-8ba4-e0e727434bd3"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2a11b407-f048-4eac-b26b-1f3bc13a2a21"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2c69ab50-d0b1-430e-8223-7feb3d9073ca"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2d32a960-4fae-4a95-9d3b-997e731266b7"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2df3fde3-d708-4b41-a7e2-601b0d94a2de"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("2fd9184f-8a35-490a-8b60-1d06fd740c04"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("31291840-e01a-4177-b7c9-160152211dbb"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("34690086-3545-48bc-9d0f-d8be495389d0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("34c389b2-b584-4b56-8a7e-446ad533d6b0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("36842194-1280-4a43-9fd9-312e418882b9"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("36e65554-ba25-4928-9401-bec719787c39"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("36ef7a52-a431-48b0-b0f4-f6709bd64204"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("36f48bd7-9da4-466a-ad0f-8990fc4f4aa0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("37f53d37-23db-4062-85b3-bd3ca24f1626"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("385d5d0c-a316-4a9f-bfa8-77a04b1c7b82"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("3d7ed3ab-df3c-45d2-9a22-6267f24ab792"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("400ffc0d-57f8-40d5-83fb-2ca73dbefc2d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("40365af9-4992-4ae5-8ca5-d403ec852088"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4078db80-4cef-452d-91e9-f3fbdc8eba70"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("41ce8b61-a559-4bf3-ad61-9f90232ca1da"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("41d949b0-8d94-43e2-91d5-52d126df1fb4"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("42338ea3-a3ba-4399-9830-166356c75513"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4248f4ec-24af-4f2f-b0dc-624700ab0078"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("427c7be8-2537-492f-b2db-aab42ef3d734"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("43254a85-0e27-4acd-a8d0-9d8218a8c96a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("434e59bd-0e51-4d43-9ca6-7fff3ba886e7"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4454ef74-559a-441a-a61b-aaa191f306c8"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("445901d3-1cb8-472e-ab96-52322bd1d4b8"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("44c2e77a-cf5d-48f7-8818-e6f91621f65b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("46d1718d-d4c4-4acb-9c0b-7fc73fda82ba"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4710bf9f-f3b2-4d7f-9023-f4bee69afdb4"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("473797be-81bb-452c-85e0-8629c056a61b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("495827f4-654b-4011-8676-26ed8c7617f0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4a42228c-d07b-4bab-b4b2-1e02c973b188"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4bc01906-cab0-4f87-89d9-a656e6bc2253"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4c175d4b-8d1a-4b86-b098-9844a4ca611c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4cd37d5f-6476-400a-8b73-0eaf581e740e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4dd8f745-b128-4646-9991-3109b02c1e5d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4de146f4-670d-4691-b50f-1b1bea93e29b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4e4f7a91-6152-491f-b876-49e3a57e631c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4e59774a-12e6-4f26-a0a6-e0b05c33d5b8"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4ede06ce-2a8b-4c4c-9798-c9aae6d465eb"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4f7a015a-de14-46a9-9699-ef46c19a5a6d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4fc07f7a-708d-4e33-ae19-a2592c24c93b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("4fd1c1b6-e41e-4843-a7d1-b2817786aca5"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("502d6667-f6cb-4c38-906d-3a0b63a3c332"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("505a560d-1265-453f-a3d4-26546b2e6120"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("505c3c98-27f2-45b8-b209-a040e4cc6a74"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("50dbfedc-a23a-4910-8b09-d88b6a606657"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("523c9f22-cac9-4d8c-93cb-55474ccb8b5c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("523f001a-dacd-4406-9e95-43311165df8b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("52aa61ab-d488-4c03-bf51-57e0bdb6158d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("537812c1-6dbd-4469-9cbe-03a3c9adc611"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("53e61d41-7f0a-4f31-92c8-872268b6de50"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("54982699-fb73-4c5c-8aee-f6c8010c8130"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("555fcafc-d50e-4ab3-8366-43ce56273e76"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("55db20ab-1210-44ef-bcdc-beaccc89d163"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("576df029-a6f1-4915-8d06-792a5952784f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("58e5dd4c-f7f3-4545-98c4-0516e47924c9"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("5a8ceaa1-62cf-4c2a-80c7-279ccab74ba2"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("5b3f465b-f003-4b75-a728-7fe2446d32a0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("5bf044dd-9e74-4806-a1b7-2df4ed687a68"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("5eed6e99-d3d4-4a48-ad02-edf6f2788f78"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("5fb6960b-cf1c-4832-8a17-24021802777a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6031ae92-d87a-401b-b91d-ba3734084f16"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6064b9ab-37c6-4e82-94cc-b7e56cd47fd7"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6137f143-fb4a-412b-8721-522fc63501bb"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("624c4fac-ec78-4367-b923-e47ca524c26a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("63634aa0-0d23-413a-a7fe-a2a8a0d90660"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("64207bf8-b609-4c61-b9fb-5c8bdaea5c20"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("64472576-9819-473b-85f7-6022567f7c25"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("646a5bba-ea47-41c8-b25d-f6984ab82908"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("65525ce3-d941-4a18-93a6-b712268de186"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("664a6449-b3e9-46cc-8df1-82a782327c16"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("66c23bdb-8f97-4348-8849-41bd75d90bce"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("69efd6bb-b04d-43dc-9d8b-b883f39a59bf"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("69f89e99-e40b-4da2-a31b-710b8b04dda4"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6ba57c42-d572-4caf-ad8c-80ab3b1efb1f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6bcd0a5f-7c7c-40fb-9065-87f6cd83a6cb"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6c298e96-b378-4515-b6e0-e1b39ed6c2b6"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6c63cf12-1a7c-421e-b9ca-dc12d43fcf88"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6cbb86b8-f0a0-4ba3-882a-38d2c69d25f1"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("6e5fad25-7eef-4a1c-8f74-3d4836986baf"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("70b4ff58-bd05-4fdc-8b4d-e1e39d1b7385"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("7122fb9c-9beb-4cd8-aa39-7d49e7992774"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("71314c32-c4f8-4a5b-8371-78863a12e401"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("733995c9-a71b-4d92-8fc6-48f7333e4033"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("74789d9b-ebb0-4ea9-92a9-7a51e41506d6"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("755a5fd9-0a2b-424d-9eac-a0d2c9ba79ca"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("76277e44-baa6-4e41-b22b-44f9f5f6c698"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("77a48fcb-2efe-48f6-b7d4-c9cc2a8c8feb"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("77e8a31a-1e50-4570-b7a2-716824f060a7"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("78494ca8-cd36-4e79-a37f-4fff3540c882"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("7894e087-2f93-4339-89a4-bbb7f12c8b9a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("7ac25c58-4df4-432b-b615-d6f7c4ce0201"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("7b8e4d35-8ee1-4d83-abef-b8f473d40a35"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("7ce49d25-d804-4431-a461-c0a9d5243ad9"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("7d1a35fe-ab34-4d15-9ee5-d357bc3f371c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("7d751c6e-b999-4c09-8db3-56c3f1db5ea8"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("83c2c68d-488c-40d2-b870-f24ebc8d1002"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("844dba1f-2d10-42e9-bd08-9e56e3ca5f7f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("84884831-35c7-4537-92bc-a3270c9b2258"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("84ff9761-80ce-43f9-a9ea-a8b1a8edfe36"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("85047a13-3906-4631-a099-9242fba2bf8c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("85379e47-f68e-41bc-af3f-052fc2ccb85c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("858e3998-9661-4cbc-8801-9ba21a40a3e5"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("86e4aa20-8703-498a-a0b5-e0d483ae3017"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("87bb855a-fa61-493c-b381-0b534b8f16d2"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("88077948-42d4-4f79-a01a-fac87cbe4f7e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("88e729fa-e6a6-4b76-bdc1-1f9203ed7eed"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("89f308ea-cb6a-44d1-9203-58e1358d96bc"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("8b31c1e8-25c6-43f5-8676-673ea82739db"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("8b73b155-8108-4078-83e8-675d1cc52afd"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("8c1467ce-c278-46cc-895c-d7b95f125ac0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("8c5e7966-e79e-4614-a702-aef6725a0004"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("8ccbe034-605e-4215-ad7d-a4e8a08e0a66"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("8d1ea971-8a48-48e9-a548-41a34b7ba2c8"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("8dad107b-ead5-40c7-a0e9-c6aca6090763"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("8e98d1ed-e7ab-461f-8d88-ffad469a1d1c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("8e9c4ff9-7c57-44cb-91f5-947e2b8ed685"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("8eb5ef5e-5a9c-4f67-99ce-968d47c9466f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("8eedb2d7-037b-41d6-8e65-5d4da0cca97e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("901a4e97-cbe7-47a9-bfd0-291ad9496cf4"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("90e51043-e7f1-4b26-995c-abff08082c0d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("917a2389-6bef-4453-ad8f-e08cf46f3640"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("9227e434-d91e-44bc-9e46-8a228a46f8f6"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("930973d0-3a48-4859-a17f-9d896a8ac374"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("95f40b54-e900-4ee5-83c7-5d70437caeb3"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("95fb892c-45d8-4926-9c00-c01119d7bc43"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("96a1d604-13eb-449d-ab61-ae45b45df86a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("99c11099-9a05-4519-b3a4-28be6786d7cc"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("99e838e6-d978-49fc-b162-3c3b5efac7b1"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("99f7a6f2-2117-4e2a-bcab-942fad42594c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("9a0418b1-a6b2-46da-94dd-653600a6b468"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("9b54d2f7-eefc-47eb-80f8-059ca232717c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("9bfdb0b0-c07c-45bf-9cd3-589a1a9d8e56"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("9cfe2260-f9af-4d35-b7fe-e72fa818219e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("9d021ee2-d43a-4694-a61a-9a309c285bf4"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("9da5ae42-e7bb-4234-8956-ab053de47d9c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("9e576cce-30a3-43bd-bc9e-cbef4f2e69c8"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a0b94b4a-705e-463c-9b37-e6bdd434ebcc"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a0d2b3a7-886c-4209-8a1f-b286230c0a51"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a0fa08b7-3dc3-4cbd-9217-23fc716141ce"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a0fc3ffa-351c-479d-90dc-d606311a861a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a19d2730-6520-4b20-8030-e72d403497a1"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a29b0a71-d768-4449-bcc0-5a6e6182feb4"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a2e1f357-a029-4434-8e1d-326f8fb30dda"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a4ab3b85-7c0b-4d37-88bc-1452ed1db1e1"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a89aa9fa-c672-40fa-b85f-cbdd90162182"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a98bb563-7e06-4eed-b9f0-971fa553c593"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("a99a92a0-b1c3-46f7-a863-58878ad368d5"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("aa25fa02-0ee9-4c20-a0b2-fd71df01d223"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("aa30af39-32ff-4769-a76a-c05277a52e66"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("aaa1bbec-df58-48e0-926c-ab0ae537df62"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ab8a439d-cafb-4ebc-bf06-edb3583ca494"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("abe08150-457a-4a83-b476-f3d0158ad41e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ac561fb4-4329-49b5-adde-1be2c52c7e20"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("acc65b0d-3ca4-4c3d-84dd-930356ab0676"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ad55cd19-da6c-4ecd-936b-904caa1d77f7"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ae161e4d-4f89-44c1-9fd0-da3a6abb64eb"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ae423baf-daf5-416f-a93f-4a5597057e30"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ae8ad6ae-467d-46d2-81ea-0c3fc73cb001"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("affcc611-cc65-48f5-b70c-6dd7092c4c4a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b0e49ba0-4449-460f-935e-1d486564089f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b10da139-8e03-4d9e-a142-7b84fd3b3c29"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b2917940-215b-4c9e-b153-a08cba98f800"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b2cfcb9e-1941-439b-832d-a04ff5a7835d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b3e88ceb-0263-477f-9054-37e77f9d2d4c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b3ee3243-5f76-48d1-ab70-cd949efbbe2c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b505d3f1-cb02-4af7-bd7e-ccb06edbccd8"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b5224117-21fe-40a1-9227-919184aedb29"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b6be732e-96ab-4656-8f2e-a8bcf0c4327a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b75a844e-ef34-40a7-9a10-93295a89de7b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b763c7d7-421e-4365-b727-6b641ddd6426"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b838dbd1-0465-4541-8ac4-9ed6b19f3bcd"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b9469e87-b1d3-4eb8-a34f-192a503e6a47"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b957393d-dff2-44aa-8c9f-cafec3fc48f0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b95f40ca-6ac8-4faa-a2f3-0ff88ddc2ce4"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("b96a134e-854f-4982-ae5b-d348785287ef"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("bb6dd2c0-79ff-4eb2-a306-7ef3c45aed59"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("bbe6a6ca-6ee8-4edd-be4d-8063806d4477"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("bd6b7483-6d65-43e8-9293-ca66e7f94269"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("be8ad6b6-9b39-4176-8005-20ffbbbd1bca"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("be9aed93-9454-409f-94a1-b20e45a79d7c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("bf198612-b250-4777-86b6-679fe9f1ed17"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c017227a-05bb-441f-9244-5371ba27fcf2"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c26bf50c-51d7-4c75-be4a-1390146b8dfb"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c3172d70-157f-4217-a89b-ddc4e2694da2"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c354ea37-d7d8-473f-b5aa-e7d28c0b84a2"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c48a4343-7f64-4b78-8a15-7b652468faef"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c4c88e91-8c7b-4e63-abfb-590b853405e5"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c5c59e3f-a20d-4483-b6d8-f6d334d4a05b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c62fbaba-fdec-44e9-a50e-5215796465d1"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c70e103c-b2b7-4761-9322-f9e803c79586"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c7e4030d-db23-48e9-aa8b-63fbca354439"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("c84ca1b0-e49e-4c26-ad6c-06b0aecc8633"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("cb88db77-d843-4954-9e5e-6846c0882ca2"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("cd9ff119-f4ed-4cc0-85e9-2974d8836a8e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ce47a9fd-5220-4e41-b88d-c0309f706d3d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ce9db49e-23c2-478a-8620-9e6c801ed82c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d063fa5b-d233-40f7-9fed-ddfe4eeb3a0d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d07d73b0-a752-4b84-a243-9e7be25b83c3"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d0fa5932-cc09-44ff-83c4-e2b60850a9a9"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d2aa4807-6dbd-4c30-ac1a-640c07dc1c8b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d2ee5ec1-bbb3-46f3-b575-7b30b5689ec4"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d45f8bf8-a6d1-4dcf-8660-bb4e8ee8cd98"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d4a097ee-8408-49ca-8b02-b25815c1179c"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d57519f1-5768-4cf6-8a28-188287f9678a"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d5a21695-a503-4525-806a-05003126b450"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d66fc851-39c6-4e05-a745-d2d48b8e6167"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d6f82b2b-0305-4e95-a8da-cff3750ec050"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d98a78dd-28f7-4302-b430-df05cde2cc9f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("d9e844ba-97d7-4288-a381-3a9548e68955"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("da1c1042-78f1-45c3-9563-162f37a03796"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("dc18bda6-c488-408e-aab1-70c9313507bd"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("dc54db1c-35f5-4649-bcff-591f7ecc2706"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("dc684f49-f0e9-418a-aafb-f6ad11fa1aa4"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("dc6b6203-269b-46fb-b450-c90ddd0aa609"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("dd6e03a2-cd02-4107-b674-1ee2bdce6ef8"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("dd750625-0e3d-4c92-b48a-4c9a1e66408f"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ddd41a85-e741-4ff8-bc5a-3725885d7885"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("dde47aed-9957-4756-bbfe-d2b8ebb7ab13"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("de009d5c-fe8d-4ee4-9a75-b47af95f14d3"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("df2b118c-af3f-41c2-97e8-e07a5dfe874b"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e2ac43bc-8f1e-4502-95cc-254898db24b1"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e423d640-7c68-44e7-8059-754b8ff55b46"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e44a20ef-55cc-451d-b4d6-56f90fef22a2"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e4838ca8-1e9b-43b5-b20b-56d15ee8e9d2"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e4b1ff21-4996-4c95-b756-dec8f5e936b2"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e55d602a-5aef-4f63-a7f8-973129b17fe2"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e5a55dea-3ad7-40ae-962e-100eb276b4f8"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e812fbde-53b9-4a21-a044-95926afdc529"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("e9cbc9fb-555e-4b01-b746-3bba65317716"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("eb615fb0-086a-4f5d-9690-5798751422e1"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("eb7c128c-a099-462e-9d28-911b2c0969fb"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("eeb060ca-1fe8-4b8b-8381-f3537bbcae02"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("eef5abb8-1d38-4b4b-8aad-65a4c4dba47e"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("ef2b2177-48cc-4fc9-9572-d6f1552e0d30"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f0fa9291-eb49-4e33-9501-5fe5285d2ae0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f12a0842-8cb7-4fc9-a639-0cd024433435"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f21c6d84-7559-48d0-a2a2-1317df4455bc"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f2d1adeb-4915-4732-b5d9-f76f20498955"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f47f9e71-0ebb-44a8-814a-1a9b23fb5709"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f65d6d29-fbad-48b3-9e57-e88ac124b300"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f6617e4f-0275-4fb6-9f0a-387f3e94f0a0"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f92f979d-c08f-440a-a0a9-83da47fa89a2"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("f99d13a3-b30c-4562-8a1a-46a7c60d40cb"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("fb6b461b-9624-493d-9ae2-d86c899c0c4d"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("fba6ccab-0af8-4bf7-a274-cefd80c7d484"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("fd1961f5-9de0-4c11-a044-895fd20fa186"));

            migrationBuilder.DeleteData(
                table: "PetTraits",
                keyColumn: "Id",
                keyValue: new Guid("fda49f35-92e9-4685-9915-752deafa42ac"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("d49c3583-5f26-42d7-b37d-b7962b4f8087"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("39d5a768-3ea4-4379-af70-d9145b4ba9bd"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("51199e7e-a2f7-45cc-b35b-949da76938d7"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("56f9da6d-3e7d-41a3-8f62-f356caf90972"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("5f301ca8-cb94-4d44-999e-d375a7520097"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("71eceed5-dc8c-4740-97ae-bf2ef39448f5"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("7bf31e3d-4c24-49fb-aa95-5d6664f5cf93"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("be988db3-87d2-4bd8-86f1-54c81e135ebe"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("00d77d77-a4d8-4990-9bb0-d6481338cb39"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("05d9780d-2c4b-4846-8048-6c5afdeca6ac"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("07f6069e-6fd6-4459-b912-af05eb4949b6"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("12d13f50-09f0-4607-b210-36aab22eeff7"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("1388efbe-339a-4228-a1ba-7934614223ef"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("14315ec2-4158-48cf-ba1c-a61d9b88d74e"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("169f06b1-d649-496d-9f05-f59232e5b7cc"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("19290742-adb0-4a90-a40a-d3dcecd7722f"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("1b730010-57dc-40f8-b6f6-9eaa18ce3d2b"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("1baee819-2ebb-4c48-9571-def68afbaae7"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("1e64c681-4c58-486d-91d4-34130ae1ca9d"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("22e84bce-a188-46bb-9d13-420b5057bdfe"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("277434e2-f920-4b30-b27d-df630fc311cd"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("2873d706-906f-4404-9e02-e06f9d3ddf1e"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("28918e3a-a7a7-46b1-b997-bb4abc377ef5"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("2f1266da-9bb2-47ef-b7e4-60c30403424b"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("30bc9e9b-3d76-46e1-b591-f2f8df5754b3"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("325e6ff8-e3dc-4b6a-865d-91e151fd71b2"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("332ad470-6a1d-4935-9d12-9fad8e1386a2"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("340926b7-72f7-47b7-8bd4-62f3b75dcaa5"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("34753a3f-73bc-4e30-9549-d743512a798e"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("355bf34d-704b-467c-99bb-6353cc513b97"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("36a7bc32-75f6-4e9b-9c7c-d32b4c8c6360"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("37ad2dc3-3edf-4de9-a10c-c2617e9f16c3"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("3824cdba-52fe-486f-95f5-f1e6a82b6c3b"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("3b1fa282-6d4e-492e-82aa-6ffdb000e4c4"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("3c70b30b-cfb0-4c9f-8630-7c350801283e"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("42aa226a-7ab8-4984-a2e7-f05ee1263d5f"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("4755b654-c427-4096-9e42-1345cc9ebb23"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("49ed827a-830e-4c0a-95ad-77991a0f9e58"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("4a83a64a-0bab-4f6c-be30-6cc980104bc8"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("4c288215-ecd1-4ecf-937d-4910c61641cb"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("4de49bf7-8e49-4816-8aed-2053c0bb33df"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("4e285e9b-0294-4821-823a-c6709706d678"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("4ec0ed94-e432-474e-b2ad-7b79b0397575"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("58f3044a-729f-4f7d-96e7-25444c360b6d"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("5a61275f-6307-48f1-9214-7bb16a4effc8"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("5b7cda18-7ea3-4504-a0fb-6da861aaf676"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("5f478889-2e75-41b9-b838-a110d78cb1a2"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("6477dd91-70bb-4b9c-9082-7585d9cebef9"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("67fd082f-3f53-46b3-8af5-a6e8191a04a9"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("6825b413-3463-4c74-8662-ef72368ef8f6"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("6b3d7881-1d5d-4625-b2bc-8c18f6a9f57b"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("6b9dda79-08fb-4990-b286-abd276e3742f"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("6d34ef94-4aa9-49bf-8751-6f91df5d192a"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("6fe52d0d-a4dd-45e2-86f3-6d3491e41546"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("71f0812b-c6f1-4c11-bd62-d7fb683f2be2"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("74640b5e-89a1-4dfa-883c-d63f71201420"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("77be8399-ba67-4232-aad1-298a885de944"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("7b05d27a-6567-4ee9-9f58-134bae6cdd1a"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("7e071e9d-a0e9-4a0d-bbf4-360a332dc5c1"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("7f1064dd-a82f-453c-9367-3fb1f9444a60"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("82a90717-1623-4b1a-b124-5dbb6b1fd0f4"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("839aeecb-f79c-4e55-9cad-2ccf309fd504"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("86f61e72-7a14-4da5-aab6-2732bb04c9d7"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("87b72fdf-0162-4e82-ba5f-b1b44e69d923"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("883c758e-8408-4cb5-ad66-acea4b7e1628"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("8a7a35fd-ac06-455d-afb6-eb5bfff1eb87"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("908226ec-d2a1-45d7-886b-b85550fde710"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("927e59a5-9638-4e28-b16e-41a829d7226d"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("9366dfdf-965d-4b6f-872f-c9efce53fe0a"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("96f53566-5908-405f-a256-422d6bb50a23"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("981e76d6-32da-4c0f-bd8b-21bb8cc5cd0b"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("9b9b8fcf-6680-46c9-bdd5-6f55ff1ed1c4"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("9ba3565e-2756-444f-bdb5-9468d4fd9dd8"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("9c03735f-f0d9-46d7-ad19-0e5591ec9c71"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("9f52579f-62e8-4253-9421-9e0d5529f485"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("a14e2275-e4eb-4d48-98df-dbffc119b755"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("a1bdaa2e-96a6-4fbb-ac8e-e8026a060467"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("a1e98442-2aa8-499c-8830-babfba1fcce3"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("ab936883-9909-4bca-a868-3f18040a470c"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("ad568c6d-ac6c-4484-a10f-60fbc3c2a9aa"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("afed533d-905e-45d8-8d3f-d2957c6385e6"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("b7d32ace-fa4e-4be4-92aa-459c443db207"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("bf17cca9-b5b8-45b5-94f1-830bbd62fbbc"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("c186d1d2-24a2-494f-a813-a418dcfa0895"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("c45e5201-fce3-4da1-97c1-638f6fa06537"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("c5576d2b-d5b2-43cc-9fd9-5c16b3c89ce4"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("c7747564-15f5-4833-bf7f-088ec520f58d"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("c7811669-b5dc-4d8e-9899-44a8357e3b47"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("c8078436-1ecf-496f-a86e-8fd1f391bc28"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("c93356e0-c5df-4012-b02b-63bc4f96db8c"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("cf16cea8-228e-46ce-832a-c081596b9c1c"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("d2d35f35-1cc4-4617-855c-c79d4217d573"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("d2d6e165-cfa6-42ce-a987-11db81476696"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("d7bf55ba-f054-4f28-80b7-9ab67de6e124"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("dc7161a5-2823-4ba1-9b5f-cf2eb5b7671c"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("dd2a356c-ec21-4362-9ce8-48b2635be906"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("dd41a399-bb80-46ff-97a5-8405a9b69101"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("e5042e97-8606-45fd-9ded-4cc0bd8e2890"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("e678a76b-2b2e-4df0-8507-f442a94e8628"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("e6a1186d-4bda-44b3-8c33-f633a99cf5e7"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("e7ce2366-c49c-43d2-bd1a-bc51d06e07c2"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("ea060651-82ad-44ad-a416-d182a93cd7d7"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("ea9e33a2-6423-40c7-8458-f231e241a48d"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("f1406458-eb5b-4b12-9a3a-44e0af77fefb"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("f42cd749-8586-436e-bc85-704764629fa9"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("f4e64e7d-896d-40d9-bf35-eb24540d49a7"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("fa31ccd2-97ac-473b-ad32-4580cb1200c1"));

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "Id",
                keyValue: new Guid("fdd870dd-a2b8-4e4b-b1aa-9f2650ff8a93"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("0ae3667d-8f40-412e-82b3-aae6cf496440"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("1199807b-46a7-4610-8df2-c7df16a2f8f8"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("1b9c8d1a-1dcb-4651-96b9-a28206738e0c"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("20a451ec-b864-4e51-b4b1-8bb720f5fd9f"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("351cdd42-dec1-40ff-9fa5-02bcf0093f48"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("3792fafe-b235-4edc-a65c-eb02bf5be024"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("52223944-550b-4b2a-8153-7c52341506ae"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("71949e9b-637a-438b-8694-d9e440ec5df3"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("78b624a4-9528-4c48-b6fd-29b7308ae44f"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("81070cd0-8b4a-4300-bb57-655c4298460c"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("83ccd7f1-1c9e-4d31-96c4-7c4fd5b66b04"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("8a60b900-510a-489f-af33-6ca3e36003ce"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("92ca8c89-1934-4e91-b501-7ba45719a744"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("a332d831-d29f-4d11-ba6d-a45fd19b7f8a"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("a6e7cba0-c2e2-4989-beb1-b9109543bdfe"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("af8c05c2-4018-4859-af40-d1380e520f8d"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("ca979c56-0d86-44ec-9e66-9f1d1b2901cf"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("d2d2e4da-7eae-4f44-8078-594e60f967e1"));

            migrationBuilder.DeleteData(
                table: "Traits",
                keyColumn: "Id",
                keyValue: new Guid("ec0827e0-83c5-4d96-b445-30bfb4eff9e0"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("04459cfb-692e-4475-afb1-33d400cae41f"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("0696f671-ccd6-4125-8bcf-c62f384587e9"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("07fd045d-9b6f-4525-8c88-13367a62696e"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("1487a601-2e3f-4925-a441-f11771ca9331"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("16c0ad3f-f23b-47cb-8388-77cdac0176a5"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("1eb863c0-c465-4e47-930e-2f34bf15df45"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("269b8217-e2ae-4d4e-9e34-ebead7462008"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("276c1f3a-df96-4365-a817-2ac7f8dc3e82"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("2c1d4616-73ca-4da3-866f-96b825633238"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("474db7bb-8245-41f5-8692-529d4b233c8e"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("4c7c9bb0-0893-4367-b528-72e8f057446a"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("5d5ec955-5c89-4184-aad1-60a490b45d26"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("5eeec4d0-8dea-4f52-97dc-a0bc4da80c8b"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("6298b950-aa92-45d3-b7f3-2c3b603f54d7"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("6330f354-5991-4fe6-b0da-aa167cbf96b9"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("633626e7-c38f-4921-a6f2-a8992a01695f"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("6b63a1b6-8e6d-4dea-94ae-972351fcfa7f"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("7fac973b-5274-4642-ac85-69ebaff1d6db"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("836556f8-ef67-4154-b77e-085146e347fc"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("8c1f9909-dd55-4ee4-9231-2dbcb2de862f"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("8f093f73-97e5-40b2-a2d6-021c3dafd195"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("96ee043d-08f7-41e0-9c7e-fe08b9044ebc"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("9e6402ea-8608-4fd9-acb1-87ac38e54b00"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("a4bcdb88-61fa-4bbc-968c-0639294c8906"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("b2bcb3be-fb0e-48d3-b637-2238d1a81742"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("b5e8071a-d25f-4735-888a-e9a258bb8e4d"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("b8254eb2-c72c-4f0f-92d2-dd611b51fb27"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("ba69c9e8-7aef-433e-bee5-21b65e8e7924"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("c371d1cc-00aa-4db5-bfaf-7c93ae0fc281"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("c3770496-c4fb-44e0-89c7-0ccfb10e6422"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("cbf27b34-90a5-4ef5-8c88-629f2f11deb5"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("cc5fd2e3-c957-4226-a5fb-426ffabf5a10"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("cea216c1-f435-4c81-9ae3-c74b89fd9ddf"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("d52884fc-7218-4f65-a467-de9a9253b7ac"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("d7cdf4b9-8655-4912-9f57-e1734cca3433"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("dbca6e1c-82c7-4737-89ea-a07538584caa"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("e8422ef2-f848-44d9-b654-19fa3d64a0c9"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("ea7ba43f-4c05-4a3e-9c85-fcaae49ead38"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("f0c71657-d493-451b-87e8-23ec3c10ea1d"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("f0d909f2-8333-4c06-b2e5-bd7d8e8aab14"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("f2ffc96b-952a-4734-b202-0715e0736247"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("f3445268-2294-4e35-b6a0-67e81ef32629"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("fca2afc6-7d2a-427c-82b4-1dc3f257c013"));

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: new Guid("ff09805c-1069-4e10-8f74-42a86c3eb034"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("253e951a-4751-4bd5-9787-f5e4ff6f0303"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("32b1da23-2345-4fff-af31-f2c6ddca00e2"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("54a9e58d-1fe8-4cce-aba0-1e04d980c45d"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("717009cf-c0cd-440a-b9e7-77f92ba7736f"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("936a8715-0008-4ea0-b630-0b030f5e7d70"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("c9dda37a-9284-4681-b063-959feceeb3a8"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("ca4b7ea0-8da5-4ddb-9cd2-646789905c56"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("d606b1aa-88d8-4121-94dd-58ae77242dd5"));

            migrationBuilder.DeleteData(
                table: "PetTypes",
                keyColumn: "Id",
                keyValue: new Guid("dab10d56-ce3b-405a-9a1d-79de42cf29d8"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Owners");

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "DateOfBirth", "DateOfRegistration", "Email", "Name", "Password", "Surname" },
                values: new object[,]
                {
                    { new Guid("06e68c47-2908-48fb-bf0a-d577ed1fb737"), new DateTime(2022, 3, 11, 9, 19, 13, 181, DateTimeKind.Unspecified).AddTicks(1934), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(8039), "92bb3b06-b4ed-452d-a97e-34427c8c356a", "Beckett", "ea2bf89c-7f23-4598-9fbf-8b72c82d1fda", "Crosby" },
                    { new Guid("0f540469-bae4-4631-98ea-71a5588dffb6"), new DateTime(2025, 8, 26, 15, 38, 35, 134, DateTimeKind.Unspecified).AddTicks(1136), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(2302), "bade4216-17cb-497e-8430-b066866b49f8", "Micah", "88b5e563-4b31-443c-ac34-3843a539941f", "Justice" },
                    { new Guid("172645b5-42b9-4e09-8389-47fb6554c609"), new DateTime(2022, 5, 15, 0, 32, 34, 55, DateTimeKind.Unspecified).AddTicks(9403), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(4261), "ba510eaf-b282-43ca-b431-e8f361d89105", "Briar", "0be1043b-0582-4fb9-a338-0534e8b9933d", "Crosby" },
                    { new Guid("1d4c7423-bea7-4dc9-bb7f-54c662d8f264"), new DateTime(2025, 7, 3, 2, 43, 18, 478, DateTimeKind.Unspecified).AddTicks(9118), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(5281), "0bf808de-e2fe-402e-bb8d-23825864433a", "Micah", "2d03de1d-3004-411b-bad7-482dc8610ec7", "Khalani" },
                    { new Guid("224eb59e-272a-4585-a664-02c09fbc30c7"), new DateTime(2022, 3, 3, 12, 28, 56, 308, DateTimeKind.Unspecified).AddTicks(3628), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(9058), "ba4a7c4c-52f0-4b9f-9272-3768b34ab74d", "Beckett", "607c9bf2-449b-472e-9523-f6d46b724234", "Amber" },
                    { new Guid("271353d9-7fed-42c4-8112-12638f7932a7"), new DateTime(2022, 3, 25, 18, 32, 4, 466, DateTimeKind.Unspecified).AddTicks(3193), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(1275), "87a4bb02-c7f8-453a-bda4-8d77d4dbef20", "Micah", "d82ebaf6-3f7b-45f0-a6bf-b2685009ee6e", "Justice" },
                    { new Guid("2bd4e8e5-f655-4967-af56-0f289907f4fb"), new DateTime(2022, 9, 15, 8, 27, 55, 17, DateTimeKind.Unspecified).AddTicks(7968), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(1028), "865de4cf-26d9-4a7c-ac5e-3adee23d4303", "Chana", "48d9abd2-03a1-43a3-8dbc-ed1a36b6ff37", "Foster" },
                    { new Guid("333da5b9-dbc7-403f-86e7-389868bc2a57"), new DateTime(2025, 5, 8, 20, 32, 25, 827, DateTimeKind.Unspecified).AddTicks(589), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(6272), "b651ff71-b4e8-42e9-bb06-1cf0f5ba5cd5", "Amber", "2fc90681-c308-4d42-a199-3b0b3d328e6b", "Avayah" },
                    { new Guid("37472e61-1113-405f-a380-dc3ce041e71a"), new DateTime(2025, 4, 23, 4, 31, 26, 74, DateTimeKind.Unspecified).AddTicks(5420), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(7755), "53a4c117-9787-4d3d-89e9-9c25540f1f2e", "Crosby", "19365bab-becb-41d4-8162-4d72c5d5cfae", "Crosby" },
                    { new Guid("3c5ded76-1b8c-4a08-87d3-9e9704b0fb4b"), new DateTime(2023, 12, 13, 18, 57, 12, 719, DateTimeKind.Unspecified).AddTicks(9905), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(5040), "9432ff95-fc4f-4128-ae6d-ddd7df3619bb", "Briar", "7f5e89f1-b9ce-41b6-9511-33c6baf4dbb0", "Micah" },
                    { new Guid("40ccfd95-ca26-4908-805c-27c31995ead7"), new DateTime(2022, 3, 15, 18, 17, 19, 402, DateTimeKind.Unspecified).AddTicks(9757), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(527), "18f8d200-2f0f-4a3a-856b-ec00153924f2", "Demi", "cd31e80b-e454-446e-abaf-8de14adccb4d", "Justice" },
                    { new Guid("4f2457d8-73e3-4e44-81aa-2cc1c33b975c"), new DateTime(2023, 1, 5, 16, 12, 12, 296, DateTimeKind.Unspecified).AddTicks(6631), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(6513), "fb9e9256-fe2c-45c7-a653-9e0dc122651e", "Coen", "54061847-2b3e-4330-8dad-3d524fa1e62d", "Chana" },
                    { new Guid("5a5b5d0a-bd5c-45ea-8173-c9c4645eb77c"), new DateTime(2025, 10, 2, 8, 23, 44, 384, DateTimeKind.Unspecified).AddTicks(8151), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(5792), "ed6fdac4-194f-41b8-b0ec-a0b3824a027f", "Foster", "4cf3583b-518b-4483-b433-8b163dce52b6", "Demi" },
                    { new Guid("5cdf3890-7422-4c7e-aba6-9a729038d9e5"), new DateTime(2022, 4, 8, 14, 14, 43, 832, DateTimeKind.Unspecified).AddTicks(6151), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(8781), "aee58d04-5477-44e4-9a54-b237597041b2", "Lu", "353b893f-fb86-4ae2-b9d3-068a916d2650", "Chana" },
                    { new Guid("63e0f957-9491-4fba-9021-433d299d371a"), new DateTime(2025, 11, 28, 14, 28, 35, 395, DateTimeKind.Unspecified).AddTicks(8259), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(7278), "f4da19a7-7395-4513-a536-852e412795b2", "Clark", "8e6a074d-737e-42fa-b5b1-edd3003715ea", "Micah" },
                    { new Guid("6ed9a22b-43b3-44aa-acd5-1afde26c3886"), new DateTime(2025, 5, 5, 8, 5, 58, 625, DateTimeKind.Unspecified).AddTicks(6368), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9795), "cb0d4898-b24a-41d1-a50c-50689755e6e1", "Foster", "81f2a398-c9fe-4510-8ff4-dc0122bb6fcf", "Briar" },
                    { new Guid("6f87b266-78a9-49b4-87b3-a4657e1975cb"), new DateTime(2023, 9, 1, 13, 38, 34, 228, DateTimeKind.Unspecified).AddTicks(2568), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(5519), "9a8f9f04-8c46-46e3-8ac2-24cf87dd59ee", "Justice", "c8874e5f-1b78-45fd-a425-1b7a09d59aa3", "Beckett" },
                    { new Guid("79e350e7-a868-4361-8c1c-9c553fd8e805"), new DateTime(2022, 10, 13, 3, 53, 4, 446, DateTimeKind.Unspecified).AddTicks(3482), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(1506), "b90ac0f0-131b-436f-97e9-6b366bd8303c", "Milena", "5f8976a5-24eb-4e1f-89be-0a7d2c03b423", "Clark" },
                    { new Guid("7de5f8a6-11a7-4e61-8877-0133c99c012c"), new DateTime(2023, 9, 16, 1, 1, 7, 618, DateTimeKind.Unspecified).AddTicks(2495), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(279), "9c58c130-1233-4869-b33c-ddfac86b690c", "Beckett", "cce848b9-8d1f-4ab5-be17-4a003a1bbc0b", "Justice" },
                    { new Guid("8290dbfd-c402-40f6-9768-8d42108ecce3"), new DateTime(2025, 3, 27, 17, 12, 52, 299, DateTimeKind.Unspecified).AddTicks(339), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(9296), "4d5eaf1b-d889-4558-925e-35310192e12a", "Hope", "1f1145bc-48e0-472e-a876-3dd087ceab5f", "Chana" },
                    { new Guid("836375a0-81eb-4c40-b3b1-5e3960cdfe98"), new DateTime(2023, 1, 16, 7, 8, 6, 655, DateTimeKind.Unspecified).AddTicks(5112), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(476), "ef0a1c0f-0839-45b1-a493-ad18dc17ffa1", "Helen", "8ee71ab9-7992-4cdd-9997-500c40c298dd", "Lu" },
                    { new Guid("860b86b6-d9c7-43ea-9b0c-502cf264f6aa"), new DateTime(2023, 5, 23, 2, 50, 24, 954, DateTimeKind.Unspecified).AddTicks(3818), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(1028), "3ccf1bdd-9a51-416e-8a9a-9a0d89d29b88", "Lu", "53a3b40e-2c12-44a9-8570-cd5b62f1061e", "Clark" },
                    { new Guid("8d462759-0ec9-42ea-bfb8-ed9985d32c74"), new DateTime(2023, 1, 18, 17, 43, 54, 251, DateTimeKind.Unspecified).AddTicks(2159), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(8540), "1c03670e-3d00-47e9-9666-bbbfbe1a2cb8", "Khalani", "26f899fb-ea1d-4f45-91b7-86e3ad2ea677", "Paula" },
                    { new Guid("8f591412-f075-4143-b5a0-14a74d29ff10"), new DateTime(2024, 10, 1, 15, 28, 6, 163, DateTimeKind.Unspecified).AddTicks(6077), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(7517), "3052e13c-d7b8-4f52-a8f2-1a1756319275", "Milena", "09163342-5a9f-44ad-a2cb-4dc9e9356443", "Avayah" },
                    { new Guid("9561bf0b-8913-4c21-826b-38dbfb7d0b06"), new DateTime(2024, 9, 1, 2, 19, 21, 772, DateTimeKind.Unspecified).AddTicks(7369), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(4535), "69c78907-642d-49ea-8d28-e02aa83b1531", "Micah", "b7f8ecce-e40f-42b1-9581-9a9f2cf2c3f7", "Helen" },
                    { new Guid("a696d93f-c9f9-4cda-ac14-1159c1c8fd8c"), new DateTime(2025, 3, 6, 8, 40, 49, 68, DateTimeKind.Unspecified).AddTicks(1788), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(2539), "3a636063-8a38-4fe1-b5d0-36ef0680fb20", "Briar", "1bf9eda8-7079-40c7-bd1a-89263f44cead", "Milena" },
                    { new Guid("baf1a844-c5ee-48c0-86e7-be46490fc54d"), new DateTime(2024, 1, 13, 12, 49, 2, 429, DateTimeKind.Unspecified).AddTicks(2786), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(6758), "6e55816f-0afb-48d2-b109-380ccd5099b5", "Khalani", "ecf825b1-e83e-4b77-9b2d-25791dfee235", "Milena" },
                    { new Guid("c04d44f6-7f68-499e-9d16-c802a7241374"), new DateTime(2023, 5, 16, 23, 5, 10, 738, DateTimeKind.Unspecified).AddTicks(2653), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(8278), "d6328fe2-ac6a-4c1d-9f80-3a73603634c1", "Leonard", "cc373534-1a1b-4f6f-b1bb-131698b36127", "Coen" },
                    { new Guid("c186dfd8-8518-418b-9291-7b4839e64ee6"), new DateTime(2023, 9, 17, 2, 53, 46, 902, DateTimeKind.Unspecified).AddTicks(8953), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(3262), "05c21b1f-cac9-4f6e-b191-e6f9ed6dab11", "Chana", "3f355050-252a-4778-93f9-ae34ee7898eb", "Milena" },
                    { new Guid("c242bb15-83f6-4320-95f1-4b8d8df06e16"), new DateTime(2023, 10, 3, 23, 6, 11, 648, DateTimeKind.Unspecified).AddTicks(7870), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(1787), "113fbaf1-dc95-495d-af01-cdef4853aa0f", "Milena", "4d254f87-75a4-4889-86ab-0b6ad272eca8", "Briar" },
                    { new Guid("c388d447-ae5e-4a9d-8af7-7130829f4e6a"), new DateTime(2025, 11, 12, 17, 30, 3, 87, DateTimeKind.Unspecified).AddTicks(7680), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(2009), "fa2f90ad-84e4-4bca-aac0-8d1ff31901d6", "Milena", "65c9896a-f524-4aa7-b2da-3264df835100", "Amber" },
                    { new Guid("c98319ae-1264-4d91-a2a6-80df6f0ccf65"), new DateTime(2023, 1, 19, 9, 50, 49, 681, DateTimeKind.Unspecified).AddTicks(3232), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(4800), "0e59d35e-167f-4619-ab4f-e9f0c4e0fd5c", "Micah", "333885bc-afc7-4294-b787-78bff5f5e40c", "Crosby" },
                    { new Guid("cab93e0a-478b-47cc-83cc-4033f19d1cb6"), new DateTime(2023, 9, 25, 10, 48, 13, 114, DateTimeKind.Unspecified).AddTicks(9815), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(3025), "9af7495c-d26c-43ad-abf0-424e90414d54", "Lu", "1752e952-8296-4cbc-934b-2a3de937754c", "Dane" },
                    { new Guid("cfaf4f24-4dd0-407e-9dbe-d2edbcd678d9"), new DateTime(2022, 1, 22, 20, 54, 32, 473, DateTimeKind.Unspecified).AddTicks(4762), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(2544), "f4ed9489-967b-4952-a68b-5c2ab062d4f4", "Dane", "0bd36452-d4ff-46f2-896e-17b807850451", "Chana" },
                    { new Guid("d0538a29-4480-4a49-8ae9-ae702851af56"), new DateTime(2022, 4, 14, 4, 28, 43, 176, DateTimeKind.Unspecified).AddTicks(3931), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(767), "966a407e-df99-4107-888d-c11d1468c02e", "Crosby", "7a352319-0625-4b61-8c73-8396ac1ca88e", "Crosby" },
                    { new Guid("d16faf31-4569-4193-989f-8620266ebf15"), new DateTime(2023, 5, 31, 8, 53, 59, 422, DateTimeKind.Unspecified).AddTicks(4119), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(2029), "0730a0fb-9f9c-449a-829e-f5658b1b8856", "Foster", "34c7091f-c8a2-4538-882c-c260392eccfd", "Foster" },
                    { new Guid("dc8e1994-a4b3-440b-80e5-544385a4de86"), new DateTime(2025, 5, 28, 5, 19, 3, 884, DateTimeKind.Unspecified).AddTicks(7897), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(41), "6055c1aa-a349-4017-911b-4dde17ac1090", "Beckett", "f2d639f1-b19d-4e30-96df-b00f99e12796", "Clark" },
                    { new Guid("dc96388f-474d-4b07-ada6-571ab51cb1ad"), new DateTime(2024, 8, 9, 21, 38, 7, 272, DateTimeKind.Unspecified).AddTicks(9377), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(2784), "dbd4b067-e498-4472-b316-18f2d82c4455", "Khalani", "3012246e-ea45-42e7-be59-4bcdaae67156", "Beckett" },
                    { new Guid("e0af56ce-4435-4dd6-9768-19888f0d3089"), new DateTime(2025, 8, 30, 20, 46, 52, 178, DateTimeKind.Unspecified).AddTicks(721), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(9536), "f98f239d-040e-46fa-8c32-b6dc2c5b54fb", "Amber", "33c9e3f8-2b1c-4d7d-b3bd-838f545e7808", "Demi" },
                    { new Guid("e1e88552-80ea-490f-9fa3-d2126e702d92"), new DateTime(2022, 2, 24, 4, 24, 0, 602, DateTimeKind.Unspecified).AddTicks(6687), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(6034), "e9f360b6-c386-4d1f-bb99-0f64d4e5a461", "Dane", "ec5285f4-b150-409c-bf47-c6d1e3f0e60c", "Leonard" },
                    { new Guid("e3608426-7318-48f3-9b76-3876d685a77e"), new DateTime(2022, 10, 7, 16, 51, 35, 587, DateTimeKind.Unspecified).AddTicks(3528), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(2268), "6546b1c3-f495-45e6-8d87-c49c5eeff654", "Helen", "e549370c-b695-4a58-a74f-b551b0af3071", "Avayah" },
                    { new Guid("e7931cdc-005c-4788-8286-ffe776b56e9e"), new DateTime(2023, 9, 15, 12, 29, 4, 610, DateTimeKind.Unspecified).AddTicks(2200), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(3502), "a44a557c-87a8-4b26-b8d4-8a8ff76eccd9", "Milena", "51b60936-f49a-470c-9ca9-9d8062c8caa4", "Chana" },
                    { new Guid("e7d6bac8-737d-4612-9851-384e010d308b"), new DateTime(2024, 11, 21, 11, 49, 8, 476, DateTimeKind.Unspecified).AddTicks(7988), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(1266), "9397177a-bf87-4e36-815e-a960e8400f22", "Beckett", "6cc3a51b-bb12-41ff-8445-371b3464fc5b", "Hope" },
                    { new Guid("ed45e958-9bd1-402e-8ace-9765cbc310f4"), new DateTime(2022, 5, 23, 16, 11, 4, 124, DateTimeKind.Unspecified).AddTicks(1703), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(3771), "2b8ad163-16a1-4473-aa1c-ee6cef573f09", "Hope", "ad37cd52-7072-4d7b-8794-456f743a5dc0", "Justice" },
                    { new Guid("ed46dfad-4785-4421-ae34-a7da86620b68"), new DateTime(2024, 9, 13, 3, 2, 15, 998, DateTimeKind.Unspecified).AddTicks(8248), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(775), "4dc3282e-c079-46e2-8d71-6da64d19dadb", "Leonard", "c9d12ee4-bb86-4ca5-bb80-6bd943da1368", "Leonard" },
                    { new Guid("eea8313f-0781-46e7-b259-3606a6980029"), new DateTime(2022, 10, 20, 11, 46, 11, 643, DateTimeKind.Unspecified).AddTicks(6813), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(1546), "86583391-1976-45c0-a693-1107d9aae781", "Micah", "608c97c3-97b9-49b9-ba7a-fe50516bb674", "Micah" },
                    { new Guid("ef2ac790-932e-4046-baf4-7455988ba402"), new DateTime(2024, 7, 20, 20, 54, 12, 12, DateTimeKind.Unspecified).AddTicks(2637), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(1769), "92b30126-68a2-4ce9-bfca-8919964b1bb3", "Coen", "4a96550c-93ba-4b85-8272-909d5f62a913", "Paula" },
                    { new Guid("f7206678-9038-464e-982e-52853d8ae1c1"), new DateTime(2025, 9, 19, 10, 16, 28, 961, DateTimeKind.Unspecified).AddTicks(176), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(4021), "80a5dc9e-30b9-41b8-bfd1-d1a43cb74ac3", "Foster", "ff1e81e1-1d6f-47a7-97e1-8987c27fd91c", "Helen" },
                    { new Guid("fc0c907a-78b4-4738-a34c-e7779923eb69"), new DateTime(2022, 10, 28, 1, 48, 15, 263, DateTimeKind.Unspecified).AddTicks(5716), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(7020), "9606a150-4dc9-47a8-9445-fad1044652f3", "Beckett", "235bc848-16f3-4486-b60b-090de79703c0", "Avayah" },
                    { new Guid("fd35871d-6417-4c3b-8d59-b64295462b6f"), new DateTime(2025, 1, 3, 3, 28, 49, 989, DateTimeKind.Unspecified).AddTicks(1095), new DateTime(2023, 12, 19, 16, 0, 27, 455, DateTimeKind.Utc).AddTicks(9777), "ca0b8dbb-f5ad-4b8c-8629-1cc8fc5d2ad3", "Avayah", "c80fb5c7-9cc1-409b-a427-8c41b11db9dc", "Beckett" }
                });

            migrationBuilder.InsertData(
                table: "PetTypes",
                columns: new[] { "Id", "DateOfRegistration", "Type" },
                values: new object[,]
                {
                    { new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9269), "Horse" },
                    { new Guid("0d374c06-008e-4cbe-bbe4-6f385b7725e5"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9278), "Rabbit" },
                    { new Guid("25c0e5be-95a2-4569-9c43-e44e1b3e8ce6"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9285), "Rabbit" },
                    { new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9276), "Horse" },
                    { new Guid("2dd3fc9a-0424-46e5-b795-e707313d08a7"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9271), "Dog" },
                    { new Guid("34af1337-fc8b-4e29-8415-2606fbeda0f8"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9237), "Dog" },
                    { new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9235), "Horse" },
                    { new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9230), "Cat" },
                    { new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9280), "Hamster" },
                    { new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9283), "Rabbit" }
                });

            migrationBuilder.InsertData(
                table: "Traits",
                columns: new[] { "Id", "DateOfRegistration", "Name" },
                values: new object[,]
                {
                    { new Guid("004b50af-cfbc-486f-a030-46bf36d4e62d"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9088), "afraid" },
                    { new Guid("19011554-1b19-4f83-a76a-b2355790e78b"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9103), "quiet" },
                    { new Guid("1e877278-d960-441b-a948-f5daf2eef49b"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9108), "cheerful" },
                    { new Guid("1f642298-3c46-4f91-9e19-5bb32ba4daae"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9101), "friendly" },
                    { new Guid("3c29a377-0a27-48f5-8c24-8e38b12d62a6"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9110), "nervous" },
                    { new Guid("5c7d6607-83dd-4195-87bb-49189ff0f5fe"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9120), "trustworthy" },
                    { new Guid("6fdda566-38d3-472f-ad74-f4f72a6c9bf8"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9117), "silly" },
                    { new Guid("87d93f4b-3ff8-4ae2-a46e-e382b96241bc"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9106), "clumsy" },
                    { new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9085), "lazy" },
                    { new Guid("91a38df8-4a4e-4c95-9881-bb303756b6f7"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9112), "gentle" },
                    { new Guid("9f496fc8-f0a3-4fbc-ba3c-4b5ad6b1f5f9"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9081), "active" },
                    { new Guid("bacb50bd-f61b-4508-a550-783c6fd927ab"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9093), "loving" },
                    { new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9119), "intelligent" },
                    { new Guid("ca85fb70-39f2-4cba-b321-1413fd2f365f"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9089), "loud" },
                    { new Guid("d089f6ba-dd18-4243-93b5-186a3f9159ed"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9116), "spoiled" },
                    { new Guid("e3668814-9cad-43d6-9b01-68c3fd7d4f6e"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9104), "calm" },
                    { new Guid("e4d8ef07-7c3c-4806-aed1-64cbe940b603"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9098), "shy" },
                    { new Guid("e9ce39fd-fbbe-478b-97f4-c9226b3abf44"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9113), "smart" },
                    { new Guid("ec621f95-910e-4586-9303-0c73ef593ad9"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9097), "brave" },
                    { new Guid("fcea3830-4848-4bfa-a262-40e31f72f4f9"), new DateTime(2023, 12, 19, 16, 0, 27, 454, DateTimeKind.Utc).AddTicks(9095), "loyal" }
                });

            migrationBuilder.InsertData(
                table: "OwnerAddress",
                columns: new[] { "Id", "City", "Country", "DateOfRegistration", "District", "OwnerId", "PostalCode", "Street" },
                values: new object[,]
                {
                    { new Guid("0380431f-2a91-483f-91b7-58c5bc695343"), "Brno", "Poland", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(5460), "Wrzeszcz", new Guid("e1e88552-80ea-490f-9fa3-d2126e702d92"), "80-251", "8c070c3f-3be2-4003-96e0-c62614844724" },
                    { new Guid("0779dc2c-e788-448e-ad4e-30410631451d"), "Madrid", "Italy", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7291), "Oliwa", new Guid("e7d6bac8-737d-4612-9851-384e010d308b"), "80-398", "acb89da6-0282-4a6e-8ba3-dde27ab2d9a4" },
                    { new Guid("0f74d154-70bc-407a-a4e4-d080c0f97342"), "Krakow", "Poland", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(6733), "Wrzeszcz", new Guid("fd35871d-6417-4c3b-8d59-b64295462b6f"), "80-251", "b1616a50-2f08-493c-83ff-1ffb1b4e1ac1" },
                    { new Guid("10001f42-732d-433c-a98a-c4a0c0b9c1e0"), "Gdansk", "Italy", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(4433), "Oliwa", new Guid("cab93e0a-478b-47cc-83cc-4033f19d1cb6"), "80-398", "64679574-5389-4f90-9c10-b8a56e872a54" },
                    { new Guid("16645769-e96c-4dce-af81-b3ef6772443c"), "Prague", "Poland", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(6241), "Oliwa", new Guid("c04d44f6-7f68-499e-9d16-c802a7241374"), "80-398", "7dd3e2b2-1b58-4603-94e7-d6afe456e5b7" },
                    { new Guid("1893cd94-802a-44ce-8a46-496d02fa42e2"), "Krakow", "Italy", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(5892), "Brooklyn", new Guid("63e0f957-9491-4fba-9021-433d299d371a"), "65-154", "d74355cb-1bba-4bbe-941c-e121bec8c0fd" },
                    { new Guid("21c1ada9-3edc-4721-8f09-4b07cb616136"), "Brno", "Poland", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7463), "Wrzeszcz", new Guid("ef2ac790-932e-4046-baf4-7455988ba402"), "80-251", "7800bc0e-84d0-470f-938a-5fa09e3d9f9d" },
                    { new Guid("30cabea5-162b-4194-9ac4-3f876e14c397"), "Warsaw", "Czech Republic", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(6139), "Starówka", new Guid("06e68c47-2908-48fb-bf0a-d577ed1fb737"), "80-21", "f353a57b-70a9-4d61-92b5-e2de971c40bf" },
                    { new Guid("35d04b42-eb8d-4816-b339-8280f3372c1e"), "Prague", "Italy", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7184), "Oliwa", new Guid("2bd4e8e5-f655-4967-af56-0f289907f4fb"), "80-398", "8e5c21dd-99ec-4149-b04e-4ed87e5442c0" },
                    { new Guid("3e07e2fc-bfc1-434f-9f2a-232814ea4662"), "Brno", "Italy", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(4608), "Oliwa", new Guid("e7931cdc-005c-4788-8286-ffe776b56e9e"), "80-398", "69ac698e-56cd-48d9-acc6-8bc70aa0dd99" },
                    { new Guid("3ed8f065-d3dc-453b-8056-bb112dd2d3c6"), "London", "Poland", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(3672), "Orunia", new Guid("860b86b6-d9c7-43ea-9b0c-502cf264f6aa"), "80-59", "311cd7bf-88a5-42a9-a84c-52b4e03e207f" },
                    { new Guid("408443b9-295a-4a2d-a40f-c604cdf35699"), "Warsaw", "Italy", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(4357), "Orunia", new Guid("dc96388f-474d-4b07-ada6-571ab51cb1ad"), "80-59", "d2b318e8-62db-441e-b60e-d07d59314e2e" },
                    { new Guid("4782b564-c927-4b9d-b296-3dc12c58e7b7"), "Slupsk", "UK", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(3293), "Starówka", new Guid("6ed9a22b-43b3-44aa-acd5-1afde26c3886"), "80-21", "7a694765-48ec-47b8-8273-035942e3cfd8" },
                    { new Guid("4c33fc7d-6438-4d47-b3ce-5ab4900e2273"), "London", "Poland", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(5032), "Brooklyn", new Guid("c98319ae-1264-4d91-a2a6-80df6f0ccf65"), "65-154", "a09021d6-1591-495d-b05a-89d03bf48144" },
                    { new Guid("4caaf810-a45e-4e5e-8fc5-5fe49c6ccb12"), "Prague", "Poland", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(5990), "Orunia", new Guid("8f591412-f075-4143-b5a0-14a74d29ff10"), "80-59", "721ddf5c-f9cb-470f-b14b-9d133dbeda0d" },
                    { new Guid("4d26db57-d47a-4d2e-8785-a63bd60e3740"), "Warsaw", "UK", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(5718), "Brooklyn", new Guid("baf1a844-c5ee-48c0-86e7-be46490fc54d"), "65-154", "6586233d-b9f3-4046-90fb-bdd33a4a8311" },
                    { new Guid("50a4618a-7133-479f-ac4f-919ed23a3fc8"), "Slupsk", "Italy", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(5105), "Wrzeszcz", new Guid("3c5ded76-1b8c-4a08-87d3-9e9704b0fb4b"), "80-251", "635f69ac-56ee-494a-9f8f-3c481a787a41" },
                    { new Guid("54c14ee7-73f3-44d3-bdf3-99127d10923e"), "Prague", "UK", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7364), "Orunia", new Guid("79e350e7-a868-4361-8c1c-9c553fd8e805"), "80-59", "541eceae-f575-4fb1-ac9d-3dafce21adaf" },
                    { new Guid("5c1d5af8-8a7b-44e2-8a6e-31f2bc8244e3"), "Gdansk", "Czech Republic", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(5817), "Starówka", new Guid("fc0c907a-78b4-4738-a34c-e7779923eb69"), "80-21", "59568955-0390-4ba7-8653-8308eeba3609" },
                    { new Guid("5c337906-c071-48a9-8170-9302de4ac395"), "London", "Czech Republic", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(4532), "Wrzeszcz", new Guid("c186dfd8-8518-418b-9291-7b4839e64ee6"), "80-251", "f7814a1e-2c43-471e-91c5-fd5d02f033e1" },
                    { new Guid("70561884-e744-435e-8305-27d13481533b"), "Gdansk", "UK", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7711), "Wrzeszcz", new Guid("a696d93f-c9f9-4cda-ac14-1159c1c8fd8c"), "80-251", "cf859bc0-01c0-4460-a570-694a2b261628" },
                    { new Guid("708f08ec-90f1-4c67-b5e3-5ae3c267f28d"), "Warsaw", "Czech Republic", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(4856), "Starówka", new Guid("172645b5-42b9-4e09-8389-47fb6554c609"), "80-21", "4d296d2f-ed9a-41b9-83a6-be24a3621df0" },
                    { new Guid("745c84fb-fd6c-495e-9cc8-33dde25fffee"), "Slupsk", "Czech Republic", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(3800), "Oliwa", new Guid("271353d9-7fed-42c4-8112-12638f7932a7"), "80-398", "9ac16f18-87ff-4ebd-9051-7b35fe44da8c" },
                    { new Guid("7516ba1b-d3d6-4a56-bb4d-6600be49ad2b"), "London", "Italy", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(3488), "Orunia", new Guid("836375a0-81eb-4c40-b3b1-5e3960cdfe98"), "80-59", "643d7d55-219e-4e19-a973-9640ef6361af" },
                    { new Guid("77b10aae-d613-42c2-b4fc-f0c10e7ed5c1"), "Krakow", "Italy", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(5278), "Orunia", new Guid("6f87b266-78a9-49b4-87b3-a4657e1975cb"), "80-59", "3f7248cc-7fff-40eb-a293-29366adbdd86" },
                    { new Guid("791ec2de-aa54-4b90-8b17-dadf2852c42c"), "Madrid", "Poland", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(4955), "Oliwa", new Guid("9561bf0b-8913-4c21-826b-38dbfb7d0b06"), "80-398", "6f21271d-9399-4e66-8027-00da50d98714" },
                    { new Guid("7c27d8fa-4ab2-43e9-b904-0957496ab8d5"), "Prague", "Czech Republic", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(6940), "Brooklyn", new Guid("7de5f8a6-11a7-4e61-8877-0133c99c012c"), "65-154", "ccc76c3d-98fc-4e26-884c-3395d2eab8eb" },
                    { new Guid("7fa38886-02eb-4aab-9321-0476122ede78"), "Gdansk", "Italy", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(6866), "Starówka", new Guid("dc8e1994-a4b3-440b-80e5-544385a4de86"), "80-21", "2f46735b-b9e0-4016-a7dd-01a52983cf1f" },
                    { new Guid("7fb5d896-972f-435a-8ade-1f3fd3519ab3"), "Gdansk", "UK", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(4185), "Orunia", new Guid("e3608426-7318-48f3-9b76-3876d685a77e"), "80-59", "4a2aa1f0-c08d-4bf9-a6a3-076b94f32f3d" },
                    { new Guid("8ac0132f-35f5-4cb1-8f42-b07f3e22d226"), "Brno", "UK", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(4682), "Wrzeszcz", new Guid("ed45e958-9bd1-402e-8ace-9765cbc310f4"), "80-251", "961ebece-c075-483b-9c9f-df4853f9877a" },
                    { new Guid("8ce399e6-4161-4784-ad51-a86e9cab4098"), "Rome", "Italy", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(6660), "Orunia", new Guid("e0af56ce-4435-4dd6-9768-19888f0d3089"), "80-59", "843b6e44-27a2-4b0b-b09a-f4d1b99c56f9" },
                    { new Guid("9cdf97f3-56a3-41bf-9c7c-57e042d66b38"), "Krakow", "Italy", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(5644), "Orunia", new Guid("4f2457d8-73e3-4e44-81aa-2cc1c33b975c"), "80-59", "216b14bd-24ef-480e-9bdd-cc83eaa086d6" },
                    { new Guid("a32acd3e-a011-444e-a766-86be60cd5757"), "Madrid", "UK", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(5537), "Wrzeszcz", new Guid("333da5b9-dbc7-403f-86e7-389868bc2a57"), "80-251", "0fd45357-add4-4867-b1a9-15b4c9136d6f" },
                    { new Guid("a363627e-7c47-4e5a-b1ce-a651844b377b"), "Madrid", "UK", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(4782), "Oliwa", new Guid("f7206678-9038-464e-982e-52853d8ae1c1"), "80-398", "5a146e35-4742-4ba5-961e-c264adb2b8ed" },
                    { new Guid("aabbf190-687b-4922-bac4-50a0e03b901c"), "Brno", "Italy", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(4259), "Orunia", new Guid("cfaf4f24-4dd0-407e-9dbe-d2edbcd678d9"), "80-59", "f9dcd057-b176-4cbe-bf8f-714ed5c5ffe8" },
                    { new Guid("ae276a81-79c3-42a5-8f69-56f161ed303b"), "Gdansk", "Czech Republic", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(6065), "Starówka", new Guid("37472e61-1113-405f-a380-dc3ce041e71a"), "80-21", "72617ce0-cb3f-4eba-85ef-7e8d8be44f78" },
                    { new Guid("b28b1c7b-f21d-49cf-854c-a0d1ebc3bad1"), "Madrid", "Czech Republic", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(3597), "Wrzeszcz", new Guid("ed46dfad-4785-4421-ae34-a7da86620b68"), "80-251", "73116fc0-8428-4167-8a64-197a58b8414d" },
                    { new Guid("b9f5d586-6189-46ef-9fc7-353a5989ca44"), "Prague", "Italy", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(4011), "Oliwa", new Guid("c242bb15-83f6-4320-95f1-4b8d8df06e16"), "80-398", "f565712b-19d8-4fa2-b144-5523e31a56f7" },
                    { new Guid("bcd7c317-9df4-46ae-8799-943c2b9a1f0b"), "Prague", "UK", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(6415), "Brooklyn", new Guid("5cdf3890-7422-4c7e-aba6-9a729038d9e5"), "65-154", "d8862c79-4b50-4f96-a7a9-b5ecb7c69c2b" },
                    { new Guid("bce9ff49-d081-484a-a9f0-672e0649294b"), "Brno", "UK", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(5205), "Wrzeszcz", new Guid("1d4c7423-bea7-4dc9-bb7f-54c662d8f264"), "80-251", "64daa322-15a6-4712-9464-de86a4b86abb" },
                    { new Guid("bd6d10b3-7674-4e92-b182-06cd270d02d9"), "Rome", "Italy", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(6562), "Orunia", new Guid("8290dbfd-c402-40f6-9768-8d42108ecce3"), "80-59", "91bac5e9-8ea1-42a0-af13-f17299b2f669" },
                    { new Guid("bfd87b71-6c76-4ab3-9a19-482497cf213e"), "Madrid", "Poland", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7611), "Starówka", new Guid("0f540469-bae4-4631-98ea-71a5588dffb6"), "80-21", "7219ceda-9cb8-4bef-9575-93758b8494ff" },
                    { new Guid("c94f8b83-9fed-44a8-bcfc-fae4962dbe6b"), "Madrid", "Italy", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(5387), "Orunia", new Guid("5a5b5d0a-bd5c-45ea-8173-c9c4645eb77c"), "80-59", "4cd04d6c-4e13-4e6d-99a7-26fd4ed71860" },
                    { new Guid("d30ef5f2-1feb-415a-abf2-f426786558c8"), "Prague", "UK", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7111), "Oliwa", new Guid("d0538a29-4480-4a49-8ae9-ae702851af56"), "80-398", "3ddff365-f1c4-4ff2-9689-553d672eb31b" },
                    { new Guid("d91f3765-4e55-4043-9e1a-eb5bdf5bb676"), "Rome", "Czech Republic", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7536), "Wrzeszcz", new Guid("c388d447-ae5e-4a9d-8af7-7130829f4e6a"), "80-251", "f39480b5-be54-4497-a7d5-aea29cb9b14d" },
                    { new Guid("e0afa3a2-43a9-48ac-a3ae-dbf0a1e5c33b"), "London", "UK", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(3936), "Oliwa", new Guid("eea8313f-0781-46e7-b259-3606a6980029"), "80-398", "e54b7bbe-350e-43a9-afa9-9de8c8fc84bf" },
                    { new Guid("e16ea041-19ac-45b0-85bb-ab7608968f3f"), "Madrid", "Italy", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(6315), "Brooklyn", new Guid("8d462759-0ec9-42ea-bfb8-ed9985d32c74"), "65-154", "5902a5f4-305a-4a83-a0c3-7954f98b2196" },
                    { new Guid("ea560724-c5c6-4629-b825-65c7584336f4"), "Rome", "Italy", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(4085), "Oliwa", new Guid("d16faf31-4569-4193-989f-8620266ebf15"), "80-398", "e16c0ef3-d216-4c87-ac4e-62d39d7aa16d" },
                    { new Guid("ec68be28-0fcb-4312-864f-23e492c99157"), "Krakow", "UK", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(6488), "Wrzeszcz", new Guid("224eb59e-272a-4585-a664-02c09fbc30c7"), "80-251", "3513f2ec-0810-4185-a064-94039b735379" },
                    { new Guid("f19261b6-9453-4bac-879b-3aab7e369759"), "Warsaw", "Poland", new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7035), "Wrzeszcz", new Guid("40ccfd95-ca26-4908-805c-27c31995ead7"), "80-251", "cc8e893e-b11f-4205-bb23-019f314759eb" }
                });

            migrationBuilder.InsertData(
                table: "OwnerBlackLists",
                columns: new[] { "Id", "OwnerId", "PetTypeId" },
                values: new object[,]
                {
                    { new Guid("1a7d9427-7fa8-41b3-9684-f3ddbd9546cb"), new Guid("eea8313f-0781-46e7-b259-3606a6980029"), new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c") },
                    { new Guid("4c9c977d-fbe6-4690-9fce-8b2a1076666b"), new Guid("d16faf31-4569-4193-989f-8620266ebf15"), new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763") },
                    { new Guid("629b880e-aa6d-4282-87f2-16f74e966591"), new Guid("c98319ae-1264-4d91-a2a6-80df6f0ccf65"), new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763") },
                    { new Guid("63c172cd-a108-43c9-b452-fd2597dd75e9"), new Guid("e1e88552-80ea-490f-9fa3-d2126e702d92"), new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a") },
                    { new Guid("64cbb4cc-5049-4b4d-ba9d-4b0e6a12d1cf"), new Guid("860b86b6-d9c7-43ea-9b0c-502cf264f6aa"), new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a") },
                    { new Guid("698c9b69-a847-4ac2-af0a-ffd9fdbcf70d"), new Guid("271353d9-7fed-42c4-8112-12638f7932a7"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("6ed77ec7-d61a-4aa5-9a99-2212d3ffabb8"), new Guid("e3608426-7318-48f3-9b76-3876d685a77e"), new Guid("2dd3fc9a-0424-46e5-b795-e707313d08a7") },
                    { new Guid("7a947ce7-f90b-4a98-8c48-f59ebf64ad6a"), new Guid("cfaf4f24-4dd0-407e-9dbe-d2edbcd678d9"), new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a") },
                    { new Guid("7bf13508-b247-48e3-9b3b-672a87d6daaf"), new Guid("f7206678-9038-464e-982e-52853d8ae1c1"), new Guid("34af1337-fc8b-4e29-8415-2606fbeda0f8") },
                    { new Guid("7d809aa3-da05-4d46-ae82-7a4916723143"), new Guid("dc96388f-474d-4b07-ada6-571ab51cb1ad"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("8042f4cc-3bec-4357-88ec-515f303df842"), new Guid("5a5b5d0a-bd5c-45ea-8173-c9c4645eb77c"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("9263c3a3-416e-404e-93d2-fd0f0cb1f302"), new Guid("1d4c7423-bea7-4dc9-bb7f-54c662d8f264"), new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c") },
                    { new Guid("95564f49-8bd3-4438-beff-bc1a303eb7be"), new Guid("333da5b9-dbc7-403f-86e7-389868bc2a57"), new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763") },
                    { new Guid("96be0a85-0ee5-43d0-9fb5-c3a6a5943190"), new Guid("cab93e0a-478b-47cc-83cc-4033f19d1cb6"), new Guid("0d374c06-008e-4cbe-bbe4-6f385b7725e5") },
                    { new Guid("a01171d2-30e7-41b2-bf3c-bd66612b9ad5"), new Guid("172645b5-42b9-4e09-8389-47fb6554c609"), new Guid("0d374c06-008e-4cbe-bbe4-6f385b7725e5") },
                    { new Guid("a172ddf4-68af-4a3c-b91a-3c0c9d071357"), new Guid("c242bb15-83f6-4320-95f1-4b8d8df06e16"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("a33ab54c-6ea0-4dcc-a59c-9c05cfcbefc0"), new Guid("ed46dfad-4785-4421-ae34-a7da86620b68"), new Guid("0d374c06-008e-4cbe-bbe4-6f385b7725e5") },
                    { new Guid("a6d7c560-887c-4171-8b2e-d06e6445a459"), new Guid("6ed9a22b-43b3-44aa-acd5-1afde26c3886"), new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c") },
                    { new Guid("c83e76a1-eae2-45e4-b2c5-aeca90b69ef1"), new Guid("c186dfd8-8518-418b-9291-7b4839e64ee6"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("dc67b72a-4997-47fb-8aa0-2f7178b11bdc"), new Guid("6f87b266-78a9-49b4-87b3-a4657e1975cb"), new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a") },
                    { new Guid("e671bc41-ef69-4da8-a19b-af42b26b78cf"), new Guid("ed45e958-9bd1-402e-8ace-9765cbc310f4"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("eb8ebb20-2970-4bb4-9449-c868933a63eb"), new Guid("e7931cdc-005c-4788-8286-ffe776b56e9e"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("efa4dd4b-ae6c-40ad-9ee6-9b0c3471e7e0"), new Guid("836375a0-81eb-4c40-b3b1-5e3960cdfe98"), new Guid("0d374c06-008e-4cbe-bbe4-6f385b7725e5") },
                    { new Guid("f47f683f-26d4-4cfa-8aa5-3dc7663ed691"), new Guid("3c5ded76-1b8c-4a08-87d3-9e9704b0fb4b"), new Guid("2dd3fc9a-0424-46e5-b795-e707313d08a7") },
                    { new Guid("f564fbd7-7809-4ae8-81ce-9e88f2364f63"), new Guid("9561bf0b-8913-4c21-826b-38dbfb7d0b06"), new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c") }
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "DateOfBirth", "DateOfRegistration", "Gender", "Name", "OwnerId", "PetTypeId" },
                values: new object[,]
                {
                    { new Guid("0096365a-4330-4ba1-90cc-882ec5fd2983"), new DateTime(2017, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8215), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8214), 0, "ALACA", new Guid("eea8313f-0781-46e7-b259-3606a6980029"), new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c") },
                    { new Guid("070ce240-1ffe-40c6-9e33-f583aa6996ef"), new DateTime(2017, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8718), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8717), 0, "BROWNEY", new Guid("dc8e1994-a4b3-440b-80e5-544385a4de86"), new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a") },
                    { new Guid("07f5584c-6ff3-4720-939e-7f6077381eea"), new DateTime(2018, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8286), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8285), 0, "ALACA", new Guid("c388d447-ae5e-4a9d-8af7-7130829f4e6a"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("082bc7b3-5ea9-4e9c-8426-e079479d13cc"), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8115), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8114), 0, "BOOZER", new Guid("172645b5-42b9-4e09-8389-47fb6554c609"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("08b80e81-7a41-4d17-adbd-b2743dbf32c9"), new DateTime(2020, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8683), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8682), 0, "LUPO", new Guid("e0af56ce-4435-4dd6-9768-19888f0d3089"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("0c187efc-747b-42c6-8335-5c92d5babcb3"), new DateTime(2019, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8258), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8257), 0, "CHUEY", new Guid("40ccfd95-ca26-4908-805c-27c31995ead7"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("0d042a50-bcb2-4780-ab3e-adf232e3e7cf"), new DateTime(2022, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8100), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8099), 0, "LUPO", new Guid("333da5b9-dbc7-403f-86e7-389868bc2a57"), new Guid("2dd3fc9a-0424-46e5-b795-e707313d08a7") },
                    { new Guid("0daed55c-208b-4c81-9b27-0b422763f629"), new DateTime(2022, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8351), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8350), 0, "MAYA", new Guid("e7d6bac8-737d-4612-9851-384e010d308b"), new Guid("34af1337-fc8b-4e29-8415-2606fbeda0f8") },
                    { new Guid("0e60231b-8bf2-47b7-9119-262bfec4a1fe"), new DateTime(2014, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8128), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8128), 0, "FLOKEY", new Guid("dc8e1994-a4b3-440b-80e5-544385a4de86"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("109684b8-4a63-44c6-a669-a84ce1636701"), new DateTime(2021, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8379), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8378), 0, "BROWNEY", new Guid("5cdf3890-7422-4c7e-aba6-9a729038d9e5"), new Guid("0d374c06-008e-4cbe-bbe4-6f385b7725e5") },
                    { new Guid("11819aa5-5e78-4ca5-9ce3-d968769fdc62"), new DateTime(2019, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8559), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8558), 0, "JUANBOBO", new Guid("d0538a29-4480-4a49-8ae9-ae702851af56"), new Guid("0d374c06-008e-4cbe-bbe4-6f385b7725e5") },
                    { new Guid("11cb8fb1-b388-4f48-ad8a-101ccfd652ca"), new DateTime(2015, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8021), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8020), 0, "ALACA", new Guid("dc8e1994-a4b3-440b-80e5-544385a4de86"), new Guid("34af1337-fc8b-4e29-8415-2606fbeda0f8") },
                    { new Guid("1219825a-1bf7-4b22-b096-32f72011e207"), new DateTime(2017, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7980), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7979), 0, "MAYA", new Guid("271353d9-7fed-42c4-8112-12638f7932a7"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("1348d155-aaca-4cf0-a7f7-bc20023cf6fe"), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7966), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7965), 0, "CHUEY", new Guid("172645b5-42b9-4e09-8389-47fb6554c609"), new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c") },
                    { new Guid("1786885f-22a9-49dc-911e-64e2c9259b39"), new DateTime(2017, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8386), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8385), 0, "BLAZ", new Guid("dc8e1994-a4b3-440b-80e5-544385a4de86"), new Guid("2dd3fc9a-0424-46e5-b795-e707313d08a7") },
                    { new Guid("1c40e4ee-4a7e-448e-93bf-9af5917bbabe"), new DateTime(2019, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8078), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8078), 0, "SABASTEIN", new Guid("dc96388f-474d-4b07-ada6-571ab51cb1ad"), new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a") },
                    { new Guid("1c65186e-2ac9-407c-9ecc-5c19adf14971"), new DateTime(2018, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8271), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8271), 0, "FLOKEY", new Guid("63e0f957-9491-4fba-9021-433d299d371a"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("1fcab780-7679-4d4c-bcd1-7e1d0f378ed5"), new DateTime(2021, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8704), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8703), 0, "BOOZER", new Guid("224eb59e-272a-4585-a664-02c09fbc30c7"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("22b386a2-71f5-4e91-9b55-879449b93fa3"), new DateTime(2017, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8552), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8552), 0, "KLUSIA", new Guid("860b86b6-d9c7-43ea-9b0c-502cf264f6aa"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("27b9f3bf-9a47-4c12-b743-4d9d95bfca40"), new DateTime(2014, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8440), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8439), 0, "MAYA", new Guid("1d4c7423-bea7-4dc9-bb7f-54c662d8f264"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("2a62e954-cdf9-4460-9b53-9e85591b3912"), new DateTime(2019, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8135), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8134), 0, "TWIGA", new Guid("dc96388f-474d-4b07-ada6-571ab51cb1ad"), new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c") },
                    { new Guid("2eb17d89-cc1b-4e15-856b-aa611d7d7561"), new DateTime(2015, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8634), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8633), 0, "CHUEY", new Guid("836375a0-81eb-4c40-b3b1-5e3960cdfe98"), new Guid("34af1337-fc8b-4e29-8415-2606fbeda0f8") },
                    { new Guid("2fbeccd8-5105-4153-b7a5-f1e92128e9a8"), new DateTime(2017, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8545), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8545), 0, "TAIFA", new Guid("271353d9-7fed-42c4-8112-12638f7932a7"), new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a") },
                    { new Guid("3118878f-3520-4c39-af9f-e22246946d1b"), new DateTime(2022, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7973), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7972), 0, "BOOZER", new Guid("c242bb15-83f6-4320-95f1-4b8d8df06e16"), new Guid("2dd3fc9a-0424-46e5-b795-e707313d08a7") },
                    { new Guid("36be2138-3096-4e06-9e21-6c75238e1a1d"), new DateTime(2016, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8749), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8748), 0, "WALTER", new Guid("0f540469-bae4-4631-98ea-71a5588dffb6"), new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c") },
                    { new Guid("38d16719-d19c-4945-8d09-a9165c19d568"), new DateTime(2017, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8755), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8755), 0, "LUPO", new Guid("9561bf0b-8913-4c21-826b-38dbfb7d0b06"), new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763") },
                    { new Guid("38e4e090-4918-42d4-9341-f5b6e540a4ec"), new DateTime(2020, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8236), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8235), 0, "MIKE", new Guid("dc96388f-474d-4b07-ada6-571ab51cb1ad"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("3ddce316-dc79-4a01-af69-ee9d11e460b0"), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8000), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7999), 0, "MIKE", new Guid("224eb59e-272a-4585-a664-02c09fbc30c7"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("3ff43ae2-ffd9-4b24-acdd-471ebb5101be"), new DateTime(2016, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8620), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8619), 0, "UFEK", new Guid("dc8e1994-a4b3-440b-80e5-544385a4de86"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("42bb3c76-fdc7-4764-b425-eded5c7ec7a5"), new DateTime(2020, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8777), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8777), 0, "LUCKIE", new Guid("c242bb15-83f6-4320-95f1-4b8d8df06e16"), new Guid("0d374c06-008e-4cbe-bbe4-6f385b7725e5") },
                    { new Guid("43446cbb-25eb-4369-a206-1164474484d9"), new DateTime(2014, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8483), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8482), 0, "BROWNEY", new Guid("d0538a29-4480-4a49-8ae9-ae702851af56"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("44610089-2493-4587-a13d-b10e6db6ac91"), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8280), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8279), 0, "TWIGA", new Guid("f7206678-9038-464e-982e-52853d8ae1c1"), new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763") },
                    { new Guid("47facc0d-5935-4749-81a4-79b1961f6de9"), new DateTime(2020, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8335), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8334), 0, "FREEDOOM", new Guid("860b86b6-d9c7-43ea-9b0c-502cf264f6aa"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("4cd32d47-f0e3-4510-a9a9-02be7d63a663"), new DateTime(2022, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8065), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8064), 0, "BROWNEY", new Guid("fc0c907a-78b4-4738-a34c-e7779923eb69"), new Guid("2dd3fc9a-0424-46e5-b795-e707313d08a7") },
                    { new Guid("4d30f7f2-6ab0-45de-8d02-38654ef1b2af"), new DateTime(2022, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8392), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8391), 0, "RUBY", new Guid("8290dbfd-c402-40f6-9768-8d42108ecce3"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("51b09774-5c33-419b-ab50-eb348502b5b5"), new DateTime(2022, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8072), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8071), 0, "MIKE", new Guid("e7931cdc-005c-4788-8286-ffe776b56e9e"), new Guid("2dd3fc9a-0424-46e5-b795-e707313d08a7") },
                    { new Guid("53d7a21f-05f4-4bda-8058-693923dca93c"), new DateTime(2014, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8662), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8661), 0, "TAIFA", new Guid("3c5ded76-1b8c-4a08-87d3-9e9704b0fb4b"), new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a") },
                    { new Guid("543bf592-149d-4f0d-abd1-35fcfc25e18b"), new DateTime(2020, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7938), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7937), 0, "ALACA", new Guid("ed45e958-9bd1-402e-8ace-9765cbc310f4"), new Guid("34af1337-fc8b-4e29-8415-2606fbeda0f8") },
                    { new Guid("550ab457-54d2-44a4-8978-af3f9e97b906"), new DateTime(2014, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8406), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8406), 0, "LUPO", new Guid("c98319ae-1264-4d91-a2a6-80df6f0ccf65"), new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a") },
                    { new Guid("5981392d-cdf1-42d5-be5a-6b129e53efed"), new DateTime(2021, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8573), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8572), 0, "MANDO", new Guid("c04d44f6-7f68-499e-9d16-c802a7241374"), new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a") },
                    { new Guid("5b8e4ee6-644b-4405-baf2-7228c014bfbd"), new DateTime(2021, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8143), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8142), 0, "TWIGA", new Guid("860b86b6-d9c7-43ea-9b0c-502cf264f6aa"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("62d512f3-dc02-4ec5-b48f-6d0da7d736f9"), new DateTime(2016, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8538), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8538), 0, "MAYA", new Guid("3c5ded76-1b8c-4a08-87d3-9e9704b0fb4b"), new Guid("0d374c06-008e-4cbe-bbe4-6f385b7725e5") },
                    { new Guid("667b77c4-6299-4d6a-8038-03c8a1d88d49"), new DateTime(2016, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8008), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8007), 0, "FLOKEY", new Guid("c98319ae-1264-4d91-a2a6-80df6f0ccf65"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("6691a6c5-9e60-4aaa-9185-3bb1d2ecf762"), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7953), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7952), 0, "BOOZER", new Guid("d16faf31-4569-4193-989f-8620266ebf15"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("6c95a987-a5b0-4743-a7aa-e09e5f3aefa8"), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8628), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8627), 0, "FLOKEY", new Guid("dc8e1994-a4b3-440b-80e5-544385a4de86"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("6d669948-f5b5-4892-a0b8-a680591ddf4c"), new DateTime(2020, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8764), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8763), 0, "FREEDOOM", new Guid("e7d6bac8-737d-4612-9851-384e010d308b"), new Guid("2dd3fc9a-0424-46e5-b795-e707313d08a7") },
                    { new Guid("70556cfa-8f85-444c-b14d-6d3d0560f9f1"), new DateTime(2014, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7987), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7986), 0, "FLOKEY", new Guid("860b86b6-d9c7-43ea-9b0c-502cf264f6aa"), new Guid("34af1337-fc8b-4e29-8415-2606fbeda0f8") },
                    { new Guid("724838c7-91ba-4944-93fe-736a6694a34d"), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8771), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8770), 0, "FLOKEY", new Guid("836375a0-81eb-4c40-b3b1-5e3960cdfe98"), new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763") },
                    { new Guid("74af42fd-5c4c-496f-8579-d08c65bfb595"), new DateTime(2016, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8014), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8014), 0, "LUPO", new Guid("c388d447-ae5e-4a9d-8af7-7130829f4e6a"), new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763") },
                    { new Guid("796140a3-84b7-45f7-96b0-049a78996f52"), new DateTime(2021, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8371), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8370), 0, "CASABA", new Guid("fd35871d-6417-4c3b-8d59-b64295462b6f"), new Guid("2dd3fc9a-0424-46e5-b795-e707313d08a7") },
                    { new Guid("7ac1e919-3d07-4223-8a95-8826bd5b7396"), new DateTime(2015, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8265), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8264), 0, "ALACA", new Guid("e1e88552-80ea-490f-9fa3-d2126e702d92"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("7d87dded-e930-4d38-86f2-e85d07854116"), new DateTime(2016, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8364), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8363), 0, "WALTER", new Guid("e7d6bac8-737d-4612-9851-384e010d308b"), new Guid("2dd3fc9a-0424-46e5-b795-e707313d08a7") },
                    { new Guid("81a1f67d-362e-4498-af82-511fae47f397"), new DateTime(2014, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8413), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8412), 0, "LUCKIE", new Guid("dc8e1994-a4b3-440b-80e5-544385a4de86"), new Guid("0d374c06-008e-4cbe-bbe4-6f385b7725e5") },
                    { new Guid("81a80af5-a1df-4d3a-9973-161446038bb2"), new DateTime(2016, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8490), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8489), 0, "FLOKEY", new Guid("0f540469-bae4-4631-98ea-71a5588dffb6"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("88be7be6-91e9-44e0-9df7-153265e68630"), new DateTime(2015, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8647), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8647), 0, "FLOKEY", new Guid("224eb59e-272a-4585-a664-02c09fbc30c7"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("8cf7ac57-23e1-4f40-83a0-99bf90c6ea87"), new DateTime(2018, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7993), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7992), 0, "FREEDOOM", new Guid("6f87b266-78a9-49b4-87b3-a4657e1975cb"), new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763") },
                    { new Guid("8f36b6ca-e302-41ac-acdf-1ee00eee9bd7"), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8641), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8640), 0, "FLOKEY", new Guid("e0af56ce-4435-4dd6-9768-19888f0d3089"), new Guid("34af1337-fc8b-4e29-8415-2606fbeda0f8") },
                    { new Guid("926c8cb3-e594-4a8a-b2f2-7af1de3e98d9"), new DateTime(2017, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8433), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8433), 0, "TWIGA", new Guid("c04d44f6-7f68-499e-9d16-c802a7241374"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("95db66ed-a0fd-4648-867c-9b72fa10ece4"), new DateTime(2015, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7945), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7944), 0, "TWIGA", new Guid("63e0f957-9491-4fba-9021-433d299d371a"), new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c") },
                    { new Guid("980eb01d-472c-4525-8331-2936823ddd42"), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8122), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8121), 0, "LUPO", new Guid("7de5f8a6-11a7-4e61-8877-0133c99c012c"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("9b4a6ced-4884-479f-b2b4-e1894ffaf243"), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8202), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8201), 0, "MAYA", new Guid("5a5b5d0a-bd5c-45ea-8173-c9c4645eb77c"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("9e0d176c-2fa4-4691-a910-431d9dc35a2f"), new DateTime(2017, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8668), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8668), 0, "SABASTEIN", new Guid("fd35871d-6417-4c3b-8d59-b64295462b6f"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("a11030bb-5f6f-4728-8399-61bee3c112b1"), new DateTime(2017, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8195), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8194), 0, "ALACA", new Guid("eea8313f-0781-46e7-b259-3606a6980029"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("a476f5eb-91af-48df-8337-180435e42e79"), new DateTime(2017, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8399), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8398), 0, "ALACA", new Guid("eea8313f-0781-46e7-b259-3606a6980029"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("a49382d9-e348-46a4-9771-3a0ee5dba823"), new DateTime(2017, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8223), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8222), 0, "SABASTEIN", new Guid("0f540469-bae4-4631-98ea-71a5588dffb6"), new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c") },
                    { new Guid("a590fe7d-6ff7-4541-b8c9-9fbe0d31735a"), new DateTime(2019, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8518), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8517), 0, "JUANBOBO", new Guid("5cdf3890-7422-4c7e-aba6-9a729038d9e5"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("aa2acc11-63ba-49d9-ad9a-f07657b3a038"), new DateTime(2014, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7912), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7911), 1, "TWIGA", new Guid("271353d9-7fed-42c4-8112-12638f7932a7"), new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c") },
                    { new Guid("aabfacee-23f9-4810-b714-a0f76ab50c41"), new DateTime(2018, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8243), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8242), 0, "CASABA", new Guid("8290dbfd-c402-40f6-9768-8d42108ecce3"), new Guid("0d374c06-008e-4cbe-bbe4-6f385b7725e5") },
                    { new Guid("ab5262ae-973c-4850-9213-c56363b2fcfb"), new DateTime(2015, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8086), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8086), 0, "BROWNEY", new Guid("e7931cdc-005c-4788-8286-ffe776b56e9e"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("ac0e964e-6ed9-48c0-ab1b-0b3ca159f79c"), new DateTime(2014, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7959), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7959), 0, "TWIGA", new Guid("5a5b5d0a-bd5c-45ea-8173-c9c4645eb77c"), new Guid("34af1337-fc8b-4e29-8415-2606fbeda0f8") },
                    { new Guid("ada561f0-a5de-4ee5-a15f-aec4cf5abbbf"), new DateTime(2019, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8058), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8057), 0, "MAYA", new Guid("cfaf4f24-4dd0-407e-9dbe-d2edbcd678d9"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("ae5080fa-7392-4c23-bdf3-3b0a085ca0cb"), new DateTime(2022, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8469), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8468), 0, "SABASTEIN", new Guid("c04d44f6-7f68-499e-9d16-c802a7241374"), new Guid("34af1337-fc8b-4e29-8415-2606fbeda0f8") },
                    { new Guid("b2fc4f55-9987-4f53-b4ac-8dbb95273098"), new DateTime(2018, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8613), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8612), 0, "SABASTEIN", new Guid("ed45e958-9bd1-402e-8ace-9765cbc310f4"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("b4d3f58d-3a3c-4f99-88e1-03c7b7f07364"), new DateTime(2020, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8697), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8696), 0, "TWIGA", new Guid("8d462759-0ec9-42ea-bfb8-ed9985d32c74"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("b9301777-7afc-4f5a-824c-e5dbf2a1a063"), new DateTime(2015, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7923), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7922), 1, "BOOZER", new Guid("63e0f957-9491-4fba-9021-433d299d371a"), new Guid("34af1337-fc8b-4e29-8415-2606fbeda0f8") },
                    { new Guid("bd363546-2c17-455c-ba96-58c661341529"), new DateTime(2018, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8712), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8711), 0, "CASABA", new Guid("e7931cdc-005c-4788-8286-ffe776b56e9e"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("bf45df62-3235-430b-9da6-9127f6392f38"), new DateTime(2016, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8690), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8689), 0, "LUCKIE", new Guid("333da5b9-dbc7-403f-86e7-389868bc2a57"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("bf6de7a9-4bd5-48ff-9267-f9d043c8c691"), new DateTime(2017, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8426), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8425), 0, "CHUEY", new Guid("c186dfd8-8518-418b-9291-7b4839e64ee6"), new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a") },
                    { new Guid("d2d84f02-65c0-4876-92a8-6391467bfc9b"), new DateTime(2019, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8229), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8229), 0, "LUCKIE", new Guid("e1e88552-80ea-490f-9fa3-d2126e702d92"), new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c") },
                    { new Guid("d365c33c-03df-4a45-ae6a-34d00d59708d"), new DateTime(2021, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8208), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8207), 0, "BLAZ", new Guid("c186dfd8-8518-418b-9291-7b4839e64ee6"), new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c") },
                    { new Guid("d8137db2-aba4-4992-84aa-ad97e419acc1"), new DateTime(2014, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8050), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8049), 0, "CHUEY", new Guid("7de5f8a6-11a7-4e61-8877-0133c99c012c"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("d8f006e2-4190-45d3-88e3-807af1c70892"), new DateTime(2020, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8524), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8523), 0, "WALTER", new Guid("ed45e958-9bd1-402e-8ace-9765cbc310f4"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("d9054efa-4a3e-448b-b44c-dd47ca2a1868"), new DateTime(2021, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8420), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8419), 0, "FLOKEY", new Guid("37472e61-1113-405f-a380-dc3ce041e71a"), new Guid("2dd3fc9a-0424-46e5-b795-e707313d08a7") },
                    { new Guid("dae7bc3e-ef46-4ddf-a082-a22bda4093df"), new DateTime(2016, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8342), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8342), 0, "SABASTEIN", new Guid("3c5ded76-1b8c-4a08-87d3-9e9704b0fb4b"), new Guid("2dd3fc9a-0424-46e5-b795-e707313d08a7") },
                    { new Guid("de2275b3-75e1-4ac2-8dd9-517d03036f36"), new DateTime(2017, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8675), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8674), 0, "RUBY", new Guid("e3608426-7318-48f3-9b76-3876d685a77e"), new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763") },
                    { new Guid("de9bd874-d6b6-4af5-8dcb-bb697da278e0"), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8475), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8474), 0, "RUBY", new Guid("0f540469-bae4-4631-98ea-71a5588dffb6"), new Guid("0d374c06-008e-4cbe-bbe4-6f385b7725e5") },
                    { new Guid("df06aedf-6280-4aac-b9f8-db77fd0b5912"), new DateTime(2019, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7931), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(7930), 0, "JUANBOBO", new Guid("224eb59e-272a-4585-a664-02c09fbc30c7"), new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763") },
                    { new Guid("df299f5a-b161-4d03-9226-5c3a4a433ca9"), new DateTime(2017, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8107), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8106), 0, "ALACA", new Guid("e0af56ce-4435-4dd6-9768-19888f0d3089"), new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763") },
                    { new Guid("e7fafe10-a996-49a4-9ea1-31603948882f"), new DateTime(2016, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8149), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8149), 0, "ALACA", new Guid("1d4c7423-bea7-4dc9-bb7f-54c662d8f264"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("e887a287-85ca-4985-8217-c6785011a181"), new DateTime(2021, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8156), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8155), 0, "TAIFA", new Guid("ed46dfad-4785-4421-ae34-a7da86620b68"), new Guid("34af1337-fc8b-4e29-8415-2606fbeda0f8") },
                    { new Guid("e8d3d68a-4c06-4eee-9c5e-fe04575db022"), new DateTime(2021, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8187), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8186), 0, "RUBY", new Guid("dc96388f-474d-4b07-ada6-571ab51cb1ad"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("edc2a38c-a04f-4359-87b6-0a8d0e3c5945"), new DateTime(2018, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8511), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8510), 0, "BOOM", new Guid("8f591412-f075-4143-b5a0-14a74d29ff10"), new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c") },
                    { new Guid("ede53097-91d2-437e-9059-4e2df88aa044"), new DateTime(2020, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8357), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8356), 0, "BLAZ", new Guid("6f87b266-78a9-49b4-87b3-a4657e1975cb"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("f25a412f-fdf8-4b5d-9381-64f2452e39b9"), new DateTime(2022, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8531), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8530), 0, "MANDO", new Guid("e1e88552-80ea-490f-9fa3-d2126e702d92"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("f928e406-0d48-445f-afb7-44613d593491"), new DateTime(2020, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8655), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8654), 0, "JUANBOBO", new Guid("7de5f8a6-11a7-4e61-8877-0133c99c012c"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("f982354a-64b8-4627-b7b4-6248b76bd00c"), new DateTime(2018, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8093), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8092), 0, "FLOKEY", new Guid("e3608426-7318-48f3-9b76-3876d685a77e"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("fba2d8ac-f067-49c5-b80a-4c4c3baf659f"), new DateTime(2014, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8497), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8496), 0, "BOOM", new Guid("c186dfd8-8518-418b-9291-7b4839e64ee6"), new Guid("2dd3fc9a-0424-46e5-b795-e707313d08a7") },
                    { new Guid("fdf74e3d-c810-4daa-a199-05aebbe8783b"), new DateTime(2018, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8503), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8502), 0, "CHUEY", new Guid("ed46dfad-4785-4421-ae34-a7da86620b68"), new Guid("2dd3fc9a-0424-46e5-b795-e707313d08a7") },
                    { new Guid("fe9e0ddc-c142-42c1-833d-bbb0808ae00c"), new DateTime(2021, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8251), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8250), 0, "RUBY", new Guid("eea8313f-0781-46e7-b259-3606a6980029"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("ff9d8505-010a-477e-96d8-6163b607f361"), new DateTime(2016, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8567), new DateTime(2023, 12, 19, 16, 0, 27, 456, DateTimeKind.Utc).AddTicks(8566), 0, "SABASTEIN", new Guid("ed46dfad-4785-4421-ae34-a7da86620b68"), new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763") }
                });

            migrationBuilder.InsertData(
                table: "PetBlackList",
                columns: new[] { "Id", "PetId", "PetTypeId" },
                values: new object[,]
                {
                    { new Guid("019e8c5a-fccb-47e7-9944-cb703f3dffd6"), new Guid("47facc0d-5935-4749-81a4-79b1961f6de9"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("026c278f-8125-4890-8bc6-87a00ecc1493"), new Guid("f982354a-64b8-4627-b7b4-6248b76bd00c"), new Guid("0d374c06-008e-4cbe-bbe4-6f385b7725e5") },
                    { new Guid("04ae2055-c75a-48b8-b69d-ffa44117d162"), new Guid("dae7bc3e-ef46-4ddf-a082-a22bda4093df"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("0b558e45-2809-495d-95fe-fd5ed5254fbc"), new Guid("dae7bc3e-ef46-4ddf-a082-a22bda4093df"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("0fbe4c2a-9e1c-41e0-9539-770abe838607"), new Guid("9b4a6ced-4884-479f-b2b4-e1894ffaf243"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("1169baf2-0803-4fbe-89ab-2bfe1fb58805"), new Guid("e887a287-85ca-4985-8217-c6785011a181"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("11d81cdc-2b41-4236-9a8f-e33547829aac"), new Guid("ac0e964e-6ed9-48c0-ab1b-0b3ca159f79c"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("126c7493-ff0c-4279-9f69-3d76e1ef3162"), new Guid("667b77c4-6299-4d6a-8038-03c8a1d88d49"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("131d7329-6e04-479c-aaf2-3c0824fcab0c"), new Guid("fe9e0ddc-c142-42c1-833d-bbb0808ae00c"), new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a") },
                    { new Guid("1688cc81-22a2-4ea4-a37f-92e53b1ce612"), new Guid("b9301777-7afc-4f5a-824c-e5dbf2a1a063"), new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763") },
                    { new Guid("1bb62d68-c523-4ae3-849b-f7029fbdcddf"), new Guid("a11030bb-5f6f-4728-8399-61bee3c112b1"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("1c538488-5a45-479e-bcbd-1d42284cd532"), new Guid("ac0e964e-6ed9-48c0-ab1b-0b3ca159f79c"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("208373ab-953f-4f6f-8600-14fd9f936d0d"), new Guid("df299f5a-b161-4d03-9226-5c3a4a433ca9"), new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c") },
                    { new Guid("23ee209f-fda7-4c5c-919f-b07ed6318c90"), new Guid("0d042a50-bcb2-4780-ab3e-adf232e3e7cf"), new Guid("34af1337-fc8b-4e29-8415-2606fbeda0f8") },
                    { new Guid("2a7f91de-e2c7-4c3f-9452-a0bf2cdd1e83"), new Guid("ab5262ae-973c-4850-9213-c56363b2fcfb"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("2aef315a-5b61-48a6-8953-737f498b528b"), new Guid("74af42fd-5c4c-496f-8579-d08c65bfb595"), new Guid("34af1337-fc8b-4e29-8415-2606fbeda0f8") },
                    { new Guid("2dc13794-983f-4017-88ad-89935ae12380"), new Guid("44610089-2493-4587-a13d-b10e6db6ac91"), new Guid("34af1337-fc8b-4e29-8415-2606fbeda0f8") },
                    { new Guid("2eaf6ee3-6255-444e-b807-c7416a82fd06"), new Guid("e8d3d68a-4c06-4eee-9c5e-fe04575db022"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("303f0c35-5bbf-4c3d-bd8a-d7a6f33bd871"), new Guid("d365c33c-03df-4a45-ae6a-34d00d59708d"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("3272dbcf-59a9-4e16-88b4-5405c0d093a0"), new Guid("7ac1e919-3d07-4223-8a95-8826bd5b7396"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("3314b924-6228-4e44-b4ad-403e07322130"), new Guid("3ddce316-dc79-4a01-af69-ee9d11e460b0"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("3506d5e4-1958-46c9-a635-634a208aa86b"), new Guid("2a62e954-cdf9-4460-9b53-9e85591b3912"), new Guid("34af1337-fc8b-4e29-8415-2606fbeda0f8") },
                    { new Guid("3545d7a7-c6d5-40c2-95b7-0b545d288582"), new Guid("38e4e090-4918-42d4-9341-f5b6e540a4ec"), new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c") },
                    { new Guid("36871fdf-a681-476c-ab9f-021436d4f9b3"), new Guid("07f5584c-6ff3-4720-939e-7f6077381eea"), new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763") },
                    { new Guid("37009036-a084-4edc-8648-97207ba7bf7b"), new Guid("7ac1e919-3d07-4223-8a95-8826bd5b7396"), new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a") },
                    { new Guid("398aea49-0f4a-4f5f-9299-c7eaff21417d"), new Guid("667b77c4-6299-4d6a-8038-03c8a1d88d49"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("3a655685-abc6-4efc-8eb2-4a543b9f41e3"), new Guid("ede53097-91d2-437e-9059-4e2df88aa044"), new Guid("0d374c06-008e-4cbe-bbe4-6f385b7725e5") },
                    { new Guid("3b0ce148-0948-4438-ae99-41e299700a9b"), new Guid("0daed55c-208b-4c81-9b27-0b422763f629"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("3cceded3-00a7-4f68-a3cc-324ca405a7ac"), new Guid("0d042a50-bcb2-4780-ab3e-adf232e3e7cf"), new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a") },
                    { new Guid("443b1bc8-c629-4356-87ce-43b94082b794"), new Guid("df299f5a-b161-4d03-9226-5c3a4a433ca9"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("45f97155-7304-4e68-9a93-335793249eca"), new Guid("0c187efc-747b-42c6-8335-5c92d5babcb3"), new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a") },
                    { new Guid("490c3cdb-c1c2-4c03-b3d5-ea66932ae639"), new Guid("d8137db2-aba4-4992-84aa-ad97e419acc1"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("4ac7c521-5f49-4b83-91fd-45649c92c937"), new Guid("543bf592-149d-4f0d-abd1-35fcfc25e18b"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("4ba8b882-3deb-47e8-9637-fe9babe7bb59"), new Guid("b9301777-7afc-4f5a-824c-e5dbf2a1a063"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("4c009f62-39ff-4c9a-ae41-fbd8a0aecbf0"), new Guid("1c65186e-2ac9-407c-9ecc-5c19adf14971"), new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763") },
                    { new Guid("4d6f07d9-5bac-4614-98aa-b0d9cbcae333"), new Guid("3118878f-3520-4c39-af9f-e22246946d1b"), new Guid("0d374c06-008e-4cbe-bbe4-6f385b7725e5") },
                    { new Guid("4fefa680-58dc-4574-97c8-2b0376d6bd7a"), new Guid("3ddce316-dc79-4a01-af69-ee9d11e460b0"), new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a") },
                    { new Guid("5248cf2b-35d7-4442-9796-77adb6041791"), new Guid("980eb01d-472c-4525-8331-2936823ddd42"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("539b60e3-a606-4e8d-b825-0b82091365f6"), new Guid("11cb8fb1-b388-4f48-ad8a-101ccfd652ca"), new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a") },
                    { new Guid("578ababb-aa61-4e27-a589-c84a5cd86725"), new Guid("f982354a-64b8-4627-b7b4-6248b76bd00c"), new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a") },
                    { new Guid("5c7ca38b-593b-4b29-8748-afa0eba65f31"), new Guid("df06aedf-6280-4aac-b9f8-db77fd0b5912"), new Guid("0d374c06-008e-4cbe-bbe4-6f385b7725e5") },
                    { new Guid("5d4b5ad2-3cee-4d85-8a9e-d6ad5d3c45fd"), new Guid("4cd32d47-f0e3-4510-a9a9-02be7d63a663"), new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763") },
                    { new Guid("5db0d45e-2d83-4bde-b640-a13f486af37b"), new Guid("0096365a-4330-4ba1-90cc-882ec5fd2983"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("637556e0-90b7-4e8f-99b8-ddcd8809a9ed"), new Guid("07f5584c-6ff3-4720-939e-7f6077381eea"), new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c") },
                    { new Guid("666d055c-e7da-4d34-85e5-5b762aef2144"), new Guid("8cf7ac57-23e1-4f40-83a0-99bf90c6ea87"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("669d3240-7cc8-4454-92cd-59b2b1b43a32"), new Guid("95db66ed-a0fd-4648-867c-9b72fa10ece4"), new Guid("0d374c06-008e-4cbe-bbe4-6f385b7725e5") },
                    { new Guid("6865b351-cbb4-4e4b-a412-822f3a118843"), new Guid("d365c33c-03df-4a45-ae6a-34d00d59708d"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("6918f7f9-b321-45bc-bdc9-10b072aebde5"), new Guid("1348d155-aaca-4cf0-a7f7-bc20023cf6fe"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("69563a14-400e-45d9-896d-bda4ea923f94"), new Guid("6691a6c5-9e60-4aaa-9185-3bb1d2ecf762"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("6b6033c8-85e3-44f4-8ade-43df4814c509"), new Guid("543bf592-149d-4f0d-abd1-35fcfc25e18b"), new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c") },
                    { new Guid("6dfa86f3-7e67-4369-bc12-b3a51aad01e5"), new Guid("980eb01d-472c-4525-8331-2936823ddd42"), new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a") },
                    { new Guid("6f70d03e-cb9d-4c1d-8931-5cc811e7f545"), new Guid("ada561f0-a5de-4ee5-a15f-aec4cf5abbbf"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("723e5a76-df58-495a-b249-a04b7108c0e3"), new Guid("74af42fd-5c4c-496f-8579-d08c65bfb595"), new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a") },
                    { new Guid("74310f5c-2a8a-4aed-ad91-0a1b2bd1ecb3"), new Guid("4cd32d47-f0e3-4510-a9a9-02be7d63a663"), new Guid("2dd3fc9a-0424-46e5-b795-e707313d08a7") },
                    { new Guid("7500f22a-c879-4742-924c-c506bd1c1027"), new Guid("5b8e4ee6-644b-4405-baf2-7228c014bfbd"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("771bb554-7fe4-456a-86b6-f711e225232d"), new Guid("0daed55c-208b-4c81-9b27-0b422763f629"), new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763") },
                    { new Guid("7f0ef5e6-7ca9-4a3d-bceb-f5846350d37e"), new Guid("1c40e4ee-4a7e-448e-93bf-9af5917bbabe"), new Guid("34af1337-fc8b-4e29-8415-2606fbeda0f8") },
                    { new Guid("7f57b1bf-3f95-46df-9082-78956ae8d052"), new Guid("a49382d9-e348-46a4-9771-3a0ee5dba823"), new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763") },
                    { new Guid("80962af8-491e-4311-9bdd-605048358928"), new Guid("1c65186e-2ac9-407c-9ecc-5c19adf14971"), new Guid("2dd3fc9a-0424-46e5-b795-e707313d08a7") },
                    { new Guid("8119219c-147c-4535-ba12-b070643a6586"), new Guid("1348d155-aaca-4cf0-a7f7-bc20023cf6fe"), new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a") },
                    { new Guid("816062a8-c383-406e-a4ad-462a7cbbaaf7"), new Guid("3118878f-3520-4c39-af9f-e22246946d1b"), new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c") },
                    { new Guid("83de430b-10bf-4ff5-835a-1c35bb7e0a82"), new Guid("aa2acc11-63ba-49d9-ad9a-f07657b3a038"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("87dbe55e-1a51-487e-bbf2-c06f756c6ca2"), new Guid("2a62e954-cdf9-4460-9b53-9e85591b3912"), new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a") },
                    { new Guid("88081b91-3030-48f9-8296-dc467b8e12c7"), new Guid("47facc0d-5935-4749-81a4-79b1961f6de9"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("89e3684f-9a46-4686-8c87-7f975ad836be"), new Guid("aa2acc11-63ba-49d9-ad9a-f07657b3a038"), new Guid("34af1337-fc8b-4e29-8415-2606fbeda0f8") },
                    { new Guid("8db0bb0b-cfe5-402f-9c8a-e4e6e32b3b8a"), new Guid("aabfacee-23f9-4810-b714-a0f76ab50c41"), new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a") },
                    { new Guid("903945f2-7f6e-40d5-b9fd-ff3646377e9f"), new Guid("e8d3d68a-4c06-4eee-9c5e-fe04575db022"), new Guid("2dd3fc9a-0424-46e5-b795-e707313d08a7") },
                    { new Guid("90fd2d06-770b-4f29-99ad-176514bfc27d"), new Guid("0096365a-4330-4ba1-90cc-882ec5fd2983"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("9265fa3b-507b-49cb-8383-b9500ebcc758"), new Guid("0e60231b-8bf2-47b7-9119-262bfec4a1fe"), new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763") },
                    { new Guid("935ac570-bc61-40c5-ae47-dedeb9d4b444"), new Guid("0c187efc-747b-42c6-8335-5c92d5babcb3"), new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763") },
                    { new Guid("9adaf0c0-b834-46f4-9e0d-595f5844f3e5"), new Guid("d2d84f02-65c0-4876-92a8-6391467bfc9b"), new Guid("0d374c06-008e-4cbe-bbe4-6f385b7725e5") },
                    { new Guid("9aed6858-c3bc-4ebe-800a-a95d9b7005e2"), new Guid("1219825a-1bf7-4b22-b096-32f72011e207"), new Guid("2dd3fc9a-0424-46e5-b795-e707313d08a7") },
                    { new Guid("9ba9eafd-0908-45cc-b118-99f368c0fae5"), new Guid("70556cfa-8f85-444c-b14d-6d3d0560f9f1"), new Guid("0d374c06-008e-4cbe-bbe4-6f385b7725e5") },
                    { new Guid("9c38893c-10e7-4183-b2b0-8564e8bf7099"), new Guid("51b09774-5c33-419b-ab50-eb348502b5b5"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("9d52e1c5-836a-475e-9e6e-3c5d12d01ec2"), new Guid("1c40e4ee-4a7e-448e-93bf-9af5917bbabe"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("9dcd8cb5-66c3-4628-b910-6aa2c5f12458"), new Guid("95db66ed-a0fd-4648-867c-9b72fa10ece4"), new Guid("2dd3fc9a-0424-46e5-b795-e707313d08a7") },
                    { new Guid("9dde11e4-f047-46dc-8df5-0604a2d23880"), new Guid("ede53097-91d2-437e-9059-4e2df88aa044"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("a1cef83e-cc91-44ac-8829-810242a10b6d"), new Guid("70556cfa-8f85-444c-b14d-6d3d0560f9f1"), new Guid("2955e5d1-e4b6-4c1c-878b-087505ac469a") },
                    { new Guid("aaf9dbd2-7d22-4c12-af1a-d3bcacbd4a41"), new Guid("e887a287-85ca-4985-8217-c6785011a181"), new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763") },
                    { new Guid("ad5afa70-a161-4914-a7fa-c106b9fd34cc"), new Guid("1219825a-1bf7-4b22-b096-32f72011e207"), new Guid("0d374c06-008e-4cbe-bbe4-6f385b7725e5") },
                    { new Guid("ad8e3d27-4b9c-48d5-a484-a124bf7b8165"), new Guid("ada561f0-a5de-4ee5-a15f-aec4cf5abbbf"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("af09e0f3-a698-400a-83df-603949ce969f"), new Guid("11cb8fb1-b388-4f48-ad8a-101ccfd652ca"), new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c") },
                    { new Guid("af525f83-9b1c-4de2-8811-c382d5bbea96"), new Guid("6691a6c5-9e60-4aaa-9185-3bb1d2ecf762"), new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c") },
                    { new Guid("b5b58500-1c23-4207-8f63-2c4601625a80"), new Guid("df06aedf-6280-4aac-b9f8-db77fd0b5912"), new Guid("2dd3fc9a-0424-46e5-b795-e707313d08a7") },
                    { new Guid("b7db7ca7-4385-48e0-822f-e5a38d1b605c"), new Guid("e7fafe10-a996-49a4-9ea1-31603948882f"), new Guid("34af1337-fc8b-4e29-8415-2606fbeda0f8") },
                    { new Guid("bb874a84-3c21-4f26-8625-39a80d71d462"), new Guid("51b09774-5c33-419b-ab50-eb348502b5b5"), new Guid("2dd3fc9a-0424-46e5-b795-e707313d08a7") },
                    { new Guid("bc282da8-1ec2-435e-b2b0-c62dbe4d18db"), new Guid("aabfacee-23f9-4810-b714-a0f76ab50c41"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("be346b02-984f-48de-8c64-ade53c9dbc70"), new Guid("a11030bb-5f6f-4728-8399-61bee3c112b1"), new Guid("0d374c06-008e-4cbe-bbe4-6f385b7725e5") },
                    { new Guid("c4af494a-8ebc-4864-8bb8-12dc49edada4"), new Guid("a49382d9-e348-46a4-9771-3a0ee5dba823"), new Guid("036b1441-dac3-4c9d-913d-e3eab67909dd") },
                    { new Guid("c5654abc-0057-4c2f-a8ff-9a78d1c00bc2"), new Guid("38e4e090-4918-42d4-9341-f5b6e540a4ec"), new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763") },
                    { new Guid("cb12300b-f263-4461-98ac-86c129dd9891"), new Guid("082bc7b3-5ea9-4e9c-8426-e079479d13cc"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("d3b1eaff-5876-4c27-9767-96ab57381527"), new Guid("082bc7b3-5ea9-4e9c-8426-e079479d13cc"), new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763") },
                    { new Guid("d5b12ed6-4641-4622-a34a-068b71b4606e"), new Guid("0e60231b-8bf2-47b7-9119-262bfec4a1fe"), new Guid("d792cfed-2016-4f3d-947a-6a440784e7e7") },
                    { new Guid("da3ed200-fc26-4b44-839c-d944fc21ff67"), new Guid("44610089-2493-4587-a13d-b10e6db6ac91"), new Guid("e7e2d43a-6147-4afa-92d1-1cdaf445c077") },
                    { new Guid("db1bfe8f-9363-43b2-88af-dc5186e69dd8"), new Guid("e7fafe10-a996-49a4-9ea1-31603948882f"), new Guid("0d374c06-008e-4cbe-bbe4-6f385b7725e5") },
                    { new Guid("e248bef2-a6a8-4c7d-be3c-358c6b36f196"), new Guid("d8137db2-aba4-4992-84aa-ad97e419acc1"), new Guid("6242cdd3-e69a-45b4-a6d4-9b4ac14d1763") },
                    { new Guid("eae9b954-7232-428c-941a-acca5a2ffd7a"), new Guid("ab5262ae-973c-4850-9213-c56363b2fcfb"), new Guid("0d374c06-008e-4cbe-bbe4-6f385b7725e5") },
                    { new Guid("ecad70f2-1625-4e86-8d59-68b71d452c07"), new Guid("8cf7ac57-23e1-4f40-83a0-99bf90c6ea87"), new Guid("2dd3fc9a-0424-46e5-b795-e707313d08a7") },
                    { new Guid("ed3c62ed-03b5-48e7-b547-7e2ae6f6e19f"), new Guid("d2d84f02-65c0-4876-92a8-6391467bfc9b"), new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c") },
                    { new Guid("f8a2b05a-7772-4bfe-af28-8aab223c26a3"), new Guid("9b4a6ced-4884-479f-b2b4-e1894ffaf243"), new Guid("0d374c06-008e-4cbe-bbe4-6f385b7725e5") },
                    { new Guid("f9f46ef5-c6a8-496b-be83-42fe834c5a9b"), new Guid("5b8e4ee6-644b-4405-baf2-7228c014bfbd"), new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c") },
                    { new Guid("fd76f8d3-f294-4cbb-8657-778d6c046757"), new Guid("fe9e0ddc-c142-42c1-833d-bbb0808ae00c"), new Guid("6484f25e-35af-4e91-b112-4488f4f7e95c") }
                });

            migrationBuilder.InsertData(
                table: "PetTraits",
                columns: new[] { "Id", "PetId", "TraitId" },
                values: new object[,]
                {
                    { new Guid("01680bfe-44e6-4fef-9bd5-339bba533ec7"), new Guid("3118878f-3520-4c39-af9f-e22246946d1b"), new Guid("e4d8ef07-7c3c-4806-aed1-64cbe940b603") },
                    { new Guid("03911ac2-c255-4b89-8fd5-52024cce2711"), new Guid("ac0e964e-6ed9-48c0-ab1b-0b3ca159f79c"), new Guid("9f496fc8-f0a3-4fbc-ba3c-4b5ad6b1f5f9") },
                    { new Guid("0464a97d-7139-4169-81c3-1790da9e9ac7"), new Guid("d9054efa-4a3e-448b-b44c-dd47ca2a1868"), new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9") },
                    { new Guid("048314b3-c26e-4ce1-86b4-7fa98febffc9"), new Guid("aabfacee-23f9-4810-b714-a0f76ab50c41"), new Guid("d089f6ba-dd18-4243-93b5-186a3f9159ed") },
                    { new Guid("04f830bb-eaab-4fbb-92da-c7867a9aa165"), new Guid("81a80af5-a1df-4d3a-9973-161446038bb2"), new Guid("1f642298-3c46-4f91-9e19-5bb32ba4daae") },
                    { new Guid("0767ad23-6d30-4d70-8ca7-73d7537261fb"), new Guid("1fcab780-7679-4d4c-bcd1-7e1d0f378ed5"), new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184") },
                    { new Guid("0821f020-c8e3-4f83-8383-46f5098d7edc"), new Guid("ada561f0-a5de-4ee5-a15f-aec4cf5abbbf"), new Guid("1e877278-d960-441b-a948-f5daf2eef49b") },
                    { new Guid("084cac44-5a4a-4401-9cda-15fe38acc1ef"), new Guid("e7fafe10-a996-49a4-9ea1-31603948882f"), new Guid("004b50af-cfbc-486f-a030-46bf36d4e62d") },
                    { new Guid("0879ddd5-f538-44b2-8334-617d2dde7364"), new Guid("ede53097-91d2-437e-9059-4e2df88aa044"), new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184") },
                    { new Guid("088d13d8-0e16-444b-b679-ed43853e404c"), new Guid("926c8cb3-e594-4a8a-b2f2-7af1de3e98d9"), new Guid("004b50af-cfbc-486f-a030-46bf36d4e62d") },
                    { new Guid("093391a0-3943-4439-9d13-76d00e3e2305"), new Guid("7ac1e919-3d07-4223-8a95-8826bd5b7396"), new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9") },
                    { new Guid("09886ac6-ce5c-49a4-abba-7d46bc08affe"), new Guid("f982354a-64b8-4627-b7b4-6248b76bd00c"), new Guid("ec621f95-910e-4586-9303-0c73ef593ad9") },
                    { new Guid("09992585-94c8-46ff-9dd1-f4f5e40212e1"), new Guid("7d87dded-e930-4d38-86f2-e85d07854116"), new Guid("e4d8ef07-7c3c-4806-aed1-64cbe940b603") },
                    { new Guid("0a2d5a46-68cd-4802-8d87-ed449f5f0c15"), new Guid("70556cfa-8f85-444c-b14d-6d3d0560f9f1"), new Guid("87d93f4b-3ff8-4ae2-a46e-e382b96241bc") },
                    { new Guid("0a2dc66f-d48d-4e11-8c87-dfdcef6ec28f"), new Guid("fba2d8ac-f067-49c5-b80a-4c4c3baf659f"), new Guid("6fdda566-38d3-472f-ad74-f4f72a6c9bf8") },
                    { new Guid("0b80ac7d-b3ba-40c9-8ad9-4eff35eebeca"), new Guid("2a62e954-cdf9-4460-9b53-9e85591b3912"), new Guid("91a38df8-4a4e-4c95-9881-bb303756b6f7") },
                    { new Guid("0b8615ec-75ad-48dd-976b-8cf3e590b3c1"), new Guid("a49382d9-e348-46a4-9771-3a0ee5dba823"), new Guid("fcea3830-4848-4bfa-a262-40e31f72f4f9") },
                    { new Guid("0c50f4c4-7b88-4cf8-9a6f-e5540a361b02"), new Guid("1219825a-1bf7-4b22-b096-32f72011e207"), new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184") },
                    { new Guid("0cad2f39-e46e-4f83-b60d-a5dfe12a64a1"), new Guid("bd363546-2c17-455c-ba96-58c661341529"), new Guid("19011554-1b19-4f83-a76a-b2355790e78b") },
                    { new Guid("0d37ebf5-f285-4341-8e6f-cdb7a0207243"), new Guid("980eb01d-472c-4525-8331-2936823ddd42"), new Guid("ca85fb70-39f2-4cba-b321-1413fd2f365f") },
                    { new Guid("0f68447b-c430-4112-a4ca-5fec386a9baa"), new Guid("6d669948-f5b5-4892-a0b8-a680591ddf4c"), new Guid("1f642298-3c46-4f91-9e19-5bb32ba4daae") },
                    { new Guid("116eb0dd-038e-4a6c-b52c-84bf4dae8d1d"), new Guid("6c95a987-a5b0-4743-a7aa-e09e5f3aefa8"), new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184") },
                    { new Guid("140ccb80-171f-4bb3-8ceb-1ea39864dfba"), new Guid("667b77c4-6299-4d6a-8038-03c8a1d88d49"), new Guid("1f642298-3c46-4f91-9e19-5bb32ba4daae") },
                    { new Guid("166bb6c6-9835-499f-b5b4-332f53b2e222"), new Guid("f982354a-64b8-4627-b7b4-6248b76bd00c"), new Guid("87d93f4b-3ff8-4ae2-a46e-e382b96241bc") },
                    { new Guid("17be3eef-62bd-4d1a-98a2-8e2238b6ffce"), new Guid("38d16719-d19c-4945-8d09-a9165c19d568"), new Guid("fcea3830-4848-4bfa-a262-40e31f72f4f9") },
                    { new Guid("18b7449b-08ac-4438-bf98-0e9d37da7841"), new Guid("6d669948-f5b5-4892-a0b8-a680591ddf4c"), new Guid("004b50af-cfbc-486f-a030-46bf36d4e62d") },
                    { new Guid("1926a8fc-c200-4733-8680-e22c27ae32ec"), new Guid("d2d84f02-65c0-4876-92a8-6391467bfc9b"), new Guid("19011554-1b19-4f83-a76a-b2355790e78b") },
                    { new Guid("194253df-bb9a-493a-acb0-f15140a2545a"), new Guid("27b9f3bf-9a47-4c12-b743-4d9d95bfca40"), new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184") },
                    { new Guid("19ed1778-8cb1-4fe3-93c6-7aa59c623f9f"), new Guid("b9301777-7afc-4f5a-824c-e5dbf2a1a063"), new Guid("bacb50bd-f61b-4508-a550-783c6fd927ab") },
                    { new Guid("1a3075f7-cbfa-48b1-a2de-838223980691"), new Guid("07f5584c-6ff3-4720-939e-7f6077381eea"), new Guid("3c29a377-0a27-48f5-8c24-8e38b12d62a6") },
                    { new Guid("1b219f47-c50b-4515-a897-05617093b27b"), new Guid("53d7a21f-05f4-4bda-8058-693923dca93c"), new Guid("fcea3830-4848-4bfa-a262-40e31f72f4f9") },
                    { new Guid("1c994005-4898-463b-bc56-9f713fb900c2"), new Guid("ab5262ae-973c-4850-9213-c56363b2fcfb"), new Guid("d089f6ba-dd18-4243-93b5-186a3f9159ed") },
                    { new Guid("1d4a8589-829a-4503-a52d-99913089aa53"), new Guid("5981392d-cdf1-42d5-be5a-6b129e53efed"), new Guid("87d93f4b-3ff8-4ae2-a46e-e382b96241bc") },
                    { new Guid("1e1994ae-8e47-4fa3-818a-7fe91614281e"), new Guid("2eb17d89-cc1b-4e15-856b-aa611d7d7561"), new Guid("1e877278-d960-441b-a948-f5daf2eef49b") },
                    { new Guid("1e37fc2a-57ac-4c0b-b3b4-fd33d1869737"), new Guid("1c40e4ee-4a7e-448e-93bf-9af5917bbabe"), new Guid("6fdda566-38d3-472f-ad74-f4f72a6c9bf8") },
                    { new Guid("1eef26cb-1c47-4fdd-a787-28d84b461b68"), new Guid("109684b8-4a63-44c6-a669-a84ce1636701"), new Guid("6fdda566-38d3-472f-ad74-f4f72a6c9bf8") },
                    { new Guid("1f9d3639-534d-4e82-a325-be7f841f2feb"), new Guid("070ce240-1ffe-40c6-9e33-f583aa6996ef"), new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9") },
                    { new Guid("212652bf-f4e0-464e-affa-be293f943e74"), new Guid("81a1f67d-362e-4498-af82-511fae47f397"), new Guid("004b50af-cfbc-486f-a030-46bf36d4e62d") },
                    { new Guid("2343120d-158e-49b9-b9ac-e7b5c1d5f92a"), new Guid("0c187efc-747b-42c6-8335-5c92d5babcb3"), new Guid("bacb50bd-f61b-4508-a550-783c6fd927ab") },
                    { new Guid("2372e184-26f2-4ead-85c1-1fdbb5414cff"), new Guid("d365c33c-03df-4a45-ae6a-34d00d59708d"), new Guid("004b50af-cfbc-486f-a030-46bf36d4e62d") },
                    { new Guid("24cac3ec-2a14-4612-a235-33df0bc49f47"), new Guid("38d16719-d19c-4945-8d09-a9165c19d568"), new Guid("bacb50bd-f61b-4508-a550-783c6fd927ab") },
                    { new Guid("253c1c65-6213-4207-b142-debe55e31075"), new Guid("3ff43ae2-ffd9-4b24-acdd-471ebb5101be"), new Guid("6fdda566-38d3-472f-ad74-f4f72a6c9bf8") },
                    { new Guid("2570f5ea-ae0d-422a-9f78-066d32832316"), new Guid("e7fafe10-a996-49a4-9ea1-31603948882f"), new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9") },
                    { new Guid("26407616-65bb-4410-89e3-8aaeae7c61c2"), new Guid("e8d3d68a-4c06-4eee-9c5e-fe04575db022"), new Guid("bacb50bd-f61b-4508-a550-783c6fd927ab") },
                    { new Guid("267d70b1-bd08-41b9-8a31-65bafe165500"), new Guid("1219825a-1bf7-4b22-b096-32f72011e207"), new Guid("ca85fb70-39f2-4cba-b321-1413fd2f365f") },
                    { new Guid("270ff418-af48-4640-ba0d-c92574fb0d71"), new Guid("082bc7b3-5ea9-4e9c-8426-e079479d13cc"), new Guid("1e877278-d960-441b-a948-f5daf2eef49b") },
                    { new Guid("28399d92-c0b6-49f2-852e-f0504d648518"), new Guid("d365c33c-03df-4a45-ae6a-34d00d59708d"), new Guid("e4d8ef07-7c3c-4806-aed1-64cbe940b603") },
                    { new Guid("28706e78-f263-46da-ac5d-2fc9c9ce8ab4"), new Guid("fdf74e3d-c810-4daa-a199-05aebbe8783b"), new Guid("e3668814-9cad-43d6-9b01-68c3fd7d4f6e") },
                    { new Guid("29b26cdc-7e85-4c07-a455-58d38d3dc4fe"), new Guid("d9054efa-4a3e-448b-b44c-dd47ca2a1868"), new Guid("bacb50bd-f61b-4508-a550-783c6fd927ab") },
                    { new Guid("2a1adf91-65ef-4e58-8db3-58ca172753a0"), new Guid("62d512f3-dc02-4ec5-b48f-6d0da7d736f9"), new Guid("19011554-1b19-4f83-a76a-b2355790e78b") },
                    { new Guid("2c26a6b4-3236-4949-a145-1dae5f477e98"), new Guid("926c8cb3-e594-4a8a-b2f2-7af1de3e98d9"), new Guid("e9ce39fd-fbbe-478b-97f4-c9226b3abf44") },
                    { new Guid("2d3a7a32-ebe6-43e6-8439-24b873c034ac"), new Guid("796140a3-84b7-45f7-96b0-049a78996f52"), new Guid("d089f6ba-dd18-4243-93b5-186a3f9159ed") },
                    { new Guid("2d7c0599-95ed-4c46-8f6e-97cd801de4a4"), new Guid("edc2a38c-a04f-4359-87b6-0a8d0e3c5945"), new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9") },
                    { new Guid("2dedf7c8-c821-4bb9-9afe-cd3fe97fcbbe"), new Guid("980eb01d-472c-4525-8331-2936823ddd42"), new Guid("004b50af-cfbc-486f-a030-46bf36d4e62d") },
                    { new Guid("2f354dcf-f00d-4288-b743-aa54dbf50ac7"), new Guid("fe9e0ddc-c142-42c1-833d-bbb0808ae00c"), new Guid("9f496fc8-f0a3-4fbc-ba3c-4b5ad6b1f5f9") },
                    { new Guid("2f4384ad-0ce3-4ad0-a97f-b5374e43d197"), new Guid("6c95a987-a5b0-4743-a7aa-e09e5f3aefa8"), new Guid("fcea3830-4848-4bfa-a262-40e31f72f4f9") },
                    { new Guid("304d0184-7baa-43fc-ad47-d127e7418cb7"), new Guid("0c187efc-747b-42c6-8335-5c92d5babcb3"), new Guid("e3668814-9cad-43d6-9b01-68c3fd7d4f6e") },
                    { new Guid("311631e1-38e8-4a3b-b21a-493afdc81e15"), new Guid("f928e406-0d48-445f-afb7-44613d593491"), new Guid("87d93f4b-3ff8-4ae2-a46e-e382b96241bc") },
                    { new Guid("31de2fa0-95b3-471d-97c9-33e5be5e88fc"), new Guid("de2275b3-75e1-4ac2-8dd9-517d03036f36"), new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184") },
                    { new Guid("3278dd74-906a-4709-a15f-32ad7aa25074"), new Guid("d8137db2-aba4-4992-84aa-ad97e419acc1"), new Guid("bacb50bd-f61b-4508-a550-783c6fd927ab") },
                    { new Guid("338fd116-5834-4870-a807-5494bb333118"), new Guid("47facc0d-5935-4749-81a4-79b1961f6de9"), new Guid("87d93f4b-3ff8-4ae2-a46e-e382b96241bc") },
                    { new Guid("34a8ae77-e92a-4021-9895-66c297a340c0"), new Guid("bf6de7a9-4bd5-48ff-9267-f9d043c8c691"), new Guid("bacb50bd-f61b-4508-a550-783c6fd927ab") },
                    { new Guid("356e04a3-c850-4dc1-b10f-eb4ab3359882"), new Guid("aabfacee-23f9-4810-b714-a0f76ab50c41"), new Guid("004b50af-cfbc-486f-a030-46bf36d4e62d") },
                    { new Guid("3585d010-bfd6-4882-8930-5bfe3126ef46"), new Guid("ff9d8505-010a-477e-96d8-6163b607f361"), new Guid("ca85fb70-39f2-4cba-b321-1413fd2f365f") },
                    { new Guid("35b8c348-8203-4f74-9d71-b327ebfa24b3"), new Guid("36be2138-3096-4e06-9e21-6c75238e1a1d"), new Guid("19011554-1b19-4f83-a76a-b2355790e78b") },
                    { new Guid("386c4648-0f59-4728-bd87-4ecaf9629cfd"), new Guid("5b8e4ee6-644b-4405-baf2-7228c014bfbd"), new Guid("e4d8ef07-7c3c-4806-aed1-64cbe940b603") },
                    { new Guid("387bb0e6-f27d-4c7f-96de-c0860975ab09"), new Guid("27b9f3bf-9a47-4c12-b743-4d9d95bfca40"), new Guid("004b50af-cfbc-486f-a030-46bf36d4e62d") },
                    { new Guid("3898ade0-ab99-4f55-9263-51d34fd460fc"), new Guid("bf45df62-3235-430b-9da6-9127f6392f38"), new Guid("004b50af-cfbc-486f-a030-46bf36d4e62d") },
                    { new Guid("38f8b2a5-f047-453f-9816-06b370a3e703"), new Guid("1fcab780-7679-4d4c-bcd1-7e1d0f378ed5"), new Guid("1f642298-3c46-4f91-9e19-5bb32ba4daae") },
                    { new Guid("3bb81d92-1f58-4ff8-a4c6-8b0524e4a9fe"), new Guid("1786885f-22a9-49dc-911e-64e2c9259b39"), new Guid("1f642298-3c46-4f91-9e19-5bb32ba4daae") },
                    { new Guid("3c7c0ba9-f5d9-4fb3-b9f8-4618e223b54a"), new Guid("88be7be6-91e9-44e0-9df7-153265e68630"), new Guid("e3668814-9cad-43d6-9b01-68c3fd7d4f6e") },
                    { new Guid("3c853b7b-054e-471a-896c-b02610efc5de"), new Guid("f982354a-64b8-4627-b7b4-6248b76bd00c"), new Guid("e3668814-9cad-43d6-9b01-68c3fd7d4f6e") },
                    { new Guid("3c958aa0-c5b6-4958-91c1-14854c816599"), new Guid("ae5080fa-7392-4c23-bdf3-3b0a085ca0cb"), new Guid("e3668814-9cad-43d6-9b01-68c3fd7d4f6e") },
                    { new Guid("3d4dde51-62d6-43fa-859d-39792d275c97"), new Guid("550ab457-54d2-44a4-8978-af3f9e97b906"), new Guid("91a38df8-4a4e-4c95-9881-bb303756b6f7") },
                    { new Guid("3d71e179-3e3b-4a83-b09a-44ef3ebf02a8"), new Guid("ada561f0-a5de-4ee5-a15f-aec4cf5abbbf"), new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9") },
                    { new Guid("3d87eafa-99c8-4048-8fdc-93c65e09461e"), new Guid("8f36b6ca-e302-41ac-acdf-1ee00eee9bd7"), new Guid("bacb50bd-f61b-4508-a550-783c6fd927ab") },
                    { new Guid("3dd26f08-9489-41c7-b75d-f2d387c96781"), new Guid("1c40e4ee-4a7e-448e-93bf-9af5917bbabe"), new Guid("9f496fc8-f0a3-4fbc-ba3c-4b5ad6b1f5f9") },
                    { new Guid("3ed4a03a-6504-41d8-aa99-8aabcc6f7cbe"), new Guid("0d042a50-bcb2-4780-ab3e-adf232e3e7cf"), new Guid("1f642298-3c46-4f91-9e19-5bb32ba4daae") },
                    { new Guid("3ff52b32-bd18-4991-a130-a624fdc339fd"), new Guid("a476f5eb-91af-48df-8337-180435e42e79"), new Guid("e9ce39fd-fbbe-478b-97f4-c9226b3abf44") },
                    { new Guid("3ff5cbc1-e333-49d8-8d23-f4dc9ff3e5df"), new Guid("070ce240-1ffe-40c6-9e33-f583aa6996ef"), new Guid("e4d8ef07-7c3c-4806-aed1-64cbe940b603") },
                    { new Guid("40bbda74-3089-42e9-804d-46a1546886ab"), new Guid("08b80e81-7a41-4d17-adbd-b2743dbf32c9"), new Guid("9f496fc8-f0a3-4fbc-ba3c-4b5ad6b1f5f9") },
                    { new Guid("412bd5e4-1b2e-45b5-acee-6aa3d8548cb3"), new Guid("d8137db2-aba4-4992-84aa-ad97e419acc1"), new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9") },
                    { new Guid("41ce6a81-9b27-4a12-8a6a-03fc53d673e7"), new Guid("bd363546-2c17-455c-ba96-58c661341529"), new Guid("9f496fc8-f0a3-4fbc-ba3c-4b5ad6b1f5f9") },
                    { new Guid("41e9ac4a-8321-4b46-a3e8-f541f7d5d6c6"), new Guid("d2d84f02-65c0-4876-92a8-6391467bfc9b"), new Guid("bacb50bd-f61b-4508-a550-783c6fd927ab") },
                    { new Guid("4363dccc-43dd-4340-a7ba-d2cad54624a6"), new Guid("07f5584c-6ff3-4720-939e-7f6077381eea"), new Guid("e3668814-9cad-43d6-9b01-68c3fd7d4f6e") },
                    { new Guid("43b37b41-f0f4-4b85-a7a0-c359bc9c7dac"), new Guid("1348d155-aaca-4cf0-a7f7-bc20023cf6fe"), new Guid("91a38df8-4a4e-4c95-9881-bb303756b6f7") },
                    { new Guid("44101a3e-f62d-4893-b043-9659dfae2c80"), new Guid("8f36b6ca-e302-41ac-acdf-1ee00eee9bd7"), new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184") },
                    { new Guid("45147866-f8fe-4dfa-9bc3-24c0640d71e3"), new Guid("6c95a987-a5b0-4743-a7aa-e09e5f3aefa8"), new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9") },
                    { new Guid("465e2997-7ea3-4ba2-8246-91aabf414249"), new Guid("aa2acc11-63ba-49d9-ad9a-f07657b3a038"), new Guid("fcea3830-4848-4bfa-a262-40e31f72f4f9") },
                    { new Guid("46cad2cf-3d61-4637-8a2d-1537d9eaf015"), new Guid("e887a287-85ca-4985-8217-c6785011a181"), new Guid("1f642298-3c46-4f91-9e19-5bb32ba4daae") },
                    { new Guid("46f35201-e012-4968-bfb6-efe3d86e1581"), new Guid("4d30f7f2-6ab0-45de-8d02-38654ef1b2af"), new Guid("3c29a377-0a27-48f5-8c24-8e38b12d62a6") },
                    { new Guid("4791ad0d-7a91-45c6-a300-9eb347102708"), new Guid("e887a287-85ca-4985-8217-c6785011a181"), new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9") },
                    { new Guid("4a1322ed-918f-4e18-9509-f61563344305"), new Guid("796140a3-84b7-45f7-96b0-049a78996f52"), new Guid("e4d8ef07-7c3c-4806-aed1-64cbe940b603") },
                    { new Guid("4b163f00-6383-4a98-a286-fe427f5f320c"), new Guid("bf45df62-3235-430b-9da6-9127f6392f38"), new Guid("ca85fb70-39f2-4cba-b321-1413fd2f365f") },
                    { new Guid("4bdf16d0-d3ba-4e88-9930-56e317e1ea12"), new Guid("6691a6c5-9e60-4aaa-9185-3bb1d2ecf762"), new Guid("e9ce39fd-fbbe-478b-97f4-c9226b3abf44") },
                    { new Guid("4c8d1e8a-dfb5-46a6-b06d-0dd0dc912d08"), new Guid("43446cbb-25eb-4369-a206-1164474484d9"), new Guid("19011554-1b19-4f83-a76a-b2355790e78b") },
                    { new Guid("4e9bb444-1b99-4d4a-8fbd-578270649016"), new Guid("44610089-2493-4587-a13d-b10e6db6ac91"), new Guid("6fdda566-38d3-472f-ad74-f4f72a6c9bf8") },
                    { new Guid("4f84ceed-c3ed-4e3d-a9e0-1c40cd0d24e3"), new Guid("22b386a2-71f5-4e91-9b55-879449b93fa3"), new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9") },
                    { new Guid("509d7c0d-f275-480e-b3dd-da510f784956"), new Guid("df299f5a-b161-4d03-9226-5c3a4a433ca9"), new Guid("87d93f4b-3ff8-4ae2-a46e-e382b96241bc") },
                    { new Guid("50bcffcc-b5b8-4300-9f34-b1a6345efa88"), new Guid("44610089-2493-4587-a13d-b10e6db6ac91"), new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9") },
                    { new Guid("50ea0c01-56da-4912-9347-643e35b8ad19"), new Guid("f25a412f-fdf8-4b5d-9381-64f2452e39b9"), new Guid("6fdda566-38d3-472f-ad74-f4f72a6c9bf8") },
                    { new Guid("513fcfb2-1679-49a5-bd47-324a14ee5bad"), new Guid("df299f5a-b161-4d03-9226-5c3a4a433ca9"), new Guid("1e877278-d960-441b-a948-f5daf2eef49b") },
                    { new Guid("52474629-e232-4763-8515-3d10aa9afe0d"), new Guid("95db66ed-a0fd-4648-867c-9b72fa10ece4"), new Guid("3c29a377-0a27-48f5-8c24-8e38b12d62a6") },
                    { new Guid("52e8ef2f-a602-4812-988d-6fc271232a82"), new Guid("a49382d9-e348-46a4-9771-3a0ee5dba823"), new Guid("bacb50bd-f61b-4508-a550-783c6fd927ab") },
                    { new Guid("5506402e-a9e1-4819-8c58-4bdb16107208"), new Guid("b2fc4f55-9987-4f53-b4ac-8dbb95273098"), new Guid("ec621f95-910e-4586-9303-0c73ef593ad9") },
                    { new Guid("555252cb-ce1a-47a1-bfa0-e3535a1dd1c5"), new Guid("f928e406-0d48-445f-afb7-44613d593491"), new Guid("e9ce39fd-fbbe-478b-97f4-c9226b3abf44") },
                    { new Guid("58815ec2-0d1d-4f45-aefd-2ba297a8a4ff"), new Guid("0e60231b-8bf2-47b7-9119-262bfec4a1fe"), new Guid("ca85fb70-39f2-4cba-b321-1413fd2f365f") },
                    { new Guid("589440d9-f54f-429e-98e1-a4c0356f1c66"), new Guid("ac0e964e-6ed9-48c0-ab1b-0b3ca159f79c"), new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9") },
                    { new Guid("58cb6a6a-885d-492e-9343-eaf6a5726ac9"), new Guid("47facc0d-5935-4749-81a4-79b1961f6de9"), new Guid("004b50af-cfbc-486f-a030-46bf36d4e62d") },
                    { new Guid("5d8b5339-a1bf-4e1c-94ff-3be20ce9f67e"), new Guid("e8d3d68a-4c06-4eee-9c5e-fe04575db022"), new Guid("e9ce39fd-fbbe-478b-97f4-c9226b3abf44") },
                    { new Guid("5e6dce34-a5c3-4d2c-9912-afe9e00f93f0"), new Guid("f25a412f-fdf8-4b5d-9381-64f2452e39b9"), new Guid("bacb50bd-f61b-4508-a550-783c6fd927ab") },
                    { new Guid("5e8a7e55-b3f4-41ad-9532-2aa689358f0d"), new Guid("95db66ed-a0fd-4648-867c-9b72fa10ece4"), new Guid("bacb50bd-f61b-4508-a550-783c6fd927ab") },
                    { new Guid("5f099656-61b5-4b4f-aa0c-83b855fed0fa"), new Guid("ede53097-91d2-437e-9059-4e2df88aa044"), new Guid("e3668814-9cad-43d6-9b01-68c3fd7d4f6e") },
                    { new Guid("600dc686-1d05-4c21-b2b0-b97fefa3743a"), new Guid("1786885f-22a9-49dc-911e-64e2c9259b39"), new Guid("fcea3830-4848-4bfa-a262-40e31f72f4f9") },
                    { new Guid("60253779-bfed-4b10-9b68-c4757763cbb6"), new Guid("0096365a-4330-4ba1-90cc-882ec5fd2983"), new Guid("bacb50bd-f61b-4508-a550-783c6fd927ab") },
                    { new Guid("607af096-2f97-4803-9746-f5f41d3957fc"), new Guid("df06aedf-6280-4aac-b9f8-db77fd0b5912"), new Guid("e3668814-9cad-43d6-9b01-68c3fd7d4f6e") },
                    { new Guid("60c7b134-52ba-4d4e-85a5-50223df8cdaf"), new Guid("a11030bb-5f6f-4728-8399-61bee3c112b1"), new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184") },
                    { new Guid("60da468f-785b-468e-af0d-c2e0ff3542c3"), new Guid("7d87dded-e930-4d38-86f2-e85d07854116"), new Guid("d089f6ba-dd18-4243-93b5-186a3f9159ed") },
                    { new Guid("61e3cbc0-5747-4eca-b925-8048480593c4"), new Guid("38d16719-d19c-4945-8d09-a9165c19d568"), new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184") },
                    { new Guid("62353aed-d672-4bb7-9670-6b07e6027340"), new Guid("109684b8-4a63-44c6-a669-a84ce1636701"), new Guid("1f642298-3c46-4f91-9e19-5bb32ba4daae") },
                    { new Guid("62c42d1b-4cc6-4a6a-87a6-d0ba50f140f4"), new Guid("42bb3c76-fdc7-4764-b425-eded5c7ec7a5"), new Guid("e9ce39fd-fbbe-478b-97f4-c9226b3abf44") },
                    { new Guid("639923b2-d20c-4c21-babf-15aa8261970d"), new Guid("b4d3f58d-3a3c-4f99-88e1-03c7b7f07364"), new Guid("ec621f95-910e-4586-9303-0c73ef593ad9") },
                    { new Guid("63d6010e-4752-4d93-bfdf-8d228f2be361"), new Guid("edc2a38c-a04f-4359-87b6-0a8d0e3c5945"), new Guid("004b50af-cfbc-486f-a030-46bf36d4e62d") },
                    { new Guid("653de686-640d-4a36-810c-abdc7bff6bd5"), new Guid("bf6de7a9-4bd5-48ff-9267-f9d043c8c691"), new Guid("1e877278-d960-441b-a948-f5daf2eef49b") },
                    { new Guid("65829ce6-c0fa-48da-9e58-9ff71b7adc50"), new Guid("9e0d176c-2fa4-4691-a910-431d9dc35a2f"), new Guid("ec621f95-910e-4586-9303-0c73ef593ad9") },
                    { new Guid("662e91b6-acfc-45d6-a39e-2a542618f18e"), new Guid("11cb8fb1-b388-4f48-ad8a-101ccfd652ca"), new Guid("87d93f4b-3ff8-4ae2-a46e-e382b96241bc") },
                    { new Guid("6846124d-d9a3-4bcf-906f-9b6f4fc40bc7"), new Guid("74af42fd-5c4c-496f-8579-d08c65bfb595"), new Guid("6fdda566-38d3-472f-ad74-f4f72a6c9bf8") },
                    { new Guid("68f37dbc-c771-43f1-9e87-67c709931851"), new Guid("08b80e81-7a41-4d17-adbd-b2743dbf32c9"), new Guid("91a38df8-4a4e-4c95-9881-bb303756b6f7") },
                    { new Guid("6955448e-8b4f-43c2-b513-aa332ba56d7e"), new Guid("38e4e090-4918-42d4-9341-f5b6e540a4ec"), new Guid("91a38df8-4a4e-4c95-9881-bb303756b6f7") },
                    { new Guid("6980fc46-c12f-4d62-abd5-2a612980093f"), new Guid("df06aedf-6280-4aac-b9f8-db77fd0b5912"), new Guid("d089f6ba-dd18-4243-93b5-186a3f9159ed") },
                    { new Guid("6983e91b-44a3-4b23-b1ca-410bb56c771b"), new Guid("b2fc4f55-9987-4f53-b4ac-8dbb95273098"), new Guid("1f642298-3c46-4f91-9e19-5bb32ba4daae") },
                    { new Guid("6a3d2895-309e-492a-9359-cc9ac6136d73"), new Guid("550ab457-54d2-44a4-8978-af3f9e97b906"), new Guid("fcea3830-4848-4bfa-a262-40e31f72f4f9") },
                    { new Guid("6b1fa673-c9a6-4fcb-bd56-dae9b2cc1eee"), new Guid("0d042a50-bcb2-4780-ab3e-adf232e3e7cf"), new Guid("91a38df8-4a4e-4c95-9881-bb303756b6f7") },
                    { new Guid("6b6873b0-c35a-41fb-ac13-c59069683265"), new Guid("1219825a-1bf7-4b22-b096-32f72011e207"), new Guid("fcea3830-4848-4bfa-a262-40e31f72f4f9") },
                    { new Guid("6bc56ac2-3a51-42b6-9440-9c3d876c80e4"), new Guid("d2d84f02-65c0-4876-92a8-6391467bfc9b"), new Guid("87d93f4b-3ff8-4ae2-a46e-e382b96241bc") },
                    { new Guid("6d00f95e-bd77-4a6b-b15c-99997ec354aa"), new Guid("38e4e090-4918-42d4-9341-f5b6e540a4ec"), new Guid("e4d8ef07-7c3c-4806-aed1-64cbe940b603") },
                    { new Guid("6dba5916-45f2-4574-a099-fe698f296bc6"), new Guid("df06aedf-6280-4aac-b9f8-db77fd0b5912"), new Guid("19011554-1b19-4f83-a76a-b2355790e78b") },
                    { new Guid("6e04906a-c1c2-49db-8b23-0634104f371d"), new Guid("667b77c4-6299-4d6a-8038-03c8a1d88d49"), new Guid("19011554-1b19-4f83-a76a-b2355790e78b") },
                    { new Guid("6e49ae11-974f-4484-af8a-02ccc9eaf919"), new Guid("fe9e0ddc-c142-42c1-833d-bbb0808ae00c"), new Guid("19011554-1b19-4f83-a76a-b2355790e78b") },
                    { new Guid("6f5f5a29-c21f-4126-8999-b2a47dcdb83a"), new Guid("3ddce316-dc79-4a01-af69-ee9d11e460b0"), new Guid("d089f6ba-dd18-4243-93b5-186a3f9159ed") },
                    { new Guid("720530ad-d87f-4ad8-8405-f8b9449f8fad"), new Guid("07f5584c-6ff3-4720-939e-7f6077381eea"), new Guid("ca85fb70-39f2-4cba-b321-1413fd2f365f") },
                    { new Guid("7351c6e0-ac41-48aa-895d-c492df299011"), new Guid("0e60231b-8bf2-47b7-9119-262bfec4a1fe"), new Guid("1e877278-d960-441b-a948-f5daf2eef49b") },
                    { new Guid("7433d28b-166e-4002-adc2-4e935ec4740e"), new Guid("74af42fd-5c4c-496f-8579-d08c65bfb595"), new Guid("004b50af-cfbc-486f-a030-46bf36d4e62d") },
                    { new Guid("744f1dc2-b08a-43ba-b955-c070fa4ca7ea"), new Guid("47facc0d-5935-4749-81a4-79b1961f6de9"), new Guid("e9ce39fd-fbbe-478b-97f4-c9226b3abf44") },
                    { new Guid("77833a76-a903-4972-833c-21436f1da5ba"), new Guid("e887a287-85ca-4985-8217-c6785011a181"), new Guid("004b50af-cfbc-486f-a030-46bf36d4e62d") },
                    { new Guid("77a2966c-ce3c-4eda-b98c-45a40cd8b905"), new Guid("4cd32d47-f0e3-4510-a9a9-02be7d63a663"), new Guid("6fdda566-38d3-472f-ad74-f4f72a6c9bf8") },
                    { new Guid("78fa8fee-a21c-4feb-8ab5-8ffea557d38e"), new Guid("d365c33c-03df-4a45-ae6a-34d00d59708d"), new Guid("3c29a377-0a27-48f5-8c24-8e38b12d62a6") },
                    { new Guid("79154f67-5da8-4801-862b-fbbbe47c31ef"), new Guid("d9054efa-4a3e-448b-b44c-dd47ca2a1868"), new Guid("e9ce39fd-fbbe-478b-97f4-c9226b3abf44") },
                    { new Guid("7b1bdae1-7fd0-4c70-9c7f-f95dbd80c702"), new Guid("a590fe7d-6ff7-4541-b8c9-9fbe0d31735a"), new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9") },
                    { new Guid("7c51f86f-1fe2-4053-b7cb-567928c21276"), new Guid("0c187efc-747b-42c6-8335-5c92d5babcb3"), new Guid("1e877278-d960-441b-a948-f5daf2eef49b") },
                    { new Guid("7e05ec01-91ff-49fe-b7b7-f4a26824cb07"), new Guid("ae5080fa-7392-4c23-bdf3-3b0a085ca0cb"), new Guid("3c29a377-0a27-48f5-8c24-8e38b12d62a6") },
                    { new Guid("7e15da88-d2c4-49c7-a157-9dd2e302f595"), new Guid("de2275b3-75e1-4ac2-8dd9-517d03036f36"), new Guid("9f496fc8-f0a3-4fbc-ba3c-4b5ad6b1f5f9") },
                    { new Guid("7f3531e2-ec0e-4a71-84c4-f4bbefedea96"), new Guid("fba2d8ac-f067-49c5-b80a-4c4c3baf659f"), new Guid("3c29a377-0a27-48f5-8c24-8e38b12d62a6") },
                    { new Guid("7f653831-b3b1-46ae-9035-882b4009314a"), new Guid("88be7be6-91e9-44e0-9df7-153265e68630"), new Guid("ec621f95-910e-4586-9303-0c73ef593ad9") },
                    { new Guid("82f98c33-0261-4b2d-8b07-bfbeca562dc9"), new Guid("1786885f-22a9-49dc-911e-64e2c9259b39"), new Guid("1f642298-3c46-4f91-9e19-5bb32ba4daae") },
                    { new Guid("834952b8-811d-43d5-8f0f-717b55c86027"), new Guid("0daed55c-208b-4c81-9b27-0b422763f629"), new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184") },
                    { new Guid("84020ba0-7d0a-4e0d-b660-785288276bc1"), new Guid("88be7be6-91e9-44e0-9df7-153265e68630"), new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9") },
                    { new Guid("863017bd-52a5-4657-8c03-a0d6988e9d31"), new Guid("27b9f3bf-9a47-4c12-b743-4d9d95bfca40"), new Guid("e9ce39fd-fbbe-478b-97f4-c9226b3abf44") },
                    { new Guid("87a27699-283c-47ed-968e-46f0010c794d"), new Guid("2fbeccd8-5105-4153-b7a5-f1e92128e9a8"), new Guid("1e877278-d960-441b-a948-f5daf2eef49b") },
                    { new Guid("88111a0d-6601-4e88-be8b-66dd87fd1904"), new Guid("42bb3c76-fdc7-4764-b425-eded5c7ec7a5"), new Guid("6fdda566-38d3-472f-ad74-f4f72a6c9bf8") },
                    { new Guid("8942e924-cdb9-4e7b-9267-d9955dbfcca8"), new Guid("ac0e964e-6ed9-48c0-ab1b-0b3ca159f79c"), new Guid("3c29a377-0a27-48f5-8c24-8e38b12d62a6") },
                    { new Guid("8a0ec8e9-06ac-4500-bc51-af8c6ce89e89"), new Guid("3ddce316-dc79-4a01-af69-ee9d11e460b0"), new Guid("1e877278-d960-441b-a948-f5daf2eef49b") },
                    { new Guid("8b00848b-d275-4797-8440-fd29fbad8299"), new Guid("070ce240-1ffe-40c6-9e33-f583aa6996ef"), new Guid("9f496fc8-f0a3-4fbc-ba3c-4b5ad6b1f5f9") },
                    { new Guid("8cf96c93-2bcc-4f58-aa78-5cf9ded150ed"), new Guid("7ac1e919-3d07-4223-8a95-8826bd5b7396"), new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184") },
                    { new Guid("8f1f64c2-c55d-453a-a6c7-36170243d8e8"), new Guid("f928e406-0d48-445f-afb7-44613d593491"), new Guid("e3668814-9cad-43d6-9b01-68c3fd7d4f6e") },
                    { new Guid("91561a37-e8a4-4c33-8a25-fe22474b4f9e"), new Guid("b2fc4f55-9987-4f53-b4ac-8dbb95273098"), new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9") },
                    { new Guid("91a98893-4bdb-435e-bdd5-f5d91dab145c"), new Guid("11819aa5-5e78-4ca5-9ce3-d968769fdc62"), new Guid("9f496fc8-f0a3-4fbc-ba3c-4b5ad6b1f5f9") },
                    { new Guid("94512428-671b-477e-a529-1c40ac72dfbc"), new Guid("1c65186e-2ac9-407c-9ecc-5c19adf14971"), new Guid("e4d8ef07-7c3c-4806-aed1-64cbe940b603") },
                    { new Guid("96daff3f-01d1-45d0-9129-ef666659bcad"), new Guid("8cf7ac57-23e1-4f40-83a0-99bf90c6ea87"), new Guid("e3668814-9cad-43d6-9b01-68c3fd7d4f6e") },
                    { new Guid("976b4899-11ee-4e63-ad20-04e3b6c81477"), new Guid("95db66ed-a0fd-4648-867c-9b72fa10ece4"), new Guid("1e877278-d960-441b-a948-f5daf2eef49b") },
                    { new Guid("97b39df7-ab73-4fb0-9403-674684cdc039"), new Guid("11819aa5-5e78-4ca5-9ce3-d968769fdc62"), new Guid("e3668814-9cad-43d6-9b01-68c3fd7d4f6e") },
                    { new Guid("98be9015-1d8d-4031-a11b-9b792cc05346"), new Guid("6691a6c5-9e60-4aaa-9185-3bb1d2ecf762"), new Guid("bacb50bd-f61b-4508-a550-783c6fd927ab") },
                    { new Guid("99e2893c-a42c-4407-aec9-05d8bdfbbab9"), new Guid("bd363546-2c17-455c-ba96-58c661341529"), new Guid("1f642298-3c46-4f91-9e19-5bb32ba4daae") },
                    { new Guid("9a8d9cdc-001d-4a96-be98-a4f15f182ffe"), new Guid("ff9d8505-010a-477e-96d8-6163b607f361"), new Guid("fcea3830-4848-4bfa-a262-40e31f72f4f9") },
                    { new Guid("9a946417-7ef9-4351-97fc-0c9ab4a1553a"), new Guid("724838c7-91ba-4944-93fe-736a6694a34d"), new Guid("e3668814-9cad-43d6-9b01-68c3fd7d4f6e") },
                    { new Guid("9b01cd03-657c-4db8-98ac-581caa36fc88"), new Guid("51b09774-5c33-419b-ab50-eb348502b5b5"), new Guid("e9ce39fd-fbbe-478b-97f4-c9226b3abf44") },
                    { new Guid("9c80cecd-4358-42b4-8fd4-c4ac0290dde1"), new Guid("ae5080fa-7392-4c23-bdf3-3b0a085ca0cb"), new Guid("e3668814-9cad-43d6-9b01-68c3fd7d4f6e") },
                    { new Guid("9d321838-d4fe-4640-942e-8ce19032bb8b"), new Guid("1c40e4ee-4a7e-448e-93bf-9af5917bbabe"), new Guid("bacb50bd-f61b-4508-a550-783c6fd927ab") },
                    { new Guid("9e959cbf-8505-409f-8596-ea97a8b32d23"), new Guid("44610089-2493-4587-a13d-b10e6db6ac91"), new Guid("91a38df8-4a4e-4c95-9881-bb303756b6f7") },
                    { new Guid("9fbaa40e-c146-41ff-a7fb-3b4eb43d58a2"), new Guid("43446cbb-25eb-4369-a206-1164474484d9"), new Guid("1e877278-d960-441b-a948-f5daf2eef49b") },
                    { new Guid("a028593d-1eb8-41bd-8551-5d7af62a26fd"), new Guid("de9bd874-d6b6-4af5-8dcb-bb697da278e0"), new Guid("ca85fb70-39f2-4cba-b321-1413fd2f365f") },
                    { new Guid("a076186c-7365-41b9-adea-9a662b431cf6"), new Guid("9b4a6ced-4884-479f-b2b4-e1894ffaf243"), new Guid("1f642298-3c46-4f91-9e19-5bb32ba4daae") },
                    { new Guid("a15c45da-e045-4322-8bf7-2bb99182dcc8"), new Guid("b4d3f58d-3a3c-4f99-88e1-03c7b7f07364"), new Guid("004b50af-cfbc-486f-a030-46bf36d4e62d") },
                    { new Guid("a1c87a44-71e2-4646-b576-90bbaa58dedd"), new Guid("dae7bc3e-ef46-4ddf-a082-a22bda4093df"), new Guid("004b50af-cfbc-486f-a030-46bf36d4e62d") },
                    { new Guid("a20296c9-b8a9-4160-942c-9a788f72da80"), new Guid("b4d3f58d-3a3c-4f99-88e1-03c7b7f07364"), new Guid("ca85fb70-39f2-4cba-b321-1413fd2f365f") },
                    { new Guid("a2f95b8e-5540-4168-944f-0229b5023e10"), new Guid("11819aa5-5e78-4ca5-9ce3-d968769fdc62"), new Guid("d089f6ba-dd18-4243-93b5-186a3f9159ed") },
                    { new Guid("a30f5595-d983-49d3-8d91-9c8b695216ce"), new Guid("2fbeccd8-5105-4153-b7a5-f1e92128e9a8"), new Guid("91a38df8-4a4e-4c95-9881-bb303756b6f7") },
                    { new Guid("a57c32fe-35a2-4669-b1b8-3af1e8a522bf"), new Guid("a476f5eb-91af-48df-8337-180435e42e79"), new Guid("6fdda566-38d3-472f-ad74-f4f72a6c9bf8") },
                    { new Guid("a5b4517a-e5c6-4aa9-8c30-23ffb0a70b3a"), new Guid("dae7bc3e-ef46-4ddf-a082-a22bda4093df"), new Guid("e3668814-9cad-43d6-9b01-68c3fd7d4f6e") },
                    { new Guid("a64e7d38-542a-495c-9729-23b0937cf077"), new Guid("550ab457-54d2-44a4-8978-af3f9e97b906"), new Guid("004b50af-cfbc-486f-a030-46bf36d4e62d") },
                    { new Guid("a6f479b9-7032-4738-8340-8b24ec39b8b6"), new Guid("8cf7ac57-23e1-4f40-83a0-99bf90c6ea87"), new Guid("ec621f95-910e-4586-9303-0c73ef593ad9") },
                    { new Guid("a719e6b2-6fe7-40b3-b013-cf46377850ac"), new Guid("51b09774-5c33-419b-ab50-eb348502b5b5"), new Guid("e4d8ef07-7c3c-4806-aed1-64cbe940b603") },
                    { new Guid("a7682b06-869b-48f2-b0e5-a478edaa3bd0"), new Guid("6d669948-f5b5-4892-a0b8-a680591ddf4c"), new Guid("6fdda566-38d3-472f-ad74-f4f72a6c9bf8") },
                    { new Guid("a8509c21-89c3-445d-b104-080233cada63"), new Guid("11cb8fb1-b388-4f48-ad8a-101ccfd652ca"), new Guid("fcea3830-4848-4bfa-a262-40e31f72f4f9") },
                    { new Guid("a8acba3a-ca07-4dfb-86bd-dcd705a8fbd2"), new Guid("ff9d8505-010a-477e-96d8-6163b607f361"), new Guid("e9ce39fd-fbbe-478b-97f4-c9226b3abf44") },
                    { new Guid("a8d7b5e4-02f3-460e-bc9d-ccc3bbae9a75"), new Guid("0daed55c-208b-4c81-9b27-0b422763f629"), new Guid("9f496fc8-f0a3-4fbc-ba3c-4b5ad6b1f5f9") },
                    { new Guid("a8fb764e-4d6b-4a14-9dd2-b047f4671ea6"), new Guid("bf6de7a9-4bd5-48ff-9267-f9d043c8c691"), new Guid("1f642298-3c46-4f91-9e19-5bb32ba4daae") },
                    { new Guid("ab9e91e7-adae-4492-b641-feb4407f7f35"), new Guid("109684b8-4a63-44c6-a669-a84ce1636701"), new Guid("3c29a377-0a27-48f5-8c24-8e38b12d62a6") },
                    { new Guid("aba5d4b1-5d1f-4f3a-8cf7-ac8f6a5359ab"), new Guid("2eb17d89-cc1b-4e15-856b-aa611d7d7561"), new Guid("d089f6ba-dd18-4243-93b5-186a3f9159ed") },
                    { new Guid("ac5f51ec-eea8-4aec-9f9a-93a478f80303"), new Guid("7ac1e919-3d07-4223-8a95-8826bd5b7396"), new Guid("e9ce39fd-fbbe-478b-97f4-c9226b3abf44") },
                    { new Guid("acf04327-526d-4724-876b-52893421fd54"), new Guid("4cd32d47-f0e3-4510-a9a9-02be7d63a663"), new Guid("ec621f95-910e-4586-9303-0c73ef593ad9") },
                    { new Guid("ad622d42-b13e-4b09-97b3-44b01a372cbe"), new Guid("22b386a2-71f5-4e91-9b55-879449b93fa3"), new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184") },
                    { new Guid("afa603c3-7c88-4926-8fd9-45ba7ffdf441"), new Guid("724838c7-91ba-4944-93fe-736a6694a34d"), new Guid("ec621f95-910e-4586-9303-0c73ef593ad9") },
                    { new Guid("afcefc31-49f5-4e22-9459-1ed74e56cd3a"), new Guid("22b386a2-71f5-4e91-9b55-879449b93fa3"), new Guid("ca85fb70-39f2-4cba-b321-1413fd2f365f") },
                    { new Guid("b06c8557-1b6e-43b7-9658-072a893805b9"), new Guid("edc2a38c-a04f-4359-87b6-0a8d0e3c5945"), new Guid("1e877278-d960-441b-a948-f5daf2eef49b") },
                    { new Guid("b1bc803a-0794-4453-a077-fa0625f7d9df"), new Guid("4d30f7f2-6ab0-45de-8d02-38654ef1b2af"), new Guid("004b50af-cfbc-486f-a030-46bf36d4e62d") },
                    { new Guid("b1f1dbbf-673d-4a93-9033-eef721cc1c43"), new Guid("81a1f67d-362e-4498-af82-511fae47f397"), new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184") },
                    { new Guid("b20da405-3dab-431c-8336-11b77511ab9b"), new Guid("d8f006e2-4190-45d3-88e3-807af1c70892"), new Guid("87d93f4b-3ff8-4ae2-a46e-e382b96241bc") },
                    { new Guid("b21e0d76-d3ae-40ca-a9df-a29a6d9fdfff"), new Guid("1348d155-aaca-4cf0-a7f7-bc20023cf6fe"), new Guid("91a38df8-4a4e-4c95-9881-bb303756b6f7") },
                    { new Guid("b2808bda-8d78-4c38-be83-802a77ea1d01"), new Guid("bf45df62-3235-430b-9da6-9127f6392f38"), new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184") },
                    { new Guid("b2c09345-a255-4f4c-acc0-af2d777dfb87"), new Guid("a11030bb-5f6f-4728-8399-61bee3c112b1"), new Guid("9f496fc8-f0a3-4fbc-ba3c-4b5ad6b1f5f9") },
                    { new Guid("b2c5b8b9-1569-4351-8f8f-01636097a876"), new Guid("a11030bb-5f6f-4728-8399-61bee3c112b1"), new Guid("e4d8ef07-7c3c-4806-aed1-64cbe940b603") },
                    { new Guid("b30bc4fc-b9ab-4298-af74-232f51f4d1b3"), new Guid("e7fafe10-a996-49a4-9ea1-31603948882f"), new Guid("e4d8ef07-7c3c-4806-aed1-64cbe940b603") },
                    { new Guid("b4a4b256-e01b-4645-a11e-1b7d0a947bc1"), new Guid("2a62e954-cdf9-4460-9b53-9e85591b3912"), new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9") },
                    { new Guid("b666adfe-fd74-4fe8-9dbe-d229c20a4572"), new Guid("d8f006e2-4190-45d3-88e3-807af1c70892"), new Guid("1e877278-d960-441b-a948-f5daf2eef49b") },
                    { new Guid("b67670dd-f91b-4e6e-9908-ea1ed14e228b"), new Guid("51b09774-5c33-419b-ab50-eb348502b5b5"), new Guid("3c29a377-0a27-48f5-8c24-8e38b12d62a6") },
                    { new Guid("b7645c34-09c6-474f-ab2c-75370450766c"), new Guid("3118878f-3520-4c39-af9f-e22246946d1b"), new Guid("9f496fc8-f0a3-4fbc-ba3c-4b5ad6b1f5f9") },
                    { new Guid("b802ca69-10d1-4fc1-930a-47e8854938d0"), new Guid("1c65186e-2ac9-407c-9ecc-5c19adf14971"), new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9") },
                    { new Guid("b941b336-bc6f-4c29-bdc3-716255cef070"), new Guid("d8f006e2-4190-45d3-88e3-807af1c70892"), new Guid("e4d8ef07-7c3c-4806-aed1-64cbe940b603") },
                    { new Guid("bbbd9e58-10b9-4b20-add4-51b8e8b8013f"), new Guid("b9301777-7afc-4f5a-824c-e5dbf2a1a063"), new Guid("d089f6ba-dd18-4243-93b5-186a3f9159ed") },
                    { new Guid("bbffc636-82d4-40f3-9c90-8b1b879872c8"), new Guid("3ddce316-dc79-4a01-af69-ee9d11e460b0"), new Guid("19011554-1b19-4f83-a76a-b2355790e78b") },
                    { new Guid("becf68e0-a668-4c5f-ac51-9f20a2cb9c43"), new Guid("1fcab780-7679-4d4c-bcd1-7e1d0f378ed5"), new Guid("e4d8ef07-7c3c-4806-aed1-64cbe940b603") },
                    { new Guid("bf2b9981-1fac-4832-8126-86075d7da6a9"), new Guid("d8137db2-aba4-4992-84aa-ad97e419acc1"), new Guid("3c29a377-0a27-48f5-8c24-8e38b12d62a6") },
                    { new Guid("bf65a428-6753-4f57-b2b3-fbf86ac9da3e"), new Guid("543bf592-149d-4f0d-abd1-35fcfc25e18b"), new Guid("6fdda566-38d3-472f-ad74-f4f72a6c9bf8") },
                    { new Guid("c15732eb-1575-45ef-b9c6-edcfd86f197d"), new Guid("6691a6c5-9e60-4aaa-9185-3bb1d2ecf762"), new Guid("91a38df8-4a4e-4c95-9881-bb303756b6f7") },
                    { new Guid("c1eef6a7-5b32-4286-865c-fa59bfd45ca5"), new Guid("fba2d8ac-f067-49c5-b80a-4c4c3baf659f"), new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9") },
                    { new Guid("c3a9b54a-39ff-4c9f-a022-b1ab69e048d6"), new Guid("1348d155-aaca-4cf0-a7f7-bc20023cf6fe"), new Guid("1f642298-3c46-4f91-9e19-5bb32ba4daae") },
                    { new Guid("c430388b-4c8e-498b-87ea-a182a66347b9"), new Guid("0daed55c-208b-4c81-9b27-0b422763f629"), new Guid("004b50af-cfbc-486f-a030-46bf36d4e62d") },
                    { new Guid("c5fef073-6bcc-4912-adba-dbd6b8ba25e2"), new Guid("926c8cb3-e594-4a8a-b2f2-7af1de3e98d9"), new Guid("3c29a377-0a27-48f5-8c24-8e38b12d62a6") },
                    { new Guid("c637cbd2-ac3f-400d-9267-f37cddb04393"), new Guid("b9301777-7afc-4f5a-824c-e5dbf2a1a063"), new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9") },
                    { new Guid("c7330fa6-2d9a-4bb6-9e98-684f52d79bd6"), new Guid("8cf7ac57-23e1-4f40-83a0-99bf90c6ea87"), new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184") },
                    { new Guid("c73fa445-25f6-4866-9311-081ae53e4b0f"), new Guid("81a1f67d-362e-4498-af82-511fae47f397"), new Guid("ec621f95-910e-4586-9303-0c73ef593ad9") },
                    { new Guid("c8ad3d44-8b8a-4204-b486-a7f8d1931fd3"), new Guid("2a62e954-cdf9-4460-9b53-9e85591b3912"), new Guid("9f496fc8-f0a3-4fbc-ba3c-4b5ad6b1f5f9") },
                    { new Guid("c952040d-a30f-4ddb-b228-101c1bd4cbc2"), new Guid("4cd32d47-f0e3-4510-a9a9-02be7d63a663"), new Guid("9f496fc8-f0a3-4fbc-ba3c-4b5ad6b1f5f9") },
                    { new Guid("c9857ea6-7155-4788-988f-af4b04d92016"), new Guid("dae7bc3e-ef46-4ddf-a082-a22bda4093df"), new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184") },
                    { new Guid("caf19498-bbbc-4941-9312-1ec381d128e5"), new Guid("70556cfa-8f85-444c-b14d-6d3d0560f9f1"), new Guid("d089f6ba-dd18-4243-93b5-186a3f9159ed") },
                    { new Guid("cbb64cd1-0cd1-4e5b-b02d-acfe2da64870"), new Guid("70556cfa-8f85-444c-b14d-6d3d0560f9f1"), new Guid("9f496fc8-f0a3-4fbc-ba3c-4b5ad6b1f5f9") },
                    { new Guid("cc6f82f2-18f5-479d-9079-e0319fa136c8"), new Guid("62d512f3-dc02-4ec5-b48f-6d0da7d736f9"), new Guid("004b50af-cfbc-486f-a030-46bf36d4e62d") },
                    { new Guid("ccdd249e-2b7e-4afe-9bdb-25a192b1e149"), new Guid("9e0d176c-2fa4-4691-a910-431d9dc35a2f"), new Guid("e9ce39fd-fbbe-478b-97f4-c9226b3abf44") },
                    { new Guid("cd252e12-7d7a-4b0d-a8c6-1da7d798bb90"), new Guid("36be2138-3096-4e06-9e21-6c75238e1a1d"), new Guid("d089f6ba-dd18-4243-93b5-186a3f9159ed") },
                    { new Guid("ce707b78-d7ca-459a-966a-9e61790f7811"), new Guid("543bf592-149d-4f0d-abd1-35fcfc25e18b"), new Guid("ca85fb70-39f2-4cba-b321-1413fd2f365f") },
                    { new Guid("d01dc10f-0b9d-4521-97e2-37d8335835cf"), new Guid("0096365a-4330-4ba1-90cc-882ec5fd2983"), new Guid("ca85fb70-39f2-4cba-b321-1413fd2f365f") },
                    { new Guid("d0a85244-3ba1-49cf-9a9b-411334d13a93"), new Guid("980eb01d-472c-4525-8331-2936823ddd42"), new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9") },
                    { new Guid("d13e3082-b919-4528-acd2-4b3151e04190"), new Guid("74af42fd-5c4c-496f-8579-d08c65bfb595"), new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184") },
                    { new Guid("d2fcd117-ded9-4d55-8a6b-d6a5b5039a5e"), new Guid("082bc7b3-5ea9-4e9c-8426-e079479d13cc"), new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9") },
                    { new Guid("d3348247-3c12-463f-85cf-4f3d2b2bd72c"), new Guid("082bc7b3-5ea9-4e9c-8426-e079479d13cc"), new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184") },
                    { new Guid("d4d12f1d-30b1-41dd-b901-67ca17db3181"), new Guid("a476f5eb-91af-48df-8337-180435e42e79"), new Guid("9f496fc8-f0a3-4fbc-ba3c-4b5ad6b1f5f9") },
                    { new Guid("d5ece201-0d28-482f-92ac-8516f4672334"), new Guid("42bb3c76-fdc7-4764-b425-eded5c7ec7a5"), new Guid("91a38df8-4a4e-4c95-9881-bb303756b6f7") },
                    { new Guid("d641efc7-3541-4c2f-aa9a-c251c57e7c1d"), new Guid("a590fe7d-6ff7-4541-b8c9-9fbe0d31735a"), new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184") },
                    { new Guid("d686670d-f24f-4165-b61a-2fa3967a56ed"), new Guid("2fbeccd8-5105-4153-b7a5-f1e92128e9a8"), new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9") },
                    { new Guid("d6cb7806-0a4b-4eab-bd27-38e1a9ee4b04"), new Guid("e8d3d68a-4c06-4eee-9c5e-fe04575db022"), new Guid("e9ce39fd-fbbe-478b-97f4-c9226b3abf44") },
                    { new Guid("d83c943c-3ccb-4371-b970-628925b592c0"), new Guid("9b4a6ced-4884-479f-b2b4-e1894ffaf243"), new Guid("87d93f4b-3ff8-4ae2-a46e-e382b96241bc") },
                    { new Guid("d899a902-908b-4da1-9bb9-7bd72d9cf3e5"), new Guid("81a80af5-a1df-4d3a-9973-161446038bb2"), new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184") },
                    { new Guid("da5344d5-23db-4728-9985-f3d73befda14"), new Guid("f25a412f-fdf8-4b5d-9381-64f2452e39b9"), new Guid("3c29a377-0a27-48f5-8c24-8e38b12d62a6") },
                    { new Guid("dac95288-eec3-4cd4-8cde-b8b4c28d8c04"), new Guid("667b77c4-6299-4d6a-8038-03c8a1d88d49"), new Guid("fcea3830-4848-4bfa-a262-40e31f72f4f9") },
                    { new Guid("ddd018ab-8ed3-448d-882a-5edb6091e52b"), new Guid("ada561f0-a5de-4ee5-a15f-aec4cf5abbbf"), new Guid("6fdda566-38d3-472f-ad74-f4f72a6c9bf8") },
                    { new Guid("dde28d89-bb08-43bd-ade1-98d97e845441"), new Guid("a590fe7d-6ff7-4541-b8c9-9fbe0d31735a"), new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184") },
                    { new Guid("deeb134b-2a66-4264-95dd-c5a7c9216450"), new Guid("81a80af5-a1df-4d3a-9973-161446038bb2"), new Guid("004b50af-cfbc-486f-a030-46bf36d4e62d") },
                    { new Guid("dfd24015-37c7-43da-a924-567b95b5f602"), new Guid("de2275b3-75e1-4ac2-8dd9-517d03036f36"), new Guid("e4d8ef07-7c3c-4806-aed1-64cbe940b603") },
                    { new Guid("e084c0be-d18a-4be4-96dd-6c70155c7188"), new Guid("3ff43ae2-ffd9-4b24-acdd-471ebb5101be"), new Guid("d089f6ba-dd18-4243-93b5-186a3f9159ed") },
                    { new Guid("e13792a9-7727-49e2-9f0c-aaa5242bf8d4"), new Guid("ab5262ae-973c-4850-9213-c56363b2fcfb"), new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184") },
                    { new Guid("e14d80d8-c7ce-4a7b-a486-dfa5741a3366"), new Guid("aabfacee-23f9-4810-b714-a0f76ab50c41"), new Guid("fcea3830-4848-4bfa-a262-40e31f72f4f9") },
                    { new Guid("e1f7a9ba-2b42-4010-8839-ecc244a52bf8"), new Guid("ab5262ae-973c-4850-9213-c56363b2fcfb"), new Guid("19011554-1b19-4f83-a76a-b2355790e78b") },
                    { new Guid("e2104e7c-55ad-43bf-9860-05923cfca2f0"), new Guid("de9bd874-d6b6-4af5-8dcb-bb697da278e0"), new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9") },
                    { new Guid("e249e2a0-f4d0-43bc-acb7-d727c67e5c59"), new Guid("5981392d-cdf1-42d5-be5a-6b129e53efed"), new Guid("e4d8ef07-7c3c-4806-aed1-64cbe940b603") },
                    { new Guid("e39d0f16-6a6d-47a4-af17-70294c958cee"), new Guid("fe9e0ddc-c142-42c1-833d-bbb0808ae00c"), new Guid("bacb50bd-f61b-4508-a550-783c6fd927ab") },
                    { new Guid("e48dcd8d-29d4-4bb0-a23b-039497eb46a0"), new Guid("7d87dded-e930-4d38-86f2-e85d07854116"), new Guid("ca85fb70-39f2-4cba-b321-1413fd2f365f") },
                    { new Guid("e50cce81-546b-4dcd-b247-e68f5b53a585"), new Guid("9e0d176c-2fa4-4691-a910-431d9dc35a2f"), new Guid("d089f6ba-dd18-4243-93b5-186a3f9159ed") },
                    { new Guid("e672d363-1138-4bdb-aa90-e0b07d16d0f7"), new Guid("43446cbb-25eb-4369-a206-1164474484d9"), new Guid("87f630bc-a01c-4553-b9fa-74c7bf5341f9") },
                    { new Guid("e6dd5e10-9c8b-44b5-b24c-f2c8cfebb48f"), new Guid("724838c7-91ba-4944-93fe-736a6694a34d"), new Guid("004b50af-cfbc-486f-a030-46bf36d4e62d") },
                    { new Guid("e79d0467-c74f-40f9-98ab-251b8b598b7b"), new Guid("53d7a21f-05f4-4bda-8058-693923dca93c"), new Guid("9f496fc8-f0a3-4fbc-ba3c-4b5ad6b1f5f9") },
                    { new Guid("e7e744a9-8cbb-4274-b674-78b87e7fc039"), new Guid("a49382d9-e348-46a4-9771-3a0ee5dba823"), new Guid("fcea3830-4848-4bfa-a262-40e31f72f4f9") },
                    { new Guid("e8fccdb8-b64c-43fe-9e24-66e0504692cf"), new Guid("3118878f-3520-4c39-af9f-e22246946d1b"), new Guid("e4d8ef07-7c3c-4806-aed1-64cbe940b603") },
                    { new Guid("ea02dcf5-672e-478a-b045-ac5538021a16"), new Guid("08b80e81-7a41-4d17-adbd-b2743dbf32c9"), new Guid("e3668814-9cad-43d6-9b01-68c3fd7d4f6e") },
                    { new Guid("ea3943a5-fddf-4f9d-a36a-875373a4dcf5"), new Guid("0d042a50-bcb2-4780-ab3e-adf232e3e7cf"), new Guid("ca85fb70-39f2-4cba-b321-1413fd2f365f") },
                    { new Guid("eb0f7361-84a0-4ca5-a680-f319c7fe42ac"), new Guid("de9bd874-d6b6-4af5-8dcb-bb697da278e0"), new Guid("91a38df8-4a4e-4c95-9881-bb303756b6f7") },
                    { new Guid("eb4922ac-dcf1-45c9-8004-6ed8c6b39958"), new Guid("4d30f7f2-6ab0-45de-8d02-38654ef1b2af"), new Guid("19011554-1b19-4f83-a76a-b2355790e78b") },
                    { new Guid("eb7eec6f-6788-4275-bf2b-12a0208838b7"), new Guid("8f36b6ca-e302-41ac-acdf-1ee00eee9bd7"), new Guid("19011554-1b19-4f83-a76a-b2355790e78b") },
                    { new Guid("ec60e009-152e-4e87-b691-b2217f647d4b"), new Guid("5b8e4ee6-644b-4405-baf2-7228c014bfbd"), new Guid("87d93f4b-3ff8-4ae2-a46e-e382b96241bc") },
                    { new Guid("edda4bd7-954d-4368-a796-c2b9cf67f2e0"), new Guid("62d512f3-dc02-4ec5-b48f-6d0da7d736f9"), new Guid("3c29a377-0a27-48f5-8c24-8e38b12d62a6") },
                    { new Guid("f07565d0-76f2-4a64-9c46-02827bee2a5e"), new Guid("36be2138-3096-4e06-9e21-6c75238e1a1d"), new Guid("91a38df8-4a4e-4c95-9881-bb303756b6f7") },
                    { new Guid("f27c1942-efa3-4923-8083-531d3e6470fe"), new Guid("1c65186e-2ac9-407c-9ecc-5c19adf14971"), new Guid("91a38df8-4a4e-4c95-9881-bb303756b6f7") },
                    { new Guid("f315d108-d0b0-4f85-8720-ddfddd72e527"), new Guid("3ff43ae2-ffd9-4b24-acdd-471ebb5101be"), new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184") },
                    { new Guid("f39d94ba-1dde-429f-a25e-43d4f889e1ad"), new Guid("ede53097-91d2-437e-9059-4e2df88aa044"), new Guid("87d93f4b-3ff8-4ae2-a46e-e382b96241bc") },
                    { new Guid("f51dc71c-ce3c-44d6-aa06-b6c85851539b"), new Guid("5b8e4ee6-644b-4405-baf2-7228c014bfbd"), new Guid("91a38df8-4a4e-4c95-9881-bb303756b6f7") },
                    { new Guid("f5aade08-aeb7-4c58-803f-ff821d67ef09"), new Guid("543bf592-149d-4f0d-abd1-35fcfc25e18b"), new Guid("bc5c55aa-9a14-49ef-99ab-11b937d4d184") },
                    { new Guid("f5fa8472-4a89-45d0-a5fd-571d8a5795a6"), new Guid("53d7a21f-05f4-4bda-8058-693923dca93c"), new Guid("9f496fc8-f0a3-4fbc-ba3c-4b5ad6b1f5f9") },
                    { new Guid("f65f3d48-8ce3-41af-8bf1-41377cd00f94"), new Guid("fdf74e3d-c810-4daa-a199-05aebbe8783b"), new Guid("1e877278-d960-441b-a948-f5daf2eef49b") },
                    { new Guid("f65f8473-aa53-4ef5-9287-8c974b93df43"), new Guid("fdf74e3d-c810-4daa-a199-05aebbe8783b"), new Guid("e3668814-9cad-43d6-9b01-68c3fd7d4f6e") },
                    { new Guid("f6ed6565-603e-4b9c-ba35-875e9ca7f230"), new Guid("df299f5a-b161-4d03-9226-5c3a4a433ca9"), new Guid("87d93f4b-3ff8-4ae2-a46e-e382b96241bc") },
                    { new Guid("f74a3954-5326-4795-846e-264f102dffe9"), new Guid("9b4a6ced-4884-479f-b2b4-e1894ffaf243"), new Guid("9f496fc8-f0a3-4fbc-ba3c-4b5ad6b1f5f9") },
                    { new Guid("f7b76885-0518-4900-ab2f-5770d07cd15f"), new Guid("38e4e090-4918-42d4-9341-f5b6e540a4ec"), new Guid("3c29a377-0a27-48f5-8c24-8e38b12d62a6") },
                    { new Guid("f8823a8f-0fc5-44d5-bb7e-507fa25c162e"), new Guid("5981392d-cdf1-42d5-be5a-6b129e53efed"), new Guid("fcea3830-4848-4bfa-a262-40e31f72f4f9") },
                    { new Guid("fa3acf5a-f5d6-4ed3-bf68-74da3efc7ca6"), new Guid("0e60231b-8bf2-47b7-9119-262bfec4a1fe"), new Guid("e3668814-9cad-43d6-9b01-68c3fd7d4f6e") },
                    { new Guid("fa42cbdc-e6fd-428b-9a9b-0146d27ad32a"), new Guid("796140a3-84b7-45f7-96b0-049a78996f52"), new Guid("1e877278-d960-441b-a948-f5daf2eef49b") },
                    { new Guid("fbed012b-fe23-40e0-957f-75807a7b9073"), new Guid("aa2acc11-63ba-49d9-ad9a-f07657b3a038"), new Guid("ca85fb70-39f2-4cba-b321-1413fd2f365f") },
                    { new Guid("fc108f84-0dbf-4700-a351-f7169016028a"), new Guid("0096365a-4330-4ba1-90cc-882ec5fd2983"), new Guid("bacb50bd-f61b-4508-a550-783c6fd927ab") },
                    { new Guid("fc3a1c76-091b-44a4-ab1b-2a877cdd6285"), new Guid("aa2acc11-63ba-49d9-ad9a-f07657b3a038"), new Guid("3c29a377-0a27-48f5-8c24-8e38b12d62a6") },
                    { new Guid("fc96f124-e809-4992-9987-48f1a29da246"), new Guid("11cb8fb1-b388-4f48-ad8a-101ccfd652ca"), new Guid("6fdda566-38d3-472f-ad74-f4f72a6c9bf8") },
                    { new Guid("fe39f2bf-1837-46fe-b996-fe721afb9812"), new Guid("2eb17d89-cc1b-4e15-856b-aa611d7d7561"), new Guid("1e877278-d960-441b-a948-f5daf2eef49b") }
                });
        }
    }
}
