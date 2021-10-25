﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Text" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Quote" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Link" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, "Kitty", "Cat ipsum dolor sit amet, then cats take over the world yet please stop looking at your phone and pet me slap owner's face at 5am until human fills food dish sleep over your phone and make cute snoring noises. Lies down chase laser or bite nose of your human missing until dinner time dream about hunting birds. Chew foot leave fur on owners clothes, but thinking longingly about tuna brine and spread kitty litter all over house shake treat bag. Eat owner's food i could pee on this if i had the energy. Annoy owner until he gives you food say meow repeatedly until belly rubs, feels good sugar, my siamese, stalks me (in a good way), day and night or sniff catnip and act crazy yet hey! you there, with the hands, so i will ruin the couch with my claws or claw your carpet in places everyone can see - why hide my amazing artistic clawing skills?. Mesmerizing birds your pillow is now my pet bed fooled again thinking the dog likes me try to hold own back foot to clean it but foot reflexively kicks you in face, go into a rage and bite own foot, hard jump on fridge scratch scratch my tummy actually i hate you now fight me.", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lyonel is sick ):" },
                    { 3, "Zombie", "Zombie ipsum reversus ab viral inferno, nam rick grimes malum cerebro. De carne lumbering animata corpora quaeritis. Summus brains sit​​, morbo vel maleficia? De apocalypsi gorger omero undead survivor dictum mauris. Hi mindless mortuis soulless creaturas, imo evil stalking monstra adventus resi dentevil vultus comedat cerebella viventium. Qui animated corpse, cricket bat max brucks terribilem incessu zomby. The voodoo sacerdos flesh eater, suscitat mortuos comedere carnem virus. Zonbi tattered for solum oculi eorum defunctis go lum cerebro. Nescio brains an Undead zombies. Sicut malus putrid voodoo horror. Nigh tofth eliv ingdead.", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Got a new job!" },
                    { 4, "Kitty", "Chase laser cats go for world domination rub face on everything push your water glass on the floor making bread on the bathrobe ooh, are those your $250 dollar sandals? lemme use that as my litter box. Do i like standing on litter cuz i sits when i have spaces, my cat buddies have no litter i live in luxury cat life cat not kitten around drink water out of the faucet or i do no work yet get food, shelter, and lots of stuff just like man who lives with us and fight an alligator and win or claw your carpet in places everyone can see - why hide my amazing artistic clawing skills? relentlessly pursues moth. do not try to mix old food with new one to fool me! jump on fridge or give me some of your food give me some of your food give me some of your food meh, i don't want it intently stare at the same spot, and murr i hate humans they are so annoying yet furball roll roll roll. Decide to want nothing to do with my owner today litter box is life, but cough eat a rug and furry furry hairs everywhere oh no human coming lie on counter don't get off counter. Cough hairball on conveniently placed pants all of a sudden cat goes crazy that box?", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lyonel feels better!" },
                    { 5, "Zombie", "Cum horribilem walking dead resurgere de crazed sepulcris creaturis, zombie sicut de grave feeding iride et serpens. Pestilentia, shaun ofthe dead scythe animated corpses ipsa screams. Pestilentia est plague haec decaying ambulabat mortuos. Sicut zeder apathetic malus voodoo. Aenean a dolor plan et terror soulless vulnerum contagium accedunt, mortui iam vivam unlife. Qui tardius moveri, brid eof reanimator sed in magna copia sint terribiles undeath legionis. Alii missing oculis aliorum sicut serpere crabs nostram. Putridi braindead odores kill and infect, aere implent left four dead.", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fired from my new job ):" },
                    { 2, "James SA Corey", "Standing in the belly of the Behemoth, Anna had never guess the Mormons would build something like the massive generation ship. It was so big, so extravagant. It was like a rebellious shout at the emptiness of space. \"The universe is too big for our ship to move through it at a reasonable time? Fine, we'll stuff all the bits of the universe we need inside of our ship and go at our own pace.\" When ancient maritime explorers had climbed into their creaking wooden ships and tried to find ways to cross the great oceans of Earth, had their voyage been any less dangerous than the one the Mormons had been planning to attempt? The end point any less mysterious? But in both cases, they'd been driven to find out what was on the other side of a long trip. Driven by a need to see shores no one else had ever seen before. Show a human a closed door, and no matter how many open doors she finds she'll be haunted by what might be behind it...Anna had walked on a moon of Jupiter. She'd looked up at a dome-covered sky at the great red spot, close enough to see the swirls and eddies of a storm larger than her home world. She'd tasted water thawed from ice as old as the solar system itself. And it was that human dissatisfaction, that human audacity, that had put her there.", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Have you guys ever read the Expanse?" },
                    { 6, "Rick Astley", "https://www.youtube.com/watch?v=dQw4w9WgXcQ", 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "This is Not a Rickroll" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
