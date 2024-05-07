using System;
using System.Windows;

// 1_project_setting.cs

// 핵심 : WPF 를 사용하도록 project 설정 변경하는 법
// 콘솔 프로젝트 생성후
// => project.csproj   파일에 항목 변경
// <TargetFramework>net8.0-winidows</TargetFramework>
// <UseWPF>true</UseWPF>


class Program
{
    public static void Main()
    {
        MessageBox.Show("Hello, WPF");
    }
}

// 빌드해보세요. 에러 발생합니다.
// => 원인   : WPF 프로젝트가 아닌 Console 프로젝트 이기 때문에
// => 해결책 : Project 설정 변경