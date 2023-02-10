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

//��������� ���������� �������������
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
