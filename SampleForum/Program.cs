var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    //��� ������������� ����������/������ �������������� �� "/error", ����� �������� 
    //�� ���� ������������
    app.UseExceptionHandler("/Error");
    //��� ������������, ����� ������������� ssl ����������
    //������ ��� ����� ���� ����� ����������� ����� http, ������� ����� ������������� 
    //�� https
    app.UseHsts();
}

//��������� ���������� ������������� �� https
app.UseHttpsRedirection();

//��������� ��� �������� ����������� ������ �������
app.UseStaticFiles();

//��������� ������������ �������� �
//��������� �������� ���������� ����� �� ������ �� ����������� �������� �-�: /profile
app.UseRouting();

//���������� ��������� ��� ����������� ���� ������������
app.UseAuthorization();

app.MapRazorPages();
app.Run();



//routing � asp.net - https://metanit.com/sharp/aspnet6/3.1.php
//������� ������������� �������� �� ������������� �������� �������� � ���������� �
//�� ��������� ����������� ������������� ��������
//��� ��������� ������� ������������ �������� ����� ����������.
//�������� ����� ��� endpoint ������������ ��������� ���,
//������� ������������ ������.
//�� ���� �������� ����� ���������� ������ ��������, �������� ������ ��������������� ������,
//� ���������� ������� �� ����� ��������.
//-------
//����� ��� ��������� �������� ����� ��� ��������� �������� ���� GET
//-------
// � �������� ��������� pattern ��������� ������ ��������, �������� ������ ��������������� ������.
// ������ �������� ����� ������������ ��� RoutePattern ��� string.
//�-�: app.Map("/", () => "Index Page"); ��� app.Map("/about", () => "About Page"); ��� app.Map("/contact", () => "Contacts Page");