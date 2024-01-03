using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PetsFIle.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentityUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Pets_PetId",
                table: "Photo");

            migrationBuilder.DropIndex(
                name: "IX_Photo_PetId",
                table: "Photo");

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

            migrationBuilder.AddColumn<Guid>(
                name: "PetId1",
                table: "Photo",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Photo_PetId1",
                table: "Photo",
                column: "PetId1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Pets_PetId1",
                table: "Photo",
                column: "PetId1",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Pets_PetId1",
                table: "Photo");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_Photo_PetId1",
                table: "Photo");

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

            migrationBuilder.DropColumn(
                name: "PetId1",
                table: "Photo");

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

            migrationBuilder.CreateIndex(
                name: "IX_Photo_PetId",
                table: "Photo",
                column: "PetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Pets_PetId",
                table: "Photo",
                column: "PetId",
                principalTable: "Pets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
