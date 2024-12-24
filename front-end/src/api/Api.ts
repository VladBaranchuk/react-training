type ValidationError = {
    propertyName: string,
    errorMessage: string
}

type ErrorMessage = {
    errorMessage: string,
    validationErrors?: ValidationError[]
}

export const request = async <TResponse>(url: string, config: RequestInit): Promise<TResponse | null> => {
    const response = await fetch(url, config);
    const result = await response.json();
    
    if(response.status >= 400) {
        let error = result as ErrorMessage;
        console.log(error);
        alert(error.errorMessage);
        return null;
    }

    return result as TResponse; 
}

export const header = (method: string, requestBody?: string): RequestInit => {
    return {
        method: method,
        headers: {
            'Content-Type': 'application/json'
        },
        body: requestBody
    }
}

export const host = "https://localhost:7120";