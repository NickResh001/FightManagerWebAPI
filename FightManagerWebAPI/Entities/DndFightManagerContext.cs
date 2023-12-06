using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FightManagerWebAPI.Entities;

public partial class DndFightManagerContext : IdentityDbContext<User>
{
    public DndFightManagerContext()
    {
    }

    public DndFightManagerContext(DbContextOptions<DndFightManagerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ability> Abilities { get; set; }

    public virtual DbSet<AbilityList> AbilityLists { get; set; }

    public virtual DbSet<Action> Actions { get; set; }

    public virtual DbSet<ActionResource> ActionResources { get; set; }

    public virtual DbSet<ActionResourceList> ActionResourceLists { get; set; }

    public virtual DbSet<Alignment> Alignments { get; set; }

    public virtual DbSet<Beast> Beasts { get; set; }

    public virtual DbSet<BeastList> BeastLists { get; set; }

    public virtual DbSet<BeastNote> BeastNotes { get; set; }

    public virtual DbSet<BeastType> BeastTypes { get; set; }

    public virtual DbSet<Condition> Conditions { get; set; }

    public virtual DbSet<ConditionImmuneList> ConditionImmuneLists { get; set; }

    public virtual DbSet<ConditionList> ConditionLists { get; set; }

    public virtual DbSet<CooldownType> CooldownTypes { get; set; }

    public virtual DbSet<CreatorsTeam> CreatorsTeams { get; set; }

    public virtual DbSet<DamageTendency> DamageTendencies { get; set; }

    public virtual DbSet<DamageTendencyType> DamageTendencyTypes { get; set; }

    public virtual DbSet<DamageType> DamageTypes { get; set; }

    public virtual DbSet<FightTeam> FightTeams { get; set; }

    public virtual DbSet<Habitat> Habitats { get; set; }

    public virtual DbSet<HabitatList> HabitatLists { get; set; }

    public virtual DbSet<Scene> Scenes { get; set; }

    public virtual DbSet<SceneSave> SceneSaves { get; set; }

    public virtual DbSet<Sense> Senses { get; set; }

    public virtual DbSet<SenseList> SenseLists { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<Size> Sizes { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }

    public virtual DbSet<SkillList> SkillLists { get; set; }

    public virtual DbSet<Speed> Speeds { get; set; }

    public virtual DbSet<SpeedList> SpeedLists { get; set; }

    public virtual DbSet<SpellSlot> SpellSlots { get; set; }

    public virtual DbSet<SpellSlotsList> SpellSlotsLists { get; set; }

    public virtual DbSet<SpellingInfo> SpellingInfos { get; set; }

    public virtual DbSet<TemporaryAbilityList> TemporaryAbilityLists { get; set; }

    public virtual DbSet<TimeMeasure> TimeMeasures { get; set; }

    //public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=laptop-4vtejnu0\\SQLEXPRESS;Database=DndFightManager1;Trusted_Connection=True;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Ability>(entity =>
        {
            entity.ToTable("Ability");

            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AbilityList>(entity =>
        {
            entity.ToTable("AbilityList");

            entity.Property(e => e.AbilityFk).HasColumnName("AbilityFK");
            entity.Property(e => e.BeastNoteFk).HasColumnName("BeastNoteFK");

            entity.HasOne(d => d.AbilityFkNavigation).WithMany(p => p.AbilityLists)
                .HasForeignKey(d => d.AbilityFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AbilityList_Ability");

            entity.HasOne(d => d.BeastNoteFkNavigation).WithMany(p => p.AbilityLists)
                .HasForeignKey(d => d.BeastNoteFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AbilityList_BeastNote");
        });

        modelBuilder.Entity<Action>(entity =>
        {
            entity.ToTable("Action");

            entity.Property(e => e.ActionResourceFk).HasColumnName("ActionResourceFK");
            entity.Property(e => e.BeastNoteFk).HasColumnName("BeastNoteFK");
            entity.Property(e => e.Cooldown1ShellSlotLevel).HasColumnName("Cooldown1_ShellSlotLevel");
            entity.Property(e => e.Cooldown2DiceSize).HasColumnName("Cooldown2_DiceSize");
            entity.Property(e => e.Cooldown2LowerRangeLimit).HasColumnName("Cooldown2_LowerRangeLimit");
            entity.Property(e => e.Cooldown2UpperRangeLimit).HasColumnName("Cooldown2_UpperRangeLimit");
            entity.Property(e => e.Cooldown3HowManyTimes).HasColumnName("Cooldown3_HowManyTimes");
            entity.Property(e => e.Cooldown3MeasureMultiply).HasColumnName("Cooldown3_MeasureMultiply");
            entity.Property(e => e.Cooldown3TimeMeasureFk).HasColumnName("Cooldown3_TimeMeasureFK");
            entity.Property(e => e.CooldownTypeFk).HasColumnName("CooldownTypeFK");
            entity.Property(e => e.Description)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.LairInitiativeBonus).HasColumnName("Lair_InitiativeBonus");
            entity.Property(e => e.ParentMultiactionFk).HasColumnName("ParentMultiactionFK");
            entity.Property(e => e.ReactionCondition)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("Reaction_Condition");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.ActionResourceFkNavigation).WithMany(p => p.Actions)
                .HasForeignKey(d => d.ActionResourceFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Action_ActionResource");

            entity.HasOne(d => d.BeastNoteFkNavigation).WithMany(p => p.Actions)
                .HasForeignKey(d => d.BeastNoteFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Action_BeastNote");

            entity.HasOne(d => d.Cooldown3TimeMeasureFkNavigation).WithMany(p => p.Actions)
                .HasForeignKey(d => d.Cooldown3TimeMeasureFk)
                .HasConstraintName("FK_Action_TimeMeasure");

            entity.HasOne(d => d.CooldownTypeFkNavigation).WithMany(p => p.Actions)
                .HasForeignKey(d => d.CooldownTypeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Action_CooldownType");
        });

        modelBuilder.Entity<ActionResource>(entity =>
        {
            entity.ToTable("ActionResource");

            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ActionResourceList>(entity =>
        {
            entity.ToTable("ActionResourceList");

            entity.Property(e => e.ActionResourceFk).HasColumnName("ActionResourceFK");
            entity.Property(e => e.BeastFk).HasColumnName("BeastFK");

            entity.HasOne(d => d.ActionResourceFkNavigation).WithMany(p => p.ActionResourceLists)
                .HasForeignKey(d => d.ActionResourceFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActionResourceList_ActionResource");

            entity.HasOne(d => d.BeastFkNavigation).WithMany(p => p.ActionResourceLists)
                .HasForeignKey(d => d.BeastFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ActionResourceList_Beast");
        });

        modelBuilder.Entity<Alignment>(entity =>
        {
            entity.ToTable("Alignment");

            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Beast>(entity =>
        {
            entity.ToTable("Beast");

            entity.Property(e => e.BeastNoteFk).HasColumnName("BeastNoteFK");
            entity.Property(e => e.CurrentInitiative)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FightTeamFk).HasColumnName("FightTeamFK");
            entity.Property(e => e.Title)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.BeastNoteFkNavigation).WithMany(p => p.Beasts)
                .HasForeignKey(d => d.BeastNoteFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Beast_BeastNote");

            entity.HasOne(d => d.FightTeamFkNavigation).WithMany(p => p.Beasts)
                .HasForeignKey(d => d.FightTeamFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Beast_FightTeam");
        });

        modelBuilder.Entity<BeastList>(entity =>
        {
            entity.ToTable("BeastList");

            entity.Property(e => e.BeastFk).HasColumnName("BeastFK");
            entity.Property(e => e.SceneSaveFk).HasColumnName("SceneSaveFK");

            entity.HasOne(d => d.BeastFkNavigation).WithMany(p => p.BeastLists)
                .HasForeignKey(d => d.BeastFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BeastList_Beast");

            entity.HasOne(d => d.SceneSaveFkNavigation).WithMany(p => p.BeastLists)
                .HasForeignKey(d => d.SceneSaveFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BeastList_SceneSave");
        });

        modelBuilder.Entity<BeastNote>(entity =>
        {
            entity.ToTable("BeastNote");

            entity.Property(e => e.AlingmentFk).HasColumnName("AlingmentFK");
            entity.Property(e => e.BeastTypeFk).HasColumnName("BeastTypeFK");
            entity.Property(e => e.Description).HasMaxLength(4000);
            entity.Property(e => e.HitPointDice)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SizeFk).HasColumnName("SizeFK");
            entity.Property(e => e.SpellingInfoFk).HasColumnName("SpellingInfoFK");
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UserFk).HasColumnName("UserFK");

            entity.HasOne(d => d.AlingmentFkNavigation).WithMany(p => p.BeastNotes)
                .HasForeignKey(d => d.AlingmentFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BeastNote_Alignment");

            entity.HasOne(d => d.BeastTypeFkNavigation).WithMany(p => p.BeastNotes)
                .HasForeignKey(d => d.BeastTypeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BeastNote_BeastType");

            entity.HasOne(d => d.SizeFkNavigation).WithMany(p => p.BeastNotes)
                .HasForeignKey(d => d.SizeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BeastNote_Size");

            entity.HasOne(d => d.UserFkNavigation).WithMany(p => p.BeastNotes)
                .HasForeignKey(d => d.UserFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BeastNote_User");

            entity.HasOne(d => d.SpellingInfoFkNavigation).WithMany(p => p.BeastNotes)
                .HasForeignKey(d => d.SpellingInfoFk)
                .HasConstraintName("FK_BeastNote_SpellingInfo");
        });

        modelBuilder.Entity<BeastType>(entity =>
        {
            entity.ToTable("BeastType");

            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Condition>(entity =>
        {
            entity.ToTable("Condition");

            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ConditionImmuneList>(entity =>
        {
            entity.ToTable("ConditionImmuneList");

            entity.Property(e => e.BeastNoteFk).HasColumnName("BeastNoteFK");
            entity.Property(e => e.ConditionFk).HasColumnName("ConditionFK");

            entity.HasOne(d => d.BeastNoteFkNavigation).WithMany(p => p.ConditionImmuneLists)
                .HasForeignKey(d => d.BeastNoteFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConditionImmuneList_BeastNote");

            entity.HasOne(d => d.ConditionFkNavigation).WithMany(p => p.ConditionImmuneLists)
                .HasForeignKey(d => d.ConditionFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConditionImmuneList_Condition");
        });

        modelBuilder.Entity<ConditionList>(entity =>
        {
            entity.ToTable("ConditionList");

            entity.Property(e => e.BeastFk).HasColumnName("BeastFK");
            entity.Property(e => e.ConditionFk).HasColumnName("ConditionFK");

            entity.HasOne(d => d.BeastFkNavigation).WithMany(p => p.ConditionLists)
                .HasForeignKey(d => d.BeastFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConditionList_Beast");

            entity.HasOne(d => d.ConditionFkNavigation).WithMany(p => p.ConditionLists)
                .HasForeignKey(d => d.ConditionFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConditionList_Condition");
        });

        modelBuilder.Entity<CooldownType>(entity =>
        {
            entity.HasKey(e => e.CooldownTypeId).HasName("PK_Cooldown");

            entity.ToTable("CooldownType");

            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CreatorsTeam>(entity =>
        {
            entity.ToTable("CreatorsTeam");

            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DamageTendency>(entity =>
        {
            entity.ToTable("DamageTendency");

            entity.Property(e => e.BeastNoteFk).HasColumnName("BeastNoteFK");
            entity.Property(e => e.DamageTendencyTypeFk).HasColumnName("DamageTendencyTypeFK");
            entity.Property(e => e.DamageTypeFk).HasColumnName("DamageTypeFK");

            entity.HasOne(d => d.BeastNoteFkNavigation).WithMany(p => p.DamageTendencies)
                .HasForeignKey(d => d.BeastNoteFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DamageTendency_BeastNote");

            entity.HasOne(d => d.DamageTendencyTypeFkNavigation).WithMany(p => p.DamageTendencies)
                .HasForeignKey(d => d.DamageTendencyTypeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DamageTendency_DamageTendencyType");

            entity.HasOne(d => d.DamageTypeFkNavigation).WithMany(p => p.DamageTendencies)
                .HasForeignKey(d => d.DamageTypeFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DamageTendency_DamageType");
        });

        modelBuilder.Entity<DamageTendencyType>(entity =>
        {
            entity.ToTable("DamageTendencyType");

            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DamageType>(entity =>
        {
            entity.ToTable("DamageType");

            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FightTeam>(entity =>
        {
            entity.ToTable("FightTeam");

            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Habitat>(entity =>
        {
            entity.ToTable("Habitat");

            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HabitatList>(entity =>
        {
            entity.ToTable("HabitatList");

            entity.Property(e => e.BeastNoteFk).HasColumnName("BeastNoteFK");
            entity.Property(e => e.HabitatFk).HasColumnName("HabitatFK");

            entity.HasOne(d => d.BeastNoteFkNavigation).WithMany(p => p.HabitatLists)
                .HasForeignKey(d => d.BeastNoteFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HabitatList_BeastNote");

            entity.HasOne(d => d.HabitatFkNavigation).WithMany(p => p.HabitatLists)
                .HasForeignKey(d => d.HabitatFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HabitatList_Habitat");
        });

        modelBuilder.Entity<Scene>(entity =>
        {
            entity.ToTable("Scene");

            entity.Property(e => e.SettingFk).HasColumnName("SettingFK");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserFk).HasColumnName("UserFK");

            entity.HasOne(d => d.SettingFkNavigation).WithMany(p => p.Scenes)
                .HasForeignKey(d => d.SettingFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Scene_Setting");

            entity.HasOne(d => d.UserFkNavigation).WithMany(p => p.Scenes)
                .HasForeignKey(d => d.UserFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Scene_User");
        });

        modelBuilder.Entity<SceneSave>(entity =>
        {
            entity.ToTable("SceneSave");

            entity.Property(e => e.CurrentBeastInitiative)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SceneFk).HasColumnName("SceneFK");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.SceneFkNavigation).WithMany(p => p.SceneSaves)
                .HasForeignKey(d => d.SceneFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SceneSave_Scene");
        });

        modelBuilder.Entity<Sense>(entity =>
        {
            entity.ToTable("Sense");

            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SenseList>(entity =>
        {
            entity.ToTable("SenseList");

            entity.Property(e => e.BeastNoteFk).HasColumnName("BeastNoteFK");
            entity.Property(e => e.SenseFk).HasColumnName("SenseFK");

            entity.HasOne(d => d.BeastNoteFkNavigation).WithMany(p => p.SenseLists)
                .HasForeignKey(d => d.BeastNoteFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SenseList_BeastNote");

            entity.HasOne(d => d.SenseFkNavigation).WithMany(p => p.SenseLists)
                .HasForeignKey(d => d.SenseFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SenseList_Sense");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.ToTable("Setting");

            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Size>(entity =>
        {
            entity.ToTable("Size");

            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.ToTable("Skill");

            entity.Property(e => e.AbilityFk).HasColumnName("AbilityFK");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.AbilityFkNavigation).WithMany(p => p.Skills)
                .HasForeignKey(d => d.AbilityFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Skill_Ability");
        });

        modelBuilder.Entity<SkillList>(entity =>
        {
            entity.ToTable("SkillList");

            entity.Property(e => e.BeastNoteFk).HasColumnName("BeastNoteFK");
            entity.Property(e => e.SkillFk).HasColumnName("SkillFK");

            entity.HasOne(d => d.BeastNoteFkNavigation).WithMany(p => p.SkillLists)
                .HasForeignKey(d => d.BeastNoteFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SkillList_BeastNote");

            entity.HasOne(d => d.SkillFkNavigation).WithMany(p => p.SkillLists)
                .HasForeignKey(d => d.SkillFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SkillList_Skill");
        });

        modelBuilder.Entity<Speed>(entity =>
        {
            entity.ToTable("Speed");

            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SpeedList>(entity =>
        {
            entity.ToTable("SpeedList");

            entity.Property(e => e.BeastNoteFk).HasColumnName("BeastNoteFK");
            entity.Property(e => e.SpeedFk).HasColumnName("SpeedFK");

            entity.HasOne(d => d.BeastNoteFkNavigation).WithMany(p => p.SpeedLists)
                .HasForeignKey(d => d.BeastNoteFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SpeedList_BeastNote");

            entity.HasOne(d => d.SpeedFkNavigation).WithMany(p => p.SpeedLists)
                .HasForeignKey(d => d.SpeedFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SpeedList_Speed");
        });

        modelBuilder.Entity<SpellSlot>(entity =>
        {
            entity.ToTable("SpellSlot");

            entity.Property(e => e.SpellingInfoFk).HasColumnName("SpellingInfoFK");

            entity.HasOne(d => d.SpellingInfoFkNavigation).WithMany(p => p.SpellSlots)
                .HasForeignKey(d => d.SpellingInfoFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SpellSlot_SpellingInfo");
        });

        modelBuilder.Entity<SpellSlotsList>(entity =>
        {
            entity.ToTable("SpellSlotsList");

            entity.Property(e => e.BeastFk).HasColumnName("BeastFK");

            entity.HasOne(d => d.BeastFkNavigation).WithMany(p => p.SpellSlotsLists)
                .HasForeignKey(d => d.BeastFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SpellSlotsList_Beast");
        });

        modelBuilder.Entity<SpellingInfo>(entity =>
        {
            entity.ToTable("SpellingInfo");

            entity.Property(e => e.SpellAbilityFk).HasColumnName("SpellAbilityFK");

            entity.HasOne(d => d.SpellAbilityFkNavigation).WithMany(p => p.SpellingInfos)
                .HasForeignKey(d => d.SpellAbilityFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SpellingInfo_Ability");
        });

        modelBuilder.Entity<TemporaryAbilityList>(entity =>
        {
            entity.ToTable("TemporaryAbilityList");

            entity.Property(e => e.AbilityFk).HasColumnName("AbilityFK");
            entity.Property(e => e.BeastFk).HasColumnName("BeastFK");

            entity.HasOne(d => d.AbilityFkNavigation).WithMany(p => p.TemporaryAbilityLists)
                .HasForeignKey(d => d.AbilityFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TemporaryAbilityList_Ability");

            entity.HasOne(d => d.BeastFkNavigation).WithMany(p => p.TemporaryAbilityLists)
                .HasForeignKey(d => d.BeastFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TemporaryAbilityList_Beast");
        });

        modelBuilder.Entity<TimeMeasure>(entity =>
        {
            entity.ToTable("TimeMeasure");

            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.CreatorsTeamFk).HasColumnName("CreatorsTeamFK");

            entity.HasOne(d => d.CreatorsTeamFkNavigation).WithMany()
                .HasForeignKey(d => d.CreatorsTeamFk)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_CreatorsTeam");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
