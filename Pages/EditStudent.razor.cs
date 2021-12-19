using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using UAS.Models;
using UAS.Services;

namespace UAS.Pages
{
    public partial class EditStudent
    {
        public Student Student { get; set; } = new Student();
        [Inject]
        public IStudentService StudentService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Parameter]
        public string id { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Student = await StudentService.GetById(id);
        }
        protected async Task HandleValidSubmit(){
            Student result = await StudentService.Update(id,Student);
            NavigationManager.NavigateTo("studentpage");
        }
    }
}