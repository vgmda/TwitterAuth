## Twitter Authentication App
> This application allows the users to sign in with their Twitter account using OAuth 1a APIs provided by Twitter. One benefit of OAuth is the ability to use third-party authentication systems to authenticate our users. This functionality is implemented at the login & register page.

## Work-plan
1. Add the `Microsoft.AspNetCore.Authentication.Twitter` NuGet package to the project.
2. Navigate to twitter developer portal dashboard and sign in.
3. Create a project within the twitter developer portal.
4. Click on `Add App`. Insert the App name then record the generated `API Key`, `API Key Secret`. 
5. In the App Settings page, select `Edit` in the Authentication settings section, then:
    - Enable 3-legged OAuth
    - Request email address from users
    - Fill out the required fields and select Save
