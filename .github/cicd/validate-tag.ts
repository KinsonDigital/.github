// Validate the arguments
if (Deno.args.length !== 3) {
    let errorMsg = "The 'validate-tag' cicd script must have two arguments.";
    errorMsg += "\nThe first arg must be either 'production', 'preview' or 'either'.";
    errorMsg += "\nThe second arg must be the name of the tag.";

    throw new Error(errorMsg);
}

const tagType: string = Deno.args[0].toLowerCase();

if (tagType !== "production" && tagType !== "preview" && tagType !== "either") {
    let errorMsg = "The tag type argument must be a value of 'production', 'preview' or 'either'.";
    errorMsg += "\nThe value is case-insensitive.";

    throw new Error(errorMsg);
}

const projectName: string = Deno.args[2];

const prodVersionRegex = /^v[0-9]+\.[0-9]+\.[0-9]+$/;
const prevVersionRegex = /^v[0-9]+\.[0-9]+\.[0-9]+-preview\.[0-9]+$/;

let tag: string = Deno.args[1];

tag = tag.startsWith("v")
    ? tag
    : `v${tag}`;

let isValid = false;

switch (tagType) {
    case "production":
        isValid = prodVersionRegex.test(tag);
        break;
    case "preview":
        isValid = prevVersionRegex.test(tag);
        break;
    case "either":
        isValid = prodVersionRegex.test(tag) || prevVersionRegex.test(tag);
        break;
    default:
        break;
}

if (isValid === false) {
    throw new Error(`The tag is not in the correct ${tagType} version syntax.`);
}

const tagsUrl = `https://api.github.com/repos/KinsonDigital/${projectName}/tags`;
const response = await fetch(tagsUrl);
const responseData = <{ name: ""}[]>await response.json();

const tags: string[] = responseData.map((tagObj) => tagObj.name);

const tagExists: boolean = tags.some(t => t === tag);

if (tagExists) {
    throw new Error(`The tag '${tag}' already exists.`);
}
