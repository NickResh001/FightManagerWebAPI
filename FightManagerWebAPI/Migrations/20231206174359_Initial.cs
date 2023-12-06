using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FightManagerWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ability",
                columns: table => new
                {
                    AbilityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ability", x => x.AbilityId);
                });

            migrationBuilder.CreateTable(
                name: "ActionResource",
                columns: table => new
                {
                    ActionResourceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionResource", x => x.ActionResourceId);
                });

            migrationBuilder.CreateTable(
                name: "Alignment",
                columns: table => new
                {
                    AlignmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Law = table.Column<int>(type: "int", nullable: false),
                    Goodness = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alignment", x => x.AlignmentId);
                });

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
                name: "BeastType",
                columns: table => new
                {
                    BeastTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeastType", x => x.BeastTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Condition",
                columns: table => new
                {
                    ConditionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condition", x => x.ConditionId);
                });

            migrationBuilder.CreateTable(
                name: "CooldownType",
                columns: table => new
                {
                    CooldownTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cooldown", x => x.CooldownTypeId);
                });

            migrationBuilder.CreateTable(
                name: "CreatorsTeam",
                columns: table => new
                {
                    CreatorsTeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    IsCommunityCreators = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatorsTeam", x => x.CreatorsTeamId);
                });

            migrationBuilder.CreateTable(
                name: "DamageTendencyType",
                columns: table => new
                {
                    DamageTendencyTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageTendencyType", x => x.DamageTendencyTypeId);
                });

            migrationBuilder.CreateTable(
                name: "DamageType",
                columns: table => new
                {
                    DamageTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageType", x => x.DamageTypeId);
                });

            migrationBuilder.CreateTable(
                name: "FightTeam",
                columns: table => new
                {
                    FightTeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FightTeam", x => x.FightTeamId);
                });

            migrationBuilder.CreateTable(
                name: "Habitat",
                columns: table => new
                {
                    HabitatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habitat", x => x.HabitatId);
                });

            migrationBuilder.CreateTable(
                name: "Sense",
                columns: table => new
                {
                    SenseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sense", x => x.SenseId);
                });

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    SettingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.SettingId);
                });

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    SizeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.SizeId);
                });

            migrationBuilder.CreateTable(
                name: "Speed",
                columns: table => new
                {
                    SpeedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speed", x => x.SpeedId);
                });

            migrationBuilder.CreateTable(
                name: "TimeMeasure",
                columns: table => new
                {
                    TimeMeasureId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeMeasure", x => x.TimeMeasureId);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AbilityFK = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.SkillId);
                    table.ForeignKey(
                        name: "FK_Skill_Ability",
                        column: x => x.AbilityFK,
                        principalTable: "Ability",
                        principalColumn: "AbilityId");
                });

            migrationBuilder.CreateTable(
                name: "SpellingInfo",
                columns: table => new
                {
                    SpellingInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpellAbilityFK = table.Column<int>(type: "int", nullable: false),
                    SaveThrowDifficulty = table.Column<int>(type: "int", nullable: false),
                    AttackBonus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellingInfo", x => x.SpellingInfoId);
                    table.ForeignKey(
                        name: "FK_SpellingInfo_Ability",
                        column: x => x.SpellAbilityFK,
                        principalTable: "Ability",
                        principalColumn: "AbilityId");
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
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatorsTeamFK = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_CreatorsTeam",
                        column: x => x.CreatorsTeamFK,
                        principalTable: "CreatorsTeam",
                        principalColumn: "CreatorsTeamId");
                });

            migrationBuilder.CreateTable(
                name: "SpellSlot",
                columns: table => new
                {
                    SpellSlotId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpellingInfoFK = table.Column<int>(type: "int", nullable: false),
                    SlotLevel = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellSlot", x => x.SpellSlotId);
                    table.ForeignKey(
                        name: "FK_SpellSlot_SpellingInfo",
                        column: x => x.SpellingInfoFK,
                        principalTable: "SpellingInfo",
                        principalColumn: "SpellingInfoId");
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
                        name: "FK_AspNetUserClaims_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
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
                        name: "FK_AspNetUserLogins_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
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
                        name: "FK_AspNetUserRoles_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
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
                        name: "FK_AspNetUserTokens_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BeastNote",
                columns: table => new
                {
                    BeastNoteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HitPointDice = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    InitiativeBonus = table.Column<int>(type: "int", nullable: false),
                    ArmorClass = table.Column<int>(type: "int", nullable: false),
                    SpecialBonus = table.Column<int>(type: "int", nullable: false),
                    SpellingInfoFK = table.Column<int>(type: "int", nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    AlingmentFK = table.Column<int>(type: "int", nullable: false),
                    SizeFK = table.Column<int>(type: "int", nullable: false),
                    BeastTypeFK = table.Column<int>(type: "int", nullable: false),
                    UserFK = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChallengeRating = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    CreationDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EditingDate = table.Column<DateOnly>(type: "date", nullable: false),
                    AllUses = table.Column<int>(type: "int", nullable: false),
                    ActualUses = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeastNote", x => x.BeastNoteId);
                    table.ForeignKey(
                        name: "FK_BeastNote_Alignment",
                        column: x => x.AlingmentFK,
                        principalTable: "Alignment",
                        principalColumn: "AlignmentId");
                    table.ForeignKey(
                        name: "FK_BeastNote_BeastType",
                        column: x => x.BeastTypeFK,
                        principalTable: "BeastType",
                        principalColumn: "BeastTypeId");
                    table.ForeignKey(
                        name: "FK_BeastNote_Size",
                        column: x => x.SizeFK,
                        principalTable: "Size",
                        principalColumn: "SizeId");
                    table.ForeignKey(
                        name: "FK_BeastNote_SpellingInfo",
                        column: x => x.SpellingInfoFK,
                        principalTable: "SpellingInfo",
                        principalColumn: "SpellingInfoId");
                    table.ForeignKey(
                        name: "FK_BeastNote_User",
                        column: x => x.UserFK,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Scene",
                columns: table => new
                {
                    SceneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    UserFK = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SettingFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scene", x => x.SceneId);
                    table.ForeignKey(
                        name: "FK_Scene_Setting",
                        column: x => x.SettingFK,
                        principalTable: "Setting",
                        principalColumn: "SettingId");
                    table.ForeignKey(
                        name: "FK_Scene_User",
                        column: x => x.UserFK,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AbilityList",
                columns: table => new
                {
                    AbilityListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AbilityFK = table.Column<int>(type: "int", nullable: false),
                    BeastNoteFK = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    SavingThrowProficiency = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityList", x => x.AbilityListId);
                    table.ForeignKey(
                        name: "FK_AbilityList_Ability",
                        column: x => x.AbilityFK,
                        principalTable: "Ability",
                        principalColumn: "AbilityId");
                    table.ForeignKey(
                        name: "FK_AbilityList_BeastNote",
                        column: x => x.BeastNoteFK,
                        principalTable: "BeastNote",
                        principalColumn: "BeastNoteId");
                });

            migrationBuilder.CreateTable(
                name: "Action",
                columns: table => new
                {
                    ActionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeastNoteFK = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    CooldownTypeFK = table.Column<int>(type: "int", nullable: false),
                    Cooldown1_ShellSlotLevel = table.Column<int>(type: "int", nullable: true),
                    Cooldown2_LowerRangeLimit = table.Column<int>(type: "int", nullable: true),
                    Cooldown2_UpperRangeLimit = table.Column<int>(type: "int", nullable: true),
                    Cooldown2_DiceSize = table.Column<int>(type: "int", nullable: true),
                    Cooldown3_HowManyTimes = table.Column<int>(type: "int", nullable: true),
                    Cooldown3_TimeMeasureFK = table.Column<int>(type: "int", nullable: true),
                    Cooldown3_MeasureMultiply = table.Column<int>(type: "int", nullable: true),
                    ActionResourceFK = table.Column<int>(type: "int", nullable: false),
                    Reaction_Condition = table.Column<string>(type: "varchar(1000)", unicode: false, maxLength: 1000, nullable: true),
                    Lair_InitiativeBonus = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "varchar(8000)", unicode: false, maxLength: 8000, nullable: false),
                    ParentMultiactionFK = table.Column<int>(type: "int", nullable: true),
                    IsTemplate = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Action", x => x.ActionId);
                    table.ForeignKey(
                        name: "FK_Action_ActionResource",
                        column: x => x.ActionResourceFK,
                        principalTable: "ActionResource",
                        principalColumn: "ActionResourceId");
                    table.ForeignKey(
                        name: "FK_Action_BeastNote",
                        column: x => x.BeastNoteFK,
                        principalTable: "BeastNote",
                        principalColumn: "BeastNoteId");
                    table.ForeignKey(
                        name: "FK_Action_CooldownType",
                        column: x => x.CooldownTypeFK,
                        principalTable: "CooldownType",
                        principalColumn: "CooldownTypeId");
                    table.ForeignKey(
                        name: "FK_Action_TimeMeasure",
                        column: x => x.Cooldown3_TimeMeasureFK,
                        principalTable: "TimeMeasure",
                        principalColumn: "TimeMeasureId");
                });

            migrationBuilder.CreateTable(
                name: "Beast",
                columns: table => new
                {
                    BeastId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeastNoteFK = table.Column<int>(type: "int", nullable: false),
                    FightTeamFK = table.Column<int>(type: "int", nullable: false),
                    CurrentArmorClass = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    MaxHitPoint = table.Column<int>(type: "int", nullable: false),
                    TemporaryHitPoints = table.Column<int>(type: "int", nullable: false),
                    CurrentInitiative = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beast", x => x.BeastId);
                    table.ForeignKey(
                        name: "FK_Beast_BeastNote",
                        column: x => x.BeastNoteFK,
                        principalTable: "BeastNote",
                        principalColumn: "BeastNoteId");
                    table.ForeignKey(
                        name: "FK_Beast_FightTeam",
                        column: x => x.FightTeamFK,
                        principalTable: "FightTeam",
                        principalColumn: "FightTeamId");
                });

            migrationBuilder.CreateTable(
                name: "ConditionImmuneList",
                columns: table => new
                {
                    ConditionImmuneListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConditionFK = table.Column<int>(type: "int", nullable: false),
                    BeastNoteFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionImmuneList", x => x.ConditionImmuneListId);
                    table.ForeignKey(
                        name: "FK_ConditionImmuneList_BeastNote",
                        column: x => x.BeastNoteFK,
                        principalTable: "BeastNote",
                        principalColumn: "BeastNoteId");
                    table.ForeignKey(
                        name: "FK_ConditionImmuneList_Condition",
                        column: x => x.ConditionFK,
                        principalTable: "Condition",
                        principalColumn: "ConditionId");
                });

            migrationBuilder.CreateTable(
                name: "DamageTendency",
                columns: table => new
                {
                    DamageTendencyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DamageTypeFK = table.Column<int>(type: "int", nullable: false),
                    DamageTendencyTypeFK = table.Column<int>(type: "int", nullable: false),
                    BeastNoteFK = table.Column<int>(type: "int", nullable: false),
                    Magical = table.Column<bool>(type: "bit", nullable: false),
                    NonMagical = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageTendency", x => x.DamageTendencyId);
                    table.ForeignKey(
                        name: "FK_DamageTendency_BeastNote",
                        column: x => x.BeastNoteFK,
                        principalTable: "BeastNote",
                        principalColumn: "BeastNoteId");
                    table.ForeignKey(
                        name: "FK_DamageTendency_DamageTendencyType",
                        column: x => x.DamageTendencyTypeFK,
                        principalTable: "DamageTendencyType",
                        principalColumn: "DamageTendencyTypeId");
                    table.ForeignKey(
                        name: "FK_DamageTendency_DamageType",
                        column: x => x.DamageTypeFK,
                        principalTable: "DamageType",
                        principalColumn: "DamageTypeId");
                });

            migrationBuilder.CreateTable(
                name: "HabitatList",
                columns: table => new
                {
                    HabitatListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HabitatFK = table.Column<int>(type: "int", nullable: false),
                    BeastNoteFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HabitatList", x => x.HabitatListId);
                    table.ForeignKey(
                        name: "FK_HabitatList_BeastNote",
                        column: x => x.BeastNoteFK,
                        principalTable: "BeastNote",
                        principalColumn: "BeastNoteId");
                    table.ForeignKey(
                        name: "FK_HabitatList_Habitat",
                        column: x => x.HabitatFK,
                        principalTable: "Habitat",
                        principalColumn: "HabitatId");
                });

            migrationBuilder.CreateTable(
                name: "SenseList",
                columns: table => new
                {
                    SenseListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenseFK = table.Column<int>(type: "int", nullable: false),
                    BeastNoteFK = table.Column<int>(type: "int", nullable: false),
                    DistanceInFeet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SenseList", x => x.SenseListId);
                    table.ForeignKey(
                        name: "FK_SenseList_BeastNote",
                        column: x => x.BeastNoteFK,
                        principalTable: "BeastNote",
                        principalColumn: "BeastNoteId");
                    table.ForeignKey(
                        name: "FK_SenseList_Sense",
                        column: x => x.SenseFK,
                        principalTable: "Sense",
                        principalColumn: "SenseId");
                });

            migrationBuilder.CreateTable(
                name: "SkillList",
                columns: table => new
                {
                    SkillListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillFK = table.Column<int>(type: "int", nullable: false),
                    BeastNoteFK = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    Proficiency = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillList", x => x.SkillListId);
                    table.ForeignKey(
                        name: "FK_SkillList_BeastNote",
                        column: x => x.BeastNoteFK,
                        principalTable: "BeastNote",
                        principalColumn: "BeastNoteId");
                    table.ForeignKey(
                        name: "FK_SkillList_Skill",
                        column: x => x.SkillFK,
                        principalTable: "Skill",
                        principalColumn: "SkillId");
                });

            migrationBuilder.CreateTable(
                name: "SpeedList",
                columns: table => new
                {
                    SpeedListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpeedFK = table.Column<int>(type: "int", nullable: false),
                    BeastNoteFK = table.Column<int>(type: "int", nullable: false),
                    DistanceInFeer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpeedList", x => x.SpeedListId);
                    table.ForeignKey(
                        name: "FK_SpeedList_BeastNote",
                        column: x => x.BeastNoteFK,
                        principalTable: "BeastNote",
                        principalColumn: "BeastNoteId");
                    table.ForeignKey(
                        name: "FK_SpeedList_Speed",
                        column: x => x.SpeedFK,
                        principalTable: "Speed",
                        principalColumn: "SpeedId");
                });

            migrationBuilder.CreateTable(
                name: "SceneSave",
                columns: table => new
                {
                    SceneSaveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateOnly>(type: "date", nullable: false),
                    Title = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    SceneFK = table.Column<int>(type: "int", nullable: false),
                    CurrentBeastInitiative = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SceneSave", x => x.SceneSaveId);
                    table.ForeignKey(
                        name: "FK_SceneSave_Scene",
                        column: x => x.SceneFK,
                        principalTable: "Scene",
                        principalColumn: "SceneId");
                });

            migrationBuilder.CreateTable(
                name: "ActionResourceList",
                columns: table => new
                {
                    ActionResourceListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeastFK = table.Column<int>(type: "int", nullable: false),
                    ActionResourceFK = table.Column<int>(type: "int", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActionResourceList", x => x.ActionResourceListId);
                    table.ForeignKey(
                        name: "FK_ActionResourceList_ActionResource",
                        column: x => x.ActionResourceFK,
                        principalTable: "ActionResource",
                        principalColumn: "ActionResourceId");
                    table.ForeignKey(
                        name: "FK_ActionResourceList_Beast",
                        column: x => x.BeastFK,
                        principalTable: "Beast",
                        principalColumn: "BeastId");
                });

            migrationBuilder.CreateTable(
                name: "ConditionList",
                columns: table => new
                {
                    ConditionListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeastFK = table.Column<int>(type: "int", nullable: false),
                    ConditionFK = table.Column<int>(type: "int", nullable: false),
                    RoundCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionList", x => x.ConditionListId);
                    table.ForeignKey(
                        name: "FK_ConditionList_Beast",
                        column: x => x.BeastFK,
                        principalTable: "Beast",
                        principalColumn: "BeastId");
                    table.ForeignKey(
                        name: "FK_ConditionList_Condition",
                        column: x => x.ConditionFK,
                        principalTable: "Condition",
                        principalColumn: "ConditionId");
                });

            migrationBuilder.CreateTable(
                name: "SpellSlotsList",
                columns: table => new
                {
                    SpellSlotsListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeastFK = table.Column<int>(type: "int", nullable: false),
                    SlotLevel = table.Column<int>(type: "int", nullable: false),
                    CountAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellSlotsList", x => x.SpellSlotsListId);
                    table.ForeignKey(
                        name: "FK_SpellSlotsList_Beast",
                        column: x => x.BeastFK,
                        principalTable: "Beast",
                        principalColumn: "BeastId");
                });

            migrationBuilder.CreateTable(
                name: "TemporaryAbilityList",
                columns: table => new
                {
                    TemporaryAbilityListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeastFK = table.Column<int>(type: "int", nullable: false),
                    AbilityFK = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    SavingThrowProficiency = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemporaryAbilityList", x => x.TemporaryAbilityListId);
                    table.ForeignKey(
                        name: "FK_TemporaryAbilityList_Ability",
                        column: x => x.AbilityFK,
                        principalTable: "Ability",
                        principalColumn: "AbilityId");
                    table.ForeignKey(
                        name: "FK_TemporaryAbilityList_Beast",
                        column: x => x.BeastFK,
                        principalTable: "Beast",
                        principalColumn: "BeastId");
                });

            migrationBuilder.CreateTable(
                name: "BeastList",
                columns: table => new
                {
                    BeastListId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SceneSaveFK = table.Column<int>(type: "int", nullable: false),
                    BeastFK = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeastList", x => x.BeastListId);
                    table.ForeignKey(
                        name: "FK_BeastList_Beast",
                        column: x => x.BeastFK,
                        principalTable: "Beast",
                        principalColumn: "BeastId");
                    table.ForeignKey(
                        name: "FK_BeastList_SceneSave",
                        column: x => x.SceneSaveFK,
                        principalTable: "SceneSave",
                        principalColumn: "SceneSaveId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbilityList_AbilityFK",
                table: "AbilityList",
                column: "AbilityFK");

            migrationBuilder.CreateIndex(
                name: "IX_AbilityList_BeastNoteFK",
                table: "AbilityList",
                column: "BeastNoteFK");

            migrationBuilder.CreateIndex(
                name: "IX_Action_ActionResourceFK",
                table: "Action",
                column: "ActionResourceFK");

            migrationBuilder.CreateIndex(
                name: "IX_Action_BeastNoteFK",
                table: "Action",
                column: "BeastNoteFK");

            migrationBuilder.CreateIndex(
                name: "IX_Action_Cooldown3_TimeMeasureFK",
                table: "Action",
                column: "Cooldown3_TimeMeasureFK");

            migrationBuilder.CreateIndex(
                name: "IX_Action_CooldownTypeFK",
                table: "Action",
                column: "CooldownTypeFK");

            migrationBuilder.CreateIndex(
                name: "IX_ActionResourceList_ActionResourceFK",
                table: "ActionResourceList",
                column: "ActionResourceFK");

            migrationBuilder.CreateIndex(
                name: "IX_ActionResourceList_BeastFK",
                table: "ActionResourceList",
                column: "BeastFK");

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
                name: "IX_Beast_BeastNoteFK",
                table: "Beast",
                column: "BeastNoteFK");

            migrationBuilder.CreateIndex(
                name: "IX_Beast_FightTeamFK",
                table: "Beast",
                column: "FightTeamFK");

            migrationBuilder.CreateIndex(
                name: "IX_BeastList_BeastFK",
                table: "BeastList",
                column: "BeastFK");

            migrationBuilder.CreateIndex(
                name: "IX_BeastList_SceneSaveFK",
                table: "BeastList",
                column: "SceneSaveFK");

            migrationBuilder.CreateIndex(
                name: "IX_BeastNote_AlingmentFK",
                table: "BeastNote",
                column: "AlingmentFK");

            migrationBuilder.CreateIndex(
                name: "IX_BeastNote_BeastTypeFK",
                table: "BeastNote",
                column: "BeastTypeFK");

            migrationBuilder.CreateIndex(
                name: "IX_BeastNote_SizeFK",
                table: "BeastNote",
                column: "SizeFK");

            migrationBuilder.CreateIndex(
                name: "IX_BeastNote_SpellingInfoFK",
                table: "BeastNote",
                column: "SpellingInfoFK");

            migrationBuilder.CreateIndex(
                name: "IX_BeastNote_UserFK",
                table: "BeastNote",
                column: "UserFK");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionImmuneList_BeastNoteFK",
                table: "ConditionImmuneList",
                column: "BeastNoteFK");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionImmuneList_ConditionFK",
                table: "ConditionImmuneList",
                column: "ConditionFK");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionList_BeastFK",
                table: "ConditionList",
                column: "BeastFK");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionList_ConditionFK",
                table: "ConditionList",
                column: "ConditionFK");

            migrationBuilder.CreateIndex(
                name: "IX_DamageTendency_BeastNoteFK",
                table: "DamageTendency",
                column: "BeastNoteFK");

            migrationBuilder.CreateIndex(
                name: "IX_DamageTendency_DamageTendencyTypeFK",
                table: "DamageTendency",
                column: "DamageTendencyTypeFK");

            migrationBuilder.CreateIndex(
                name: "IX_DamageTendency_DamageTypeFK",
                table: "DamageTendency",
                column: "DamageTypeFK");

            migrationBuilder.CreateIndex(
                name: "IX_HabitatList_BeastNoteFK",
                table: "HabitatList",
                column: "BeastNoteFK");

            migrationBuilder.CreateIndex(
                name: "IX_HabitatList_HabitatFK",
                table: "HabitatList",
                column: "HabitatFK");

            migrationBuilder.CreateIndex(
                name: "IX_Scene_SettingFK",
                table: "Scene",
                column: "SettingFK");

            migrationBuilder.CreateIndex(
                name: "IX_Scene_UserFK",
                table: "Scene",
                column: "UserFK");

            migrationBuilder.CreateIndex(
                name: "IX_SceneSave_SceneFK",
                table: "SceneSave",
                column: "SceneFK");

            migrationBuilder.CreateIndex(
                name: "IX_SenseList_BeastNoteFK",
                table: "SenseList",
                column: "BeastNoteFK");

            migrationBuilder.CreateIndex(
                name: "IX_SenseList_SenseFK",
                table: "SenseList",
                column: "SenseFK");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_AbilityFK",
                table: "Skill",
                column: "AbilityFK");

            migrationBuilder.CreateIndex(
                name: "IX_SkillList_BeastNoteFK",
                table: "SkillList",
                column: "BeastNoteFK");

            migrationBuilder.CreateIndex(
                name: "IX_SkillList_SkillFK",
                table: "SkillList",
                column: "SkillFK");

            migrationBuilder.CreateIndex(
                name: "IX_SpeedList_BeastNoteFK",
                table: "SpeedList",
                column: "BeastNoteFK");

            migrationBuilder.CreateIndex(
                name: "IX_SpeedList_SpeedFK",
                table: "SpeedList",
                column: "SpeedFK");

            migrationBuilder.CreateIndex(
                name: "IX_SpellingInfo_SpellAbilityFK",
                table: "SpellingInfo",
                column: "SpellAbilityFK");

            migrationBuilder.CreateIndex(
                name: "IX_SpellSlot_SpellingInfoFK",
                table: "SpellSlot",
                column: "SpellingInfoFK");

            migrationBuilder.CreateIndex(
                name: "IX_SpellSlotsList_BeastFK",
                table: "SpellSlotsList",
                column: "BeastFK");

            migrationBuilder.CreateIndex(
                name: "IX_TemporaryAbilityList_AbilityFK",
                table: "TemporaryAbilityList",
                column: "AbilityFK");

            migrationBuilder.CreateIndex(
                name: "IX_TemporaryAbilityList_BeastFK",
                table: "TemporaryAbilityList",
                column: "BeastFK");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "User",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_User_CreatorsTeamFK",
                table: "User",
                column: "CreatorsTeamFK");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "User",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbilityList");

            migrationBuilder.DropTable(
                name: "Action");

            migrationBuilder.DropTable(
                name: "ActionResourceList");

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
                name: "BeastList");

            migrationBuilder.DropTable(
                name: "ConditionImmuneList");

            migrationBuilder.DropTable(
                name: "ConditionList");

            migrationBuilder.DropTable(
                name: "DamageTendency");

            migrationBuilder.DropTable(
                name: "HabitatList");

            migrationBuilder.DropTable(
                name: "SenseList");

            migrationBuilder.DropTable(
                name: "SkillList");

            migrationBuilder.DropTable(
                name: "SpeedList");

            migrationBuilder.DropTable(
                name: "SpellSlot");

            migrationBuilder.DropTable(
                name: "SpellSlotsList");

            migrationBuilder.DropTable(
                name: "TemporaryAbilityList");

            migrationBuilder.DropTable(
                name: "CooldownType");

            migrationBuilder.DropTable(
                name: "TimeMeasure");

            migrationBuilder.DropTable(
                name: "ActionResource");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "SceneSave");

            migrationBuilder.DropTable(
                name: "Condition");

            migrationBuilder.DropTable(
                name: "DamageTendencyType");

            migrationBuilder.DropTable(
                name: "DamageType");

            migrationBuilder.DropTable(
                name: "Habitat");

            migrationBuilder.DropTable(
                name: "Sense");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "Speed");

            migrationBuilder.DropTable(
                name: "Beast");

            migrationBuilder.DropTable(
                name: "Scene");

            migrationBuilder.DropTable(
                name: "BeastNote");

            migrationBuilder.DropTable(
                name: "FightTeam");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DropTable(
                name: "Alignment");

            migrationBuilder.DropTable(
                name: "BeastType");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropTable(
                name: "SpellingInfo");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Ability");

            migrationBuilder.DropTable(
                name: "CreatorsTeam");
        }
    }
}
