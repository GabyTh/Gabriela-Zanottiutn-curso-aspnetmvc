using FluentValidation;
using System;
using System.ComponentModel.DataAnnotations;

namespace UTNCurso.Core.DTOs
{
    public class TodoItemDto
    {
        public long Id { get; set; }

        // [Required]
        // [MaxLength(10)]
        public string Task { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime? LastModifiedDate { get; set; }
    }

    public class TodoItemDtoValidator : AbstractValidator<TodoItemDto>
    {
        public TodoItemDtoValidator()
        {
            RuleFor(x => x.Task).NotNull();
            RuleFor(x => x.Task).Length(0, 10);
        }
    }
}
