﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoEscolaWebApi.Data;

namespace ProjetoEscolaWebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("ProjetoEscola_WebAPI.Models.Aluno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("sobrenome")
                        .HasColumnType("TEXT");

                    b.Property<string>("telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            id = 1,
                            nome = "Marta",
                            sobrenome = "Kent",
                            telefone = "33225555"
                        },
                        new
                        {
                            id = 2,
                            nome = "Paula",
                            sobrenome = "Isabela",
                            telefone = "3354288"
                        },
                        new
                        {
                            id = 3,
                            nome = "Laura",
                            sobrenome = "Antonia",
                            telefone = "55668899"
                        },
                        new
                        {
                            id = 4,
                            nome = "Luiza",
                            sobrenome = "Maria",
                            telefone = "6565659"
                        },
                        new
                        {
                            id = 5,
                            nome = "Lucas",
                            sobrenome = "Machado",
                            telefone = "565685415"
                        },
                        new
                        {
                            id = 6,
                            nome = "Pedro",
                            sobrenome = "Alvares",
                            telefone = "456454545"
                        },
                        new
                        {
                            id = 7,
                            nome = "Paulo",
                            sobrenome = "José",
                            telefone = "9874512"
                        });
                });

            modelBuilder.Entity("ProjetoEscola_WebAPI.Models.AlunoDisciplina", b =>
                {
                    b.Property<int>("alunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("disciplinaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("alunoId", "disciplinaId");

                    b.HasIndex("disciplinaId");

                    b.ToTable("AlunosDisciplinas");

                    b.HasData(
                        new
                        {
                            alunoId = 1,
                            disciplinaId = 2
                        },
                        new
                        {
                            alunoId = 1,
                            disciplinaId = 4
                        },
                        new
                        {
                            alunoId = 1,
                            disciplinaId = 5
                        },
                        new
                        {
                            alunoId = 2,
                            disciplinaId = 1
                        },
                        new
                        {
                            alunoId = 2,
                            disciplinaId = 2
                        },
                        new
                        {
                            alunoId = 2,
                            disciplinaId = 5
                        },
                        new
                        {
                            alunoId = 3,
                            disciplinaId = 1
                        },
                        new
                        {
                            alunoId = 3,
                            disciplinaId = 2
                        },
                        new
                        {
                            alunoId = 3,
                            disciplinaId = 3
                        },
                        new
                        {
                            alunoId = 4,
                            disciplinaId = 1
                        },
                        new
                        {
                            alunoId = 4,
                            disciplinaId = 4
                        },
                        new
                        {
                            alunoId = 4,
                            disciplinaId = 5
                        },
                        new
                        {
                            alunoId = 5,
                            disciplinaId = 4
                        },
                        new
                        {
                            alunoId = 5,
                            disciplinaId = 5
                        },
                        new
                        {
                            alunoId = 6,
                            disciplinaId = 1
                        },
                        new
                        {
                            alunoId = 6,
                            disciplinaId = 2
                        },
                        new
                        {
                            alunoId = 6,
                            disciplinaId = 3
                        },
                        new
                        {
                            alunoId = 6,
                            disciplinaId = 4
                        },
                        new
                        {
                            alunoId = 7,
                            disciplinaId = 1
                        },
                        new
                        {
                            alunoId = 7,
                            disciplinaId = 2
                        },
                        new
                        {
                            alunoId = 7,
                            disciplinaId = 3
                        },
                        new
                        {
                            alunoId = 7,
                            disciplinaId = 4
                        },
                        new
                        {
                            alunoId = 7,
                            disciplinaId = 5
                        });
                });

            modelBuilder.Entity("ProjetoEscola_WebAPI.Models.Disciplina", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("professorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("professorId");

                    b.ToTable("Disciplinas");

                    b.HasData(
                        new
                        {
                            id = 1,
                            nome = "Matemática",
                            professorId = 1
                        },
                        new
                        {
                            id = 2,
                            nome = "Física",
                            professorId = 2
                        },
                        new
                        {
                            id = 3,
                            nome = "Português",
                            professorId = 3
                        },
                        new
                        {
                            id = 4,
                            nome = "Inglês",
                            professorId = 4
                        },
                        new
                        {
                            id = 5,
                            nome = "Programação",
                            professorId = 5
                        });
                });

            modelBuilder.Entity("ProjetoEscola_WebAPI.Models.Professor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("sobrenome")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Professores");

                    b.HasData(
                        new
                        {
                            id = 1,
                            nome = "Lauro",
                            sobrenome = "André"
                        },
                        new
                        {
                            id = 2,
                            nome = "Roberto",
                            sobrenome = "Mendonça"
                        },
                        new
                        {
                            id = 3,
                            nome = "Rodolfo",
                            sobrenome = "Exler"
                        },
                        new
                        {
                            id = 4,
                            nome = "Victor",
                            sobrenome = "Winitskowski"
                        },
                        new
                        {
                            id = 5,
                            nome = "Carlos",
                            sobrenome = "Mattos"
                        });
                });

            modelBuilder.Entity("ProjetoEscola_WebAPI.Models.AlunoDisciplina", b =>
                {
                    b.HasOne("ProjetoEscola_WebAPI.Models.Aluno", "aluno")
                        .WithMany()
                        .HasForeignKey("alunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProjetoEscola_WebAPI.Models.Disciplina", "disciplina")
                        .WithMany()
                        .HasForeignKey("disciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjetoEscola_WebAPI.Models.Disciplina", b =>
                {
                    b.HasOne("ProjetoEscola_WebAPI.Models.Professor", "professor")
                        .WithMany("disciplinas")
                        .HasForeignKey("professorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
